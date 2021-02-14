using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSUIPC;
using RestSharp;

namespace realvaClient
{
    public partial class frmMain : Form
    {

        // =====================================
        // DECLARE OFFSETS YOU WANT TO USE HERE
        // =====================================
        private Offset<uint> airspeed = new Offset<uint>(0x02BC);
        private Offset<short> onGround = new Offset<short>(0x0366);
        private Offset<int> verticalSpeed = new Offset<int>(0x030C);
        private Offset<uint> avionicsMaster = new Offset<uint>(0x2E80);
        private Offset<string> model = new Offset<string>(0x3500, 24);
        private bool tookOf = false;
        private double landingRate;

        private Offset<FsLongitude> playerLon = new Offset<FsLongitude>("LatLonPoint", 0x0568, 8);
        private Offset<FsLatitude> playerLat = new Offset<FsLatitude>("LatLonPoint", 0x0560, 8);

        private Boolean flightStarted = false;

        private Double depLat;
        private Double depLon;
        private Double arrLat;
        private Double arrLon;
        private String startTime;
        private String endTime;
        private String aircraft;
        private String savedCode;
        private Double startFuel;
        private Double endFuel;
        private Double currentFuel;
        private String departure;
        private String arrival;

        public frmMain()
        {
            InitializeComponent();
            configureForm();
            this.txtDeparture.CharacterCasing = CharacterCasing.Upper;
            this.txtArrival.CharacterCasing = CharacterCasing.Upper;
            try
            {
                this.savedCode = File.ReadAllText("settings.txt");
                this.txtSecretCode.Text = this.savedCode;
            }
            catch (FileNotFoundException e)
            {

            }
            configureStartFlight();
        }

        // The connect/disconnect buton
        private void btnToggleConnection_Click(object sender, EventArgs e)
        {
            if (FSUIPCConnection.IsOpen)
            {
                // Connection is currently open
                // Stop the main timer
                this.timerMain.Stop();
                // Close the connection
                FSUIPCConnection.Close();
            }
            else
            {
                // Try to open the connection
                try
                {
                    this.lblConnectionStatus.Text = "Looking for a flight simulator...";
                    this.lblConnectionStatus.ForeColor = Color.Goldenrod;
                    FSUIPCConnection.Open();
                    // If there was no problem, start the main timer
                    this.timerMain.Start();
                }
                catch (Exception ex)
                {
                    // An error occured. Tell the user.
                    MessageBox.Show("Connection Failed\n\n" + ex.Message, "FSUIPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            configureForm();

        }

        // This method runs 20 times per second (every 50ms). This is set on the timerMain properties.
        private void timerMain_Tick(object sender, EventArgs e)
        {
            // Call process() to read/write data to/from FSUIPC
            // We do this in a Try/Catch block incase something goes wrong
            try
            {
                FSUIPCConnection.Process();
                FSUIPCConnection.Process("LatLonPoint");
                if (this.onGround.Value == 0)
                {
                    this.tookOf = true;
                }

                if (this.onGround.Value == 1 && this.tookOf == true)
                {
                    double verticalSpeedMPS = (double)this.verticalSpeed.Value / 256d;
                    double verticalSpeedFPM = verticalSpeedMPS * 60d * 3.28084d;
                    this.landingRate = verticalSpeedFPM;
                    this.tookOf = false;
                }

                // Update the information on the form
                // (See the Examples Application for more information on using Offsets).

      
              

                FsLatLonPoint playerPos = new FsLatLonPoint(this.playerLat.Value, this.playerLon.Value);
                this.txtAircraft.Text = this.model.Value;

                PayloadServices ps = FSUIPCConnection.PayloadServices;
                ps.RefreshData();
                this.currentFuel = ps.FuelWeightKgs;
                
                // this.txtPlayerLocation.Text = this.playerLat.Value.DecimalDegrees.ToString();
            }
            catch (Exception ex)
            {
                // An error occured. Tell the user and stop this timer.
                this.timerMain.Stop();
                MessageBox.Show("Communication with FSUIPC Failed\n\n" + ex.Message, "FSUIPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Update the connection status
                configureForm();
            }
        }


        // Configures the button and status label depending on if we're connected or not 
        private void configureForm()
        {
            if (FSUIPCConnection.IsOpen)
            {
                this.btnToggleConnection.Text = "Disconnect";
                this.lblConnectionStatus.Text = "Connected to " + FSUIPCConnection.FlightSimVersionConnected.ToString();
                this.lblConnectionStatus.ForeColor = Color.Green;
                this.btnFlight.Enabled = true;
                if (this.savedCode != null && this.savedCode != "")
                {
                    var client = new RestClient("https://realva-backend.herokuapp.com");
                    var request = new RestRequest("flight/read/" + this.savedCode, Method.GET);
                    var queryResult = client.Execute<Booking>(request).Data;
                    this.txtDeparture.Text = queryResult.dep;
                    this.txtArrival.Text = queryResult.arr;
                }else if (this.txtSecretCode.Text != null && this.txtSecretCode.Text != "")
                {
                    var client = new RestClient("https://realva-backend.herokuapp.com");
                    var request = new RestRequest("flight/read/" + this.txtSecretCode.Text, Method.GET);
                    var queryResult = client.Execute<Booking>(request).Data;
                    this.txtDeparture.Text = queryResult.dep;
                    this.txtArrival.Text = queryResult.arr;
                }
            }
            else
            {
                this.btnToggleConnection.Text = "Connect";
                this.lblConnectionStatus.Text = "Disconnected";
                this.lblConnectionStatus.ForeColor = Color.Red;
                this.btnFlight.Enabled = false;
            }
        }

        private void configureStartFlight()
        {
            if (this.flightStarted)
            {
                this.btnFlight.Text = "Stop flight";
                this.txtAircraft.Enabled = false;
                this.txtSecretCode.Enabled = false;
                File.WriteAllText("settings.txt", this.txtSecretCode.Text);
                this.lblFlightStatus.Text = "Flight started";
                this.lblFlightStatus.ForeColor = Color.Green;
            }
            else
            {
                this.btnFlight.Text = "Start flight";
                this.txtAircraft.Enabled = true;
                this.txtSecretCode.Enabled = true;
                this.lblFlightStatus.Text = "Flight not started";
                this.lblFlightStatus.ForeColor = Color.Red;
            }
        }

        // Form is closing so stop the timer and close FSUIPC Connection
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timerMain.Stop();
            FSUIPCConnection.Close();
        }

        private void btnFlight_Click(object sender, EventArgs e)
        {

            this.flightStarted = !this.flightStarted;

            if(this.flightStarted)
            {
                if (txtDeparture.Text == null || txtDeparture.Text == ""
                    || txtArrival.Text == null || txtArrival.Text == ""
                    || txtAircraft.Text == null || txtAircraft.Text == ""
                    || txtSecretCode.Text == null || txtSecretCode.Text == "")
                {
                    this.flightStarted = false;
                    MessageBox.Show("Please enter all the data");
                }
                else
                {
                    this.depLat = this.playerLat.Value.DecimalDegrees;
                    this.depLon = this.playerLon.Value.DecimalDegrees;
                    this.startTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                    this.startFuel = Math.Round(this.currentFuel, 2);
                    this.btnToggleConnection.Enabled = false;
                    this.departure = txtDeparture.Text;
                    this.arrival = txtArrival.Text;
                    this.txtDeparture.Enabled = false;
                    this.txtArrival.Enabled = false;
                }
            }
            else
            {
                this.arrLat = this.playerLat.Value.DecimalDegrees;
                this.arrLon = this.playerLon.Value.DecimalDegrees;
                this.endTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                this.endFuel = Math.Round(this.currentFuel, 2);
                this.btnToggleConnection.Enabled = true;
                this.txtDeparture.Enabled = true;
                this.txtArrival.Enabled = true;

                string createText = this.depLat + Environment.NewLine + this.depLon + Environment.NewLine + this.startTime + Environment.NewLine + this.arrLat + Environment.NewLine + this.arrLon + Environment.NewLine + this.endTime + Environment.NewLine;

                var request = new RestRequest(Method.POST);
                var client = new RestClient("https://realva-backend.herokuapp.com");
                request.Resource = "/flight/submit";
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("userSecretCode", txtSecretCode.Text);

                request.AddJsonBody(
                    new { 
                        depLat,
                        depLon,
                        arrLat,
                        arrLon,
                        startTime,
                        endTime,
                        aircraft = txtAircraft.Text,
                        startFuel,
                        endFuel,
                        departure,
                        arrival,
                        landingRate
                });

                client.Execute(request);

                MessageBox.Show("Flight uploaded to server, you can start new flight");
            }

            configureStartFlight();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtSecretCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFlightStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
