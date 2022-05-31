using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsigurariDeViataSiBunuri
{
    public partial class Meeting : Form
    {
        string connectionName;
        Client c;
        public Meeting(Client c)
        {
            InitializeComponent();
            connectionName = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DB.accdb";
            this.c = c;
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            btnCommit.Text = "Commit";
        }

        private void rbRom_CheckedChanged(object sender, EventArgs e)
        {
            btnCommit.Text = "Comite";
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionName);
            OleDbCommand insertCommand = new OleDbCommand();
            try
            {
                connection.Open();
                insertCommand.CommandText = $"INSERT INTO Schedule(CNP, ScheduleTime) VALUES(@CNP, @dt)";
                insertCommand.Parameters.Add("@CNP", OleDbType.VarChar).Value = c.CNP;
                insertCommand.Parameters.Add("@dt", OleDbType.Date).Value = dateTimePicker.Value;
                insertCommand.Connection = connection;
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if(rbEng.Checked)
                {
                    MessageBox.Show("Your time was booked!\nWe will wait there on our office!");
                }
                else
                {
                    MessageBox.Show("Timpul a fost inregistrat!\nVa asteptam la data respectiva la sediul nostru!");
                }
                connection.Close();
            }
        }
    }
}
