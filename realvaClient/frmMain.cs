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
        private Offset<uint> avionicsMaster = new Offset<uint>(0x2E80);

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

        public frmMain()
        {
            InitializeComponent();
            configureForm();
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


                // Update the information on the form
                // (See the Examples Application for more information on using Offsets).

      
              

                FsLatLonPoint playerPos = new FsLatLonPoint(this.playerLat.Value, this.playerLon.Value);

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
            }
            else
            {
                this.btnFlight.Text = "Start flight";
                this.txtAircraft.Enabled = true;
                this.txtSecretCode.Enabled = true;
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
                this.depLat = this.playerLat.Value.DecimalDegrees;
                this.depLon = this.playerLon.Value.DecimalDegrees;
                this.startTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                this.arrLat = this.playerLat.Value.DecimalDegrees;
                this.arrLon = this.playerLon.Value.DecimalDegrees;
                this.endTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

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
                        aircraft = txtAircraft.Text
                });

                client.Execute(request);

                MessageBox.Show("Flight uploaded to server, you can start new flight / Let stavljen na sajt, mozete pokrenuti novi");
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
    }
}
