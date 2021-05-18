
namespace WebcamApp
{
	partial class Webcam
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Webcam));
			this.pbViewer = new System.Windows.Forms.PictureBox();
			this.cmbVideoDevice = new System.Windows.Forms.ComboBox();
			this.lblVideoDevice = new System.Windows.Forms.Label();
			this.lnkVideoDeviceInfo = new System.Windows.Forms.LinkLabel();
			this.lnkVideoDeviceSettings = new System.Windows.Forms.LinkLabel();
			this.lblViwMode = new System.Windows.Forms.Label();
			this.cmbViewMode = new System.Windows.Forms.ComboBox();
			this.lblAudioDevice = new System.Windows.Forms.Label();
			this.cmbAudioDevice = new System.Windows.Forms.ComboBox();
			this.lblAudioDeviceSettings = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pbViewer)).BeginInit();
			this.SuspendLayout();
			// 
			// pbViewer
			// 
			this.pbViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbViewer.BackColor = System.Drawing.Color.Black;
			this.pbViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbViewer.Location = new System.Drawing.Point(10, 10);
			this.pbViewer.Margin = new System.Windows.Forms.Padding(0);
			this.pbViewer.Name = "pbViewer";
			this.pbViewer.Size = new System.Drawing.Size(800, 450);
			this.pbViewer.TabIndex = 0;
			this.pbViewer.TabStop = false;
			this.pbViewer.Click += new System.EventHandler(this.pbViewer_Click);
			// 
			// cmbVideoDevice
			// 
			this.cmbVideoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbVideoDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVideoDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbVideoDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbVideoDevice.FormattingEnabled = true;
			this.cmbVideoDevice.Location = new System.Drawing.Point(10, 488);
			this.cmbVideoDevice.Name = "cmbVideoDevice";
			this.cmbVideoDevice.Size = new System.Drawing.Size(292, 28);
			this.cmbVideoDevice.TabIndex = 1;
			this.cmbVideoDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
			// 
			// lblVideoDevice
			// 
			this.lblVideoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblVideoDevice.AutoSize = true;
			this.lblVideoDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVideoDevice.Location = new System.Drawing.Point(10, 466);
			this.lblVideoDevice.Margin = new System.Windows.Forms.Padding(0);
			this.lblVideoDevice.Name = "lblVideoDevice";
			this.lblVideoDevice.Size = new System.Drawing.Size(100, 20);
			this.lblVideoDevice.TabIndex = 2;
			this.lblVideoDevice.Text = "Video Device:";
			// 
			// lnkVideoDeviceInfo
			// 
			this.lnkVideoDeviceInfo.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
			this.lnkVideoDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lnkVideoDeviceInfo.AutoSize = true;
			this.lnkVideoDeviceInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkVideoDeviceInfo.LinkColor = System.Drawing.Color.RoyalBlue;
			this.lnkVideoDeviceInfo.Location = new System.Drawing.Point(138, 466);
			this.lnkVideoDeviceInfo.Name = "lnkVideoDeviceInfo";
			this.lnkVideoDeviceInfo.Size = new System.Drawing.Size(44, 20);
			this.lnkVideoDeviceInfo.TabIndex = 3;
			this.lnkVideoDeviceInfo.TabStop = true;
			this.lnkVideoDeviceInfo.Text = "Info...";
			this.lnkVideoDeviceInfo.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
			this.lnkVideoDeviceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeviceInfo_LinkClicked);
			// 
			// lnkVideoDeviceSettings
			// 
			this.lnkVideoDeviceSettings.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
			this.lnkVideoDeviceSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lnkVideoDeviceSettings.AutoSize = true;
			this.lnkVideoDeviceSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkVideoDeviceSettings.LinkColor = System.Drawing.Color.RoyalBlue;
			this.lnkVideoDeviceSettings.Location = new System.Drawing.Point(188, 466);
			this.lnkVideoDeviceSettings.Name = "lnkVideoDeviceSettings";
			this.lnkVideoDeviceSettings.Size = new System.Drawing.Size(71, 20);
			this.lnkVideoDeviceSettings.TabIndex = 4;
			this.lnkVideoDeviceSettings.TabStop = true;
			this.lnkVideoDeviceSettings.Text = "Settings...";
			this.lnkVideoDeviceSettings.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
			this.lnkVideoDeviceSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeviceSettings_LinkClicked);
			// 
			// lblViwMode
			// 
			this.lblViwMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblViwMode.AutoSize = true;
			this.lblViwMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblViwMode.Location = new System.Drawing.Point(640, 466);
			this.lblViwMode.Margin = new System.Windows.Forms.Padding(0);
			this.lblViwMode.Name = "lblViwMode";
			this.lblViwMode.Size = new System.Drawing.Size(87, 20);
			this.lblViwMode.TabIndex = 5;
			this.lblViwMode.Text = "View Mode:";
			// 
			// cmbViewMode
			// 
			this.cmbViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbViewMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbViewMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbViewMode.FormattingEnabled = true;
			this.cmbViewMode.Location = new System.Drawing.Point(639, 488);
			this.cmbViewMode.Name = "cmbViewMode";
			this.cmbViewMode.Size = new System.Drawing.Size(120, 28);
			this.cmbViewMode.TabIndex = 6;
			this.cmbViewMode.SelectedIndexChanged += new System.EventHandler(this.cmbViewMode_SelectedIndexChanged);
			// 
			// lblAudioDevice
			// 
			this.lblAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAudioDevice.AutoSize = true;
			this.lblAudioDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAudioDevice.Location = new System.Drawing.Point(323, 466);
			this.lblAudioDevice.Margin = new System.Windows.Forms.Padding(0);
			this.lblAudioDevice.Name = "lblAudioDevice";
			this.lblAudioDevice.Size = new System.Drawing.Size(101, 20);
			this.lblAudioDevice.TabIndex = 7;
			this.lblAudioDevice.Text = "Audio Device:";
			// 
			// cmbAudioDevice
			// 
			this.cmbAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAudioDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbAudioDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAudioDevice.FormattingEnabled = true;
			this.cmbAudioDevice.Location = new System.Drawing.Point(323, 489);
			this.cmbAudioDevice.Name = "cmbAudioDevice";
			this.cmbAudioDevice.Size = new System.Drawing.Size(292, 28);
			this.cmbAudioDevice.TabIndex = 8;
			this.cmbAudioDevice.SelectedIndexChanged += new System.EventHandler(this.cmbAudioDevice_SelectedIndexChanged);
			// 
			// lblAudioDeviceSettings
			// 
			this.lblAudioDeviceSettings.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
			this.lblAudioDeviceSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAudioDeviceSettings.AutoSize = true;
			this.lblAudioDeviceSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAudioDeviceSettings.LinkColor = System.Drawing.Color.RoyalBlue;
			this.lblAudioDeviceSettings.Location = new System.Drawing.Point(435, 466);
			this.lblAudioDeviceSettings.Name = "lblAudioDeviceSettings";
			this.lblAudioDeviceSettings.Size = new System.Drawing.Size(71, 20);
			this.lblAudioDeviceSettings.TabIndex = 9;
			this.lblAudioDeviceSettings.TabStop = true;
			this.lblAudioDeviceSettings.Text = "Settings...";
			this.lblAudioDeviceSettings.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
			this.lblAudioDeviceSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAudioDeviceSettings_LinkClicked);
			// 
			// Webcam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 533);
			this.Controls.Add(this.lblAudioDeviceSettings);
			this.Controls.Add(this.cmbAudioDevice);
			this.Controls.Add(this.lblAudioDevice);
			this.Controls.Add(this.cmbViewMode);
			this.Controls.Add(this.lblViwMode);
			this.Controls.Add(this.lnkVideoDeviceSettings);
			this.Controls.Add(this.lnkVideoDeviceInfo);
			this.Controls.Add(this.lblVideoDevice);
			this.Controls.Add(this.cmbVideoDevice);
			this.Controls.Add(this.pbViewer);
			this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Webcam";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Webcam";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Webcam_FormClosed);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbViewer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbViewer;
		private System.Windows.Forms.ComboBox cmbVideoDevice;
		private System.Windows.Forms.Label lblVideoDevice;
		private System.Windows.Forms.LinkLabel lnkVideoDeviceInfo;
		private System.Windows.Forms.LinkLabel lnkVideoDeviceSettings;
		private System.Windows.Forms.Label lblViwMode;
		private System.Windows.Forms.ComboBox cmbViewMode;
		private System.Windows.Forms.Label lblAudioDevice;
		private System.Windows.Forms.ComboBox cmbAudioDevice;
		private System.Windows.Forms.LinkLabel lblAudioDeviceSettings;
	}
}

