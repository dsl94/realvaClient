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
            this.statusStrip.Location = new System.Drawing.Point(0, 167);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(329, 22);
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
            this.btnFlight.Location = new System.Drawing.Point(12, 108);
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
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Secret code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecretCode
            // 
            this.txtSecretCode.Location = new System.Drawing.Point(89, 63);
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
            this.lblFlightStatus.Location = new System.Drawing.Point(162, 112);
            this.lblFlightStatus.Name = "lblFlightStatus";
            this.lblFlightStatus.Size = new System.Drawing.Size(160, 24);
            this.lblFlightStatus.TabIndex = 7;
            this.lblFlightStatus.Text = "Flight not started";
            this.lblFlightStatus.Click += new System.EventHandler(this.lblFlightStatus_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 189);
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
    }
}

