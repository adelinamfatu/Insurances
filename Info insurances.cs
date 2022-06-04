using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsigurariDeViataSiBunuri
{
    public partial class Info : Form
    {
        List<Insurance> insurances = new List<Insurance>();
        string connectionName;
        public const string dateFormat = "dd-MM-yyyy HH:mm";
        public Info(List<Insurance> insurances)
        {
            InitializeComponent();
            lvSchedule.Visible = false;
            lvInsurances.Visible = true;
            this.insurances = insurances;
            foreach (Insurance i in insurances)
            {
                ListViewItem item = new ListViewItem(i.Type);
                item.SubItems.Add(i.Period.ToString());
                item.SubItems.Add(i.Price.ToString());
                item.SubItems.Add((i.Price / i.Period).ToString());
                lvInsurances.Items.Add(item);
            }
        }

        public Info(Client c)
        {
            InitializeComponent();
            connectionName = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DB.accdb";
            lvInsurances.Visible = false;
            lvSchedule.Visible = true;
            OleDbConnection connection = new OleDbConnection(connectionName);
            OleDbCommand query = new OleDbCommand();
            try
            {
                connection.Open();
                query.CommandText = $"SELECT id, CNP, TimeAppt FROM Schedule WHERE CNP='{c.CNP}'";
                query.Connection = connection;
                OleDbDataReader reader = query.ExecuteReader();
                while(reader.Read())
                {
                    int id = (int)reader["id"];
                    string CNP = reader["CNP"].ToString();
                    DateTime dt = DateTime.ParseExact(reader["TimeAppt"].ToString(), dateFormat, CultureInfo.InvariantCulture);
                    ListViewItem item = new ListViewItem(dt.Year.ToString());
                    item.SubItems.Add(dt.Month.ToString());
                    item.SubItems.Add(dt.Day.ToString());
                    item.SubItems.Add(dt.Hour.ToString());
                    item.SubItems.Add(dt.Minute.ToString());
                    lvSchedule.Items.Add(item);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private void lvInsurances_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvInsurances.Columns[e.ColumnIndex].Width;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvInsurances.Columns[e.ColumnIndex].Width;
        }
    }
}