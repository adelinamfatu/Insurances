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
    public partial class Reset_password : Form
    {
        string connectionName;
        Random rd = new Random();
        int rand;

        public Reset_password()
        {
            InitializeComponent();
            connectionName = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DB.accdb";
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            lbReset.Text = "Reset your password!";
            lbEmail.Text = "Email";
            lbPassword.Text = "New password";
            lbConfirmPasswd.Text = "Confirm new password";
            btnSendMail.Text = "Send email";
            btnChange.Text = "Change password";
        }

        private void rbRom_CheckedChanged(object sender, EventArgs e)
        {
            lbReset.Text = "Resetare parola!";
            lbEmail.Text = "Email";
            lbPassword.Text = "Parola noua";
            lbConfirmPasswd.Text = "Confirmare parola noua";
            btnSendMail.Text = "Trimite email";
            btnChange.Text = "Schimba parola";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbEmail, "Introduce the email!");
                }
                else
                {
                    errorProvider.SetError(tbEmail, "Introduceti email-ul!");
                }
            }
            else if(tbCode.Text == "")
            {
                if (rbEng.Checked == true)
                {
                    errorProvider.SetError(tbCode, "Introduce the code!");
                }
                else
                {
                    errorProvider.SetError(tbCode, "Introduceti codul de confirmare!");
                }
            } else if(tbPassword.Text == "")
            {
                if (rbEng.Checked == true)
                {
                    errorProvider.SetError(tbPassword, "Introduce the password!");
                }
                else
                {
                    errorProvider.SetError(tbPassword, "Introduceti parola!");
                }
            } else if(tbConfirmPasswd.Text == "")
            {
                if (rbEng.Checked == true)
                {
                    errorProvider.SetError(tbConfirmPasswd, "Introduce the password once again!");
                }
                else
                {
                    errorProvider.SetError(tbConfirmPasswd, "Introduceti parola din nou!");
                }
            }
            else
            {
                errorProvider.Clear();
                if(verify())
                {
                    OleDbConnection connection = new OleDbConnection(connectionName);
                    OleDbCommand query = new OleDbCommand();
                    try
                    {
                        connection.Open();
                        query.CommandText = $"UPDATE clients SET pswd='{tbPassword.Text}' WHERE email='{tbEmail.Text}'";
                        query.Connection = connection;
                        query.ExecuteNonQuery();
                        if (rbEng.Checked == true)
                        {
                            MessageBox.Show("Your password was changed!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Parola dvs. a fost schimbata!", "Parola", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    catch(Exception ex)
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private bool verify()
        {
            if(tbCode.Text != rand.ToString())
            {
                if (rbEng.Checked == true)
                {
                    errorProvider.SetError(tbCode, "Code doesn't match!");
                }
                else
                {
                    errorProvider.SetError(tbCode, "Codul nu corespunde!");
                }
                return false;
            } else if(tbPassword.Text != tbConfirmPasswd.Text)
            {
                if (rbEng.Checked == true)
                {
                    errorProvider.SetError(tbConfirmPasswd, "Password doesn't match!");
                }
                else
                {
                    errorProvider.SetError(tbConfirmPasswd, "Parola nu corespunde!");
                }
                return false;
            }
            return true;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionName);
                OleDbCommand query = new OleDbCommand();
                try
                {
                    connection.Open();
                    query.CommandText = $"SELECT * FROM clients WHERE email='{tbEmail.Text}'";
                    query.Connection = connection;
                    query.ExecuteNonQuery();
                    string email = tbEmail.Text;
                    rand = rd.Next(1000, 9999);
                    MailMessage message = new MailMessage("pawproiect@gmail.com", email);
                    message.Subject = "Confirmation mail";
                    message.Body = "Thank you for using our sevices!" + Environment.NewLine
                        + "Your code is " + rand.ToString() + ".";
                    SmtpClient smtp = new SmtpClient();
                    smtp.UseDefaultCredentials = false;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    System.Net.NetworkCredential nc = new NetworkCredential("pawproiect@gmail.com", "proiect123");
                    smtp.Credentials = nc;
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
                catch (Exception)
                {
                    if (rbEng.Checked == true)
                    {
                        MessageBox.Show("You don't have an account or you didn't introduce the email correctly! Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Nu aveti cont sau nu ati introdus email-ul corect! Incercati din nou!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
