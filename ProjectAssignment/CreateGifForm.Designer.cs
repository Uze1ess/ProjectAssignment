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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ChangeColorgunaCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ScalegunaCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputGunaPictureBox)).BeginInit();
            this.guna2Panel1.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 40;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.ScalegunaCheckBox);
            this.guna2Panel1.Controls.Add(this.ChangeColorgunaCheckBox);
            this.guna2Panel1.Location = new System.Drawing.Point(48, 14);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(413, 247);
            this.guna2Panel1.TabIndex = 2;
            // 
            // ChangeColorgunaCheckBox
            // 
            this.ChangeColorgunaCheckBox.AutoSize = true;
            this.ChangeColorgunaCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChangeColorgunaCheckBox.CheckedState.BorderRadius = 0;
            this.ChangeColorgunaCheckBox.CheckedState.BorderThickness = 0;
            this.ChangeColorgunaCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChangeColorgunaCheckBox.Location = new System.Drawing.Point(141, 54);
            this.ChangeColorgunaCheckBox.Name = "ChangeColorgunaCheckBox";
            this.ChangeColorgunaCheckBox.Size = new System.Drawing.Size(78, 20);
            this.ChangeColorgunaCheckBox.TabIndex = 4;
            this.ChangeColorgunaCheckBox.Text = "Đổi màu";
            this.ChangeColorgunaCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChangeColorgunaCheckBox.UncheckedState.BorderRadius = 0;
            this.ChangeColorgunaCheckBox.UncheckedState.BorderThickness = 0;
            this.ChangeColorgunaCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ScalegunaCheckBox
            // 
            this.ScalegunaCheckBox.AutoSize = true;
            this.ScalegunaCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScalegunaCheckBox.CheckedState.BorderRadius = 0;
            this.ScalegunaCheckBox.CheckedState.BorderThickness = 0;
            this.ScalegunaCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScalegunaCheckBox.Location = new System.Drawing.Point(141, 97);
            this.ScalegunaCheckBox.Name = "ScalegunaCheckBox";
            this.ScalegunaCheckBox.Size = new System.Drawing.Size(89, 20);
            this.ScalegunaCheckBox.TabIndex = 5;
            this.ScalegunaCheckBox.Text = "Scale ảnh";
            this.ScalegunaCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ScalegunaCheckBox.UncheckedState.BorderRadius = 0;
            this.ScalegunaCheckBox.UncheckedState.BorderThickness = 0;
            this.ScalegunaCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(120, 166);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(154, 26);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // CreateGifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 646);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.InputGunaPictureBox);
            this.Controls.Add(this.uploadImagebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateGifForm";
            this.Text = "CreateGifForm";
            this.Load += new System.EventHandler(this.CreateGifForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputGunaPictureBox)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private Guna.UI2.WinForms.Guna2Button uploadImagebtn;
        private Guna.UI2.WinForms.Guna2PictureBox InputGunaPictureBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox ScalegunaCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox ChangeColorgunaCheckBox;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}