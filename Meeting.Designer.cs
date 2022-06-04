
namespace AsigurariDeViataSiBunuri
{
    partial class Meeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meeting));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCommit = new System.Windows.Forms.Button();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.rbRom = new System.Windows.Forms.RadioButton();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(21, 63);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(317, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCommit.Location = new System.Drawing.Point(21, 163);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(317, 31);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Checked = true;
            this.rbEng.Location = new System.Drawing.Point(175, 12);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(75, 21);
            this.rbEng.TabIndex = 2;
            this.rbEng.TabStop = true;
            this.rbEng.Text = "English";
            this.rbEng.UseVisualStyleBackColor = true;
            this.rbEng.CheckedChanged += new System.EventHandler(this.rbEng_CheckedChanged);
            // 
            // rbRom
            // 
            this.rbRom.AutoSize = true;
            this.rbRom.Location = new System.Drawing.Point(256, 12);
            this.rbRom.Name = "rbRom";
            this.rbRom.Size = new System.Drawing.Size(82, 21);
            this.rbRom.TabIndex = 3;
            this.rbRom.Text = "Romana";
            this.rbRom.UseVisualStyleBackColor = true;
            this.rbRom.CheckedChanged += new System.EventHandler(this.rbRom_CheckedChanged);
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cbHour.Location = new System.Drawing.Point(21, 110);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(149, 24);
            this.cbHour.TabIndex = 4;
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cbMinute.Location = new System.Drawing.Point(199, 108);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(139, 24);
            this.cbMinute.TabIndex = 5;
            // 
            // Meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(362, 242);
            this.ControlBox = false;
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.rbRom);
            this.Controls.Add(this.rbEng);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Meeting";
            this.Text = "Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbRom;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinute;
    }
}