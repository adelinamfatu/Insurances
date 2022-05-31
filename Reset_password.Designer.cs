
namespace AsigurariDeViataSiBunuri
{
    partial class Reset_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_password));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbReset = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPasswd = new System.Windows.Forms.Label();
            this.tbConfirmPasswd = new System.Windows.Forms.TextBox();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.rbRom = new System.Windows.Forms.RadioButton();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 351);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbReset
            // 
            this.lbReset.AutoSize = true;
            this.lbReset.BackColor = System.Drawing.SystemColors.Control;
            this.lbReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbReset.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbReset.Location = new System.Drawing.Point(428, 48);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(357, 39);
            this.lbReset.TabIndex = 4;
            this.lbReset.Text = "Reset your password!";
            this.lbReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(430, 93);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 28);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(435, 124);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.MinimumSize = new System.Drawing.Size(250, 35);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(350, 36);
            this.tbEmail.TabIndex = 10;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(430, 172);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(58, 28);
            this.lbCode.TabIndex = 13;
            this.lbCode.Text = "Code";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(435, 203);
            this.tbCode.MaxLength = 4;
            this.tbCode.MinimumSize = new System.Drawing.Size(250, 35);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(350, 36);
            this.tbCode.TabIndex = 12;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(430, 254);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(139, 28);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "New password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(435, 285);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.MinimumSize = new System.Drawing.Size(250, 35);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(350, 36);
            this.tbPassword.TabIndex = 14;
            // 
            // lbConfirmPasswd
            // 
            this.lbConfirmPasswd.AutoSize = true;
            this.lbConfirmPasswd.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPasswd.Location = new System.Drawing.Point(430, 332);
            this.lbConfirmPasswd.Name = "lbConfirmPasswd";
            this.lbConfirmPasswd.Size = new System.Drawing.Size(210, 28);
            this.lbConfirmPasswd.TabIndex = 17;
            this.lbConfirmPasswd.Text = "Confirm new password";
            // 
            // tbConfirmPasswd
            // 
            this.tbConfirmPasswd.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPasswd.Location = new System.Drawing.Point(435, 363);
            this.tbConfirmPasswd.MaxLength = 30;
            this.tbConfirmPasswd.MinimumSize = new System.Drawing.Size(250, 35);
            this.tbConfirmPasswd.Name = "tbConfirmPasswd";
            this.tbConfirmPasswd.PasswordChar = '*';
            this.tbConfirmPasswd.Size = new System.Drawing.Size(350, 36);
            this.tbConfirmPasswd.TabIndex = 16;
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Checked = true;
            this.rbEng.Location = new System.Drawing.Point(817, 12);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(75, 21);
            this.rbEng.TabIndex = 18;
            this.rbEng.TabStop = true;
            this.rbEng.Text = "English";
            this.rbEng.UseVisualStyleBackColor = true;
            this.rbEng.CheckedChanged += new System.EventHandler(this.rbEng_CheckedChanged);
            // 
            // rbRom
            // 
            this.rbRom.AutoSize = true;
            this.rbRom.Location = new System.Drawing.Point(817, 48);
            this.rbRom.Name = "rbRom";
            this.rbRom.Size = new System.Drawing.Size(82, 21);
            this.rbRom.TabIndex = 19;
            this.rbRom.Text = "Romana";
            this.rbRom.UseVisualStyleBackColor = true;
            this.rbRom.CheckedChanged += new System.EventHandler(this.rbRom_CheckedChanged);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(817, 124);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(102, 36);
            this.btnSendMail.TabIndex = 20;
            this.btnSendMail.Text = "Send email";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(817, 356);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(102, 43);
            this.btnChange.TabIndex = 21;
            this.btnChange.Text = "Change password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 434);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.rbRom);
            this.Controls.Add(this.rbEng);
            this.Controls.Add(this.lbConfirmPasswd);
            this.Controls.Add(this.tbConfirmPasswd);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbReset);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reset_password";
            this.Text = "Reset password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbReset;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbConfirmPasswd;
        private System.Windows.Forms.TextBox tbConfirmPasswd;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbRom;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}