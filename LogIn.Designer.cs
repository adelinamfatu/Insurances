
namespace AsigurariDeViataSiBunuri
{
    partial class Asigurari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asigurari));
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.rbRomana = new System.Windows.Forms.RadioButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnForgotPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Checked = true;
            this.rbEng.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEng.Location = new System.Drawing.Point(830, 12);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(73, 23);
            this.rbEng.TabIndex = 0;
            this.rbEng.TabStop = true;
            this.rbEng.Text = "English";
            this.rbEng.UseVisualStyleBackColor = true;
            this.rbEng.CheckedChanged += new System.EventHandler(this.rbEng_CheckedChanged);
            // 
            // rbRomana
            // 
            this.rbRomana.AutoSize = true;
            this.rbRomana.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRomana.Location = new System.Drawing.Point(928, 12);
            this.rbRomana.Name = "rbRomana";
            this.rbRomana.Size = new System.Drawing.Size(80, 23);
            this.rbRomana.TabIndex = 1;
            this.rbRomana.Text = "Romana";
            this.rbRomana.UseVisualStyleBackColor = true;
            this.rbRomana.CheckedChanged += new System.EventHandler(this.rbRomana_CheckedChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(25, 70);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(467, 467);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.lbWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbWelcome.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbWelcome.Location = new System.Drawing.Point(577, 70);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(277, 64);
            this.lbWelcome.TabIndex = 3;
            this.lbWelcome.Text = "Welcome!";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(588, 222);
            this.tbUsername.MaxLength = 13;
            this.tbUsername.MinimumSize = new System.Drawing.Size(250, 35);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(280, 36);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_CharPress);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(588, 318);
            this.tbPassword.MaxLength = 35;
            this.tbPassword.MinimumSize = new System.Drawing.Size(250, 35);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(280, 36);
            this.tbPassword.TabIndex = 5;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNewAccount.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.Location = new System.Drawing.Point(588, 504);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(280, 33);
            this.btnNewAccount.TabIndex = 6;
            this.btnNewAccount.Text = "Don\'t have an account yet?";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // pbMail
            // 
            this.pbMail.Image = ((System.Drawing.Image)(resources.GetObject("pbMail.Image")));
            this.pbMail.Location = new System.Drawing.Point(519, 221);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(49, 36);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMail.TabIndex = 7;
            this.pbMail.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(583, 191);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(51, 28);
            this.lbUsername.TabIndex = 9;
            this.lbUsername.Text = "NIN:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(583, 287);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(98, 28);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password:";
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(588, 392);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(280, 31);
            this.btnSignin.TabIndex = 11;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForgotPass.Location = new System.Drawing.Point(588, 448);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(280, 30);
            this.btnForgotPass.TabIndex = 12;
            this.btnForgotPass.Text = "Forgot password?";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // Asigurari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 618);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMail);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.rbRomana);
            this.Controls.Add(this.rbEng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Asigurari";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbRomana;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.PictureBox pbMail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnForgotPass;
    }
}

