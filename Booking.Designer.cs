
namespace AsigurariDeViataSiBunuri
{
    partial class Booking
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
            this.programMeeting = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printPreviewPersonalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // programMeeting
            // 
            this.programMeeting.Location = new System.Drawing.Point(272, 100);
            this.programMeeting.Name = "programMeeting";
            this.programMeeting.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewPersonalInformationToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(308, 56);
            // 
            // printPreviewPersonalInformationToolStripMenuItem
            // 
            this.printPreviewPersonalInformationToolStripMenuItem.Name = "printPreviewPersonalInformationToolStripMenuItem";
            this.printPreviewPersonalInformationToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.printPreviewPersonalInformationToolStripMenuItem.Text = "Print preview personal information";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programMeeting);
            this.Name = "Booking";
            this.Text = "Booking meeting";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar programMeeting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem printPreviewPersonalInformationToolStripMenuItem;
    }
}