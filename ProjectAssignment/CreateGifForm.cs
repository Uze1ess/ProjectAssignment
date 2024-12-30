using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ProjectAssignment
{
    public partial class CreateGifForm : Form
    {
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
    }
}
