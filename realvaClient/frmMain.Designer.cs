namespace realvaClient
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnToggleConnection = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.txtAircraft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFlight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecretCode = new System.Windows.Forms.TextBox();
            this.lblFlightStatus = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.testLbl = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblPax = new System.Windows.Forms.Label();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.lblSpc = new System.Windows.Forms.Label();
            this.txtSpc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleConnection
            // 
            this.btnToggleConnection.Location = new System.Drawing.Point(12, 12);
            this.btnToggleConnection.Name = "btnToggleConnection";
            this.btnToggleConnection.Size = new System.Drawing.Size(134, 36);
            this.btnToggleConnection.TabIndex = 0;
            this.btnToggleConnection.Text = "Connect/Disconnect";
            this.btnToggleConnection.UseVisualStyleBackColor = true;
            this.btnToggleConnection.Click += new System.EventHandler(this.btnToggleConnection_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnectionStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 294);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(333, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(104, 17);
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // txtAircraft
            // 
            this.txtAircraft.Location = new System.Drawing.Point(234, 21);
            this.txtAircraft.Name = "txtAircraft";
            this.txtAircraft.ReadOnly = true;
            this.txtAircraft.Size = new System.Drawing.Size(88, 20);
            this.txtAircraft.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aircraft";
            // 
            // btnFlight
            // 
            this.btnFlight.Location = new System.Drawing.Point(11, 242);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(134, 37);
            this.btnFlight.TabIndex = 4;
            this.btnFlight.Text = "Start/End flight";
            this.btnFlight.UseVisualStyleBackColor = true;
            this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Secret code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecretCode
            // 
            this.txtSecretCode.Location = new System.Drawing.Point(88, 118);
            this.txtSecretCode.Name = "txtSecretCode";
            this.txtSecretCode.Size = new System.Drawing.Size(233, 20);
            this.txtSecretCode.TabIndex = 5;
            this.txtSecretCode.TextChanged += new System.EventHandler(this.txtSecretCode_TextChanged);
            // 
            // lblFlightStatus
            // 
            this.lblFlightStatus.AutoSize = true;
            this.lblFlightStatus.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFlightStatus.Location = new System.Drawing.Point(161, 246);
            this.lblFlightStatus.Name = "lblFlightStatus";
            this.lblFlightStatus.Size = new System.Drawing.Size(160, 24);
            this.lblFlightStatus.TabIndex = 7;
            this.lblFlightStatus.Text = "Flight not started";
            this.lblFlightStatus.Click += new System.EventHandler(this.lblFlightStatus_Click);
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(85, 153);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.ReadOnly = true;
            this.txtDeparture.Size = new System.Drawing.Size(80, 20);
            this.txtDeparture.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arrival";
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(241, 153);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.ReadOnly = true;
            this.txtArrival.Size = new System.Drawing.Size(80, 20);
            this.txtArrival.TabIndex = 10;
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testLbl.Location = new System.Drawing.Point(46, 224);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(0, 24);
            this.testLbl.TabIndex = 12;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(191, 182);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 16;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(241, 179);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(80, 20);
            this.txtCargo.TabIndex = 15;
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Location = new System.Drawing.Point(17, 182);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(62, 13);
            this.lblPax.TabIndex = 14;
            this.lblPax.Text = "Passengers";
            // 
            // txtPax
            // 
            this.txtPax.Location = new System.Drawing.Point(85, 179);
            this.txtPax.Name = "txtPax";
            this.txtPax.ReadOnly = true;
            this.txtPax.Size = new System.Drawing.Size(80, 20);
            this.txtPax.TabIndex = 13;
            // 
            // lblSpc
            // 
            this.lblSpc.AutoSize = true;
            this.lblSpc.Location = new System.Drawing.Point(81, 208);
            this.lblSpc.Name = "lblSpc";
            this.lblSpc.Size = new System.Drawing.Size(72, 13);
            this.lblSpc.TabIndex = 18;
            this.lblSpc.Text = "Special cargo";
            // 
            // txtSpc
            // 
            this.txtSpc.Location = new System.Drawing.Point(159, 205);
            this.txtSpc.Name = "txtSpc";
            this.txtSpc.ReadOnly = true;
            this.txtSpc.Size = new System.Drawing.Size(162, 20);
            this.txtSpc.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Flight number:";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("DA FMS Font", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lblFlightNumber.Location = new System.Drawing.Point(160, 74);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(139, 30);
            this.lblFlightNumber.TabIndex = 20;
            this.lblFlightNumber.Text = "INT123";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 316);
            this.Controls.Add(this.lblFlightNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSpc);
            this.Controls.Add(this.txtSpc);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.testLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.lblFlightStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecretCode);
            this.Controls.Add(this.btnFlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAircraft);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnToggleConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Realva client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggleConnection;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionStatus;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.TextBox txtAircraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecretCode;
        private System.Windows.Forms.Label lblFlightStatus;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Label lblSpc;
        private System.Windows.Forms.TextBox txtSpc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFlightNumber;
    }
}

