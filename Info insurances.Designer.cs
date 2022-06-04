
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
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.clYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvInsurances
            // 
            this.lvInsurances.BackColor = System.Drawing.Color.SeaShell;
            this.lvInsurances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.clPeriod,
            this.clPrice,
            this.clMonthPrice});
            this.lvInsurances.GridLines = true;
            this.lvInsurances.HideSelection = false;
            this.lvInsurances.Location = new System.Drawing.Point(0, -1);
            this.lvInsurances.Name = "lvInsurances";
            this.lvInsurances.Size = new System.Drawing.Size(964, 451);
            this.lvInsurances.TabIndex = 0;
            this.lvInsurances.UseCompatibleStateImageBehavior = false;
            this.lvInsurances.View = System.Windows.Forms.View.Details;
            this.lvInsurances.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvInsurances_ColumnWidthChanging);
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 210;
            // 
            // clPeriod
            // 
            this.clPeriod.Text = "Period";
            this.clPeriod.Width = 179;
            // 
            // clPrice
            // 
            this.clPrice.Text = "Full price";
            this.clPrice.Width = 212;
            // 
            // clMonthPrice
            // 
            this.clMonthPrice.Text = "Price per month";
            this.clMonthPrice.Width = 170;
            // 
            // lvSchedule
            // 
            this.lvSchedule.BackColor = System.Drawing.Color.Azure;
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clYear,
            this.clMonth,
            this.clDay,
            this.clHour,
            this.clMinute});
            this.lvSchedule.GridLines = true;
            this.lvSchedule.HideSelection = false;
            this.lvSchedule.Location = new System.Drawing.Point(0, -1);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(964, 451);
            this.lvSchedule.TabIndex = 1;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            this.lvSchedule.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // clYear
            // 
            this.clYear.Text = "Year / An";
            this.clYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clYear.Width = 124;
            // 
            // clMonth
            // 
            this.clMonth.Text = "Month / luna";
            this.clMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clMonth.Width = 151;
            // 
            // clDay
            // 
            this.clDay.Text = "Day / ziua";
            this.clDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDay.Width = 162;
            // 
            // clHour
            // 
            this.clHour.Text = "Hour / ora";
            this.clHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clHour.Width = 159;
            // 
            // clMinute
            // 
            this.clMinute.Text = "Minute / minut";
            this.clMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clMinute.Width = 176;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.lvSchedule);
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
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader clMonth;
        private System.Windows.Forms.ColumnHeader clYear;
        private System.Windows.Forms.ColumnHeader clDay;
        private System.Windows.Forms.ColumnHeader clHour;
        private System.Windows.Forms.ColumnHeader clMinute;
    }
}