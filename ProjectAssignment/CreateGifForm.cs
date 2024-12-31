using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;
using System.Diagnostics;
using Guna.UI2.WinForms.Suite;
using System.Net;

namespace ProjectAssignment
{
    public partial class CreateGifForm : Form
    {
        private int trackbarstartPoint = 0; 
        private int trackbarendPoint = 10;
        private string videoPath = "";
        public CreateGifForm()
        {
            InitializeComponent();
        }

        private void CreateGifForm_Load(object sender, EventArgs e)
        {

        }

        private void uploadImagebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    // Kiểm tra xem file có phải là ảnh không
                    try
                    {
                        // Thử mở file để xác nhận
                        using (var img = Image.FromFile(filePath))
                        {
                            if (img != null)
                            {
                                InputGunaPictureBox.Image = (Image)img.Clone();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đây không phải là một file ảnh hợp lệ: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một file ảnh.");
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InputGunaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void InputGunaPictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void InputGunaVideoBox_Click(object sender, EventArgs e)
        {

        }
        private void uploadVideobtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Video Files|*.mp4;*.avi;*.mkv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    try
                    {
                        string videoPath = ofd.FileName;
                        axWindowsMediaPlayer1.URL = videoPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đây không phải là một file ảnh hợp lệ: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một file ảnh.");
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void VideogunaTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (VideogunaTrackBar.Value < trackbarstartPoint)
            {
                trackbarstartPoint = VideogunaTrackBar.Value;
            }
            else
            {
                trackbarendPoint = VideogunaTrackBar.Value;
            }
        }

        private void CutVideogunabtn_Click(object sender, EventArgs e)
        {
            CutVideo(videoPath, trackbarstartPoint, trackbarendPoint, "output.mp4");
            MessageBox.Show($"Cắt video từ giây {trackbarstartPoint} đến {trackbarendPoint}");
        }

        private void CutVideo(string inputPath, int start, int end, string outputPath)
        {
            string startTime = TimeSpan.FromSeconds(start).ToString(@"hh\:mm\:ss");
            string endTime = TimeSpan.FromSeconds(end).ToString(@"hh\:mm\:ss");

            string arguments = $"-i \"{inputPath}\" -ss {startTime} -to {endTime} -c copy \"{outputPath}\"";
            System.Diagnostics.Process.Start("ffmpeg", arguments);
        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
