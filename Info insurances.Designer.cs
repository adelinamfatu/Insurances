
namespace AsigurariDeViataSiBunuri
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lvInsurances = new System.Windows.Forms.ListView();
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMonthPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvInsurances
            // 
            this.lvInsurances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.clPeriod,
            this.clPrice,
            this.clMonthPrice});
            this.lvInsurances.GridLines = true;
            this.lvInsurances.HideSelection = false;
            this.lvInsurances.Location = new System.Drawing.Point(12, 12);
            this.lvInsurances.Name = "lvInsurances";
            this.lvInsurances.Size = new System.Drawing.Size(776, 426);
            this.lvInsurances.TabIndex = 0;
            this.lvInsurances.UseCompatibleStateImageBehavior = false;
            this.lvInsurances.View = System.Windows.Forms.View.Details;
            // 
            // colType
            // 
            this.colType.DisplayIndex = 3;
            this.colType.Text = "Type";
            this.colType.Width = 264;
            // 
            // clPeriod
            // 
            this.clPeriod.DisplayIndex = 0;
            this.clPeriod.Text = "Period";
            this.clPeriod.Width = 157;
            // 
            // clPrice
            // 
            this.clPrice.DisplayIndex = 1;
            this.clPrice.Text = "Full price";
            this.clPrice.Width = 169;
            // 
            // clMonthPrice
            // 
            this.clMonthPrice.DisplayIndex = 2;
            this.clMonthPrice.Text = "Price per month";
            this.clMonthPrice.Width = 170;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvInsurances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInsurances;
        private System.Windows.Forms.ColumnHeader clPeriod;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clMonthPrice;
        private System.Windows.Forms.ColumnHeader colType;
    }
}