namespace ProjectAssignment
{
    partial class CreateGifForm
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
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.uploadImagebtn = new Guna.UI2.WinForms.Guna2Button();
            this.InputGunaPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputGunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // uploadImagebtn
            // 
            this.uploadImagebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uploadImagebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uploadImagebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uploadImagebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uploadImagebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uploadImagebtn.ForeColor = System.Drawing.Color.White;
            this.uploadImagebtn.Location = new System.Drawing.Point(762, 237);
            this.uploadImagebtn.Name = "uploadImagebtn";
            this.uploadImagebtn.Size = new System.Drawing.Size(142, 38);
            this.uploadImagebtn.TabIndex = 0;
            this.uploadImagebtn.Text = "Tải ảnh lên";
            this.uploadImagebtn.Click += new System.EventHandler(this.uploadImagebtn_Click);
            // 
            // InputGunaPictureBox
            // 
            this.InputGunaPictureBox.ImageRotate = 0F;
            this.InputGunaPictureBox.Location = new System.Drawing.Point(686, 31);
            this.InputGunaPictureBox.Name = "InputGunaPictureBox";
            this.InputGunaPictureBox.Size = new System.Drawing.Size(300, 200);
            this.InputGunaPictureBox.TabIndex = 1;
            this.InputGunaPictureBox.TabStop = false;
            this.InputGunaPictureBox.Click += new System.EventHandler(this.InputGunaPictureBox_Click_1);
            // 
            // CreateGifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 646);
            this.Controls.Add(this.InputGunaPictureBox);
            this.Controls.Add(this.uploadImagebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateGifForm";
            this.Text = "CreateGifForm";
            this.Load += new System.EventHandler(this.CreateGifForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputGunaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private Guna.UI2.WinForms.Guna2Button uploadImagebtn;
        private Guna.UI2.WinForms.Guna2PictureBox InputGunaPictureBox;
    }
}