using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            btnCommit.Text = "Commit";
        }

        private void rbRom_CheckedChanged(object sender, EventArgs e)
        {
            btnCommit.Text = "Comite";
        }

        private bool verifyExistDate(DateTime dt)
        {
            bool exist = false;
            OleDbConnection connection = new OleDbConnection(connectionName);
            OleDbCommand query = new OleDbCommand();
            try
            {
                connection.Open();
                query.CommandText = "SELECT COUNT(CNP) FROM Schedule" +
                    $" WHERE TimeAppt=@d";
                query.Parameters.AddWithValue("@d", dt.ToString(Info.dateFormat));
                query.Connection = connection;
                int count = (int)query.ExecuteScalar();
                if (count != 0)
                {
                    exist = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return exist;
        }

        private bool verifyDate()
        {
            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            int day = dateTimePicker.Value.Day;
            if ((year < System.DateTime.Now.Year) ||
                (year == System.DateTime.Now.Year
                && month < System.DateTime.Now.Month) ||
                (day < System.DateTime.Now.Day &&
                month == System.DateTime.Now.Month &&
                year == System.DateTime.Now.Day))
            {
                if (rbEng.Checked)
                {
                    MessageBox.Show("You can't start the insurance at a previous date!");
                }
                else
                {
                    MessageBox.Show("Nu puteti sa incepeti asigurarea la o data anterioara!");
                }
                return false;
            }
            return true;
        }

        private void sendMail(DateTime dt)
        {
            MailMessage message = new MailMessage("pawproiect@gmail.com", c.Email);
            message.Subject = "Visit appointment";
            message.Body = "Thank you for using our sevices!" + Environment.NewLine
                + "Your appointment is set for " + dt.Day + "." + dt.Month + "." + dt.Year + ".";
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("pawproiect@gmail.com", "proiect123");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(message);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if(verifyDate())
            {
                DateTime dt = new DateTime(dateTimePicker.Value.Year,
                    dateTimePicker.Value.Month, dateTimePicker.Value.Day,
                    int.Parse(cbHour.Text), int.Parse(cbMinute.Text), 0);
                if (verifyExistDate(dt) == true)
                {
                    if (rbEng.Checked)
                    {
                        MessageBox.Show("That time is already booked! Please choose another one!");
                    }
                    else
                    {
                        MessageBox.Show("Timpul acela este deja rezervat! Va rugam sa alegeti altul!");
                    }
                }
                else
                {
                    OleDbConnection connection = new OleDbConnection(connectionName);
                    OleDbCommand insertCommand = new OleDbCommand();
                    try
                    {
                        connection.Open();
                        insertCommand.CommandText = $"INSERT INTO Schedule(CNP, TimeAppt) VALUES(@CNP, @datet)";
                        insertCommand.Parameters.Add("@CNP", OleDbType.VarChar).Value = c.CNP;
                        insertCommand.Parameters.Add("@datet", OleDbType.VarChar).Value = dt.ToString(Info.dateFormat);
                        //insertCommand.Parameters.Add("@datet", OleDbType.Date).Value = dt;
                        insertCommand.Connection = connection;
                        insertCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        sendMail(dt);
                        if (rbEng.Checked)
                        {
                            MessageBox.Show("Your time was booked!\nA confirmation mail was sent to your address!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Timpul a fost inregistrat!\nUn mail de confirmare a fost trimis la adresa dvs.!", "Rezervare", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        connection.Close();
                        this.Close();
                    }
                }
            }
        }
    }
}
