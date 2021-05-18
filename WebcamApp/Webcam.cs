using AForge.Video;
using AForge.Video.DirectShow;

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace WebcamApp
{
	// https://stackoverflow.com/questions/7595191
	// http://www.aforgenet.com/framework/docs/html/4d8626b4-f14b-0b13-588d-c223bec6eb32.htm
	// https://github.com/nager/Nager.VideoStream

	public partial class Webcam : Form
	{
		private FilterInfoCollection VideoCaptureDevices;
		private FilterInfoCollection AudioCaptureDevices;
		private VideoCaptureDevice SelectedVideoDevice;
		private VideoCaptureDevice SelectedAudioDevice;
		private int SelectedVideoDeviceIndex = 0;
		private int SelectedAudioDeviceIndex = 0;
		private bool TakeScreenshot = false;

		public Webcam()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			LoadVideoDevices();
			LoadAudioDevices();
			LoadViewModes();
			StartVideoDevice();
			////StartAudioDevice();
			//StartIpCamera();
		}

		private void Webcam_FormClosed(object sender, FormClosedEventArgs e)
		{
			StopVideoDevice();
			StopAudioDevice();
		}

		private void LoadVideoDevices()
		{
			VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			cmbVideoDevice.Items.Clear();
			foreach (FilterInfo VidCapDev in VideoCaptureDevices)
			{
				cmbVideoDevice.Items.Add(VidCapDev.Name);
				cmbVideoDevice.SelectedIndex = 0;
			}
		}

		private void LoadAudioDevices()
		{
			AudioCaptureDevices = new FilterInfoCollection(FilterCategory.AudioInputDevice);
			cmbAudioDevice.Items.Clear();
			foreach (FilterInfo AudCapDev in AudioCaptureDevices)
			{
				cmbAudioDevice.Items.Add(AudCapDev.Name);
				cmbAudioDevice.SelectedIndex = 0;
			}
		}

		private void LoadViewModes()
		{
			cmbViewMode.Items.Clear();
			foreach (string mode in Enum.GetNames(typeof(PictureBoxSizeMode)))
			{
				//if (mode != "AutoSize")
				cmbViewMode.Items.Add(mode.ToString());
			}
			cmbViewMode.SelectedIndex = (int)PictureBoxSizeMode.Zoom;
			pbViewer.SizeMode = (PictureBoxSizeMode)cmbViewMode.SelectedIndex;
		}

		private void StartVideoDevice()
		{
			try
			{
				StopVideoDevice();
				SelectedVideoDevice = new VideoCaptureDevice(VideoCaptureDevices[SelectedVideoDeviceIndex].MonikerString);
				SelectedVideoDevice.NewFrame += new NewFrameEventHandler(FinalVideoDevice_NewFrame);
				SelectedVideoDevice.Start();

				//float height = SelectedVideoDevice.VideoCapabilities[0].FrameSize.Height;
				//float width = SelectedVideoDevice.VideoCapabilities[0].FrameSize.Width;
				//float aspectRatio = width / height;
				//Height = Height * (int)aspectRatio
			}
			catch
			{
				MessageBox.Show("No video capture devices found.");
			}
		}

		private void StopVideoDevice()
		{
			if (SelectedVideoDevice != null && SelectedVideoDevice.IsRunning)
				SelectedVideoDevice.SignalToStop();  //SelectedVideoDevice.Stop();
		}

		private void FinalVideoDevice_NewFrame(object sender, NewFrameEventArgs e)
		{
			try
			{
				// Get new frame and display in PictureBox
				pbViewer.Image = (Bitmap)e.Frame.Clone();
				if (TakeScreenshot)
				{
					try
					{
						StopVideoDevice();
						pbViewer.Image.Save("..\\..\\..\\screenshot.png", ImageFormat.Png);
						//pbViewer.Image.Save(string.Format("..\\..\\..\\screenshot_{0}.png", DateTime.Now.ToString("O")),
						//	ImageFormat.Png);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
					finally
					{
						TakeScreenshot = false;
						StartVideoDevice();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void StartAudioDevice()
		{
			try
			{
				StopAudioDevice();
				SelectedAudioDevice = new VideoCaptureDevice(AudioCaptureDevices[SelectedAudioDeviceIndex].MonikerString);
				SelectedAudioDevice.Start();
			}
			catch
			{
				MessageBox.Show("No microphones found.");
			}
		}

		private void StopAudioDevice()
		{
			if (SelectedAudioDevice != null && SelectedAudioDevice.IsRunning)
				SelectedAudioDevice.SignalToStop();
		}

		//private void StartIpCamera()
		//{
		//	var stream = new MJPEGStream("rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov");
		//	stream.NewFrame += new NewFrameEventHandler(FinalVideoDevice_NewFrame);
		//	stream.Start();
		//}

		//private void StopIpCamera()
		//{
		//	if (stream != null && stream.)
		//}

		#region Page Control Events

		private void lnkDeviceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var sb = new StringBuilder("Name: " + cmbVideoDevice.SelectedItem.ToString());
			sb.Append("\nFrames Received: " + SelectedVideoDevice.FramesReceived);
			MessageBox.Show(sb.ToString(), "Device Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void lnkDeviceSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (SelectedVideoDevice != null)
				SelectedVideoDevice.DisplayPropertyPage(this.Handle); // IntPtr.Zero
		}

		private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbVideoDevice.SelectedIndex != SelectedVideoDeviceIndex)
			{
				SelectedVideoDeviceIndex = cmbVideoDevice.SelectedIndex;
				StartVideoDevice();
			}
		}

		private void cmbViewMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			pbViewer.SizeMode = (PictureBoxSizeMode)cmbViewMode.SelectedIndex;
		}

		private void cmbAudioDevice_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbAudioDevice.SelectedIndex != SelectedAudioDeviceIndex)
			{
				SelectedAudioDeviceIndex = cmbAudioDevice.SelectedIndex;
				StartAudioDevice();
			}
		}

		private void lblAudioDeviceSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (SelectedAudioDevice != null)
				SelectedAudioDevice.DisplayPropertyPage(this.Handle); // IntPtr.Zero
		}

		#endregion Page Control Events

		private void pbViewer_Click(object sender, EventArgs e)
		{
			TakeScreenshot = true;
		}
	}
}