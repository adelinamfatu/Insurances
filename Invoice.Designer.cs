
namespace AsigurariDeViataSiBunuri
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.panel = new System.Windows.Forms.Panel();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCIF = new System.Windows.Forms.Label();
            this.lbAde = new System.Windows.Forms.Label();
            this.lbPlata = new System.Windows.Forms.Label();
            this.lbFactura = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.tbClientName);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.tbPayment);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.lbCIF);
            this.panel.Controls.Add(this.lbAde);
            this.panel.Controls.Add(this.lbPlata);
            this.panel.Controls.Add(this.lbFactura);
            this.panel.Controls.Add(this.pbLogo);
            this.panel.Location = new System.Drawing.Point(13, 43);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(775, 476);
            this.panel.TabIndex = 0;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(518, 227);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(244, 22);
            this.tbClientName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client:";
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(632, 138);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.ReadOnly = true;
            this.tbPayment.Size = new System.Drawing.Size(130, 22);
            this.tbPayment.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cota TVA: 19%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "FF0152";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresa: Str. Drajna 3A, Bucuresti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reg. com.: J32/25/2019";
            // 
            // lbCIF
            // 
            this.lbCIF.AutoSize = true;
            this.lbCIF.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCIF.Location = new System.Drawing.Point(3, 347);
            this.lbCIF.Name = "lbCIF";
            this.lbCIF.Size = new System.Drawing.Size(224, 29);
            this.lbCIF.TabIndex = 4;
            this.lbCIF.Text = "CIF: RO123456789";
            // 
            // lbAde
            // 
            this.lbAde.AutoSize = true;
            this.lbAde.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAde.Location = new System.Drawing.Point(3, 308);
            this.lbAde.Name = "lbAde";
            this.lbAde.Size = new System.Drawing.Size(371, 29);
            this.lbAde.TabIndex = 3;
            this.lbAde.Text = "ADELURANCE SYSTEM S.R.L.";
            // 
            // lbPlata
            // 
            this.lbPlata.AutoSize = true;
            this.lbPlata.BackColor = System.Drawing.Color.Transparent;
            this.lbPlata.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlata.Location = new System.Drawing.Point(411, 131);
            this.lbPlata.Name = "lbPlata";
            this.lbPlata.Size = new System.Drawing.Size(183, 29);
            this.lbPlata.TabIndex = 2;
            this.lbPlata.Text = "TOTAL PLATA";
            // 
            // lbFactura
            // 
            this.lbFactura.AutoSize = true;
            this.lbFactura.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactura.Location = new System.Drawing.Point(411, 3);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(193, 57);
            this.lbFactura.TabIndex = 1;
            this.lbFactura.Text = "Factura";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(6, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(374, 302);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbPlata;
        private System.Windows.Forms.Label lbFactura;
        private System.Windows.Forms.Label lbCIF;
        private System.Windows.Forms.Label lbAde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
    }
}