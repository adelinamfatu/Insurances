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
    public partial class Asigurari : Form
    {
        string connectionName;
        public Asigurari()
        {
            InitializeComponent();
            connectionName = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DB.accdb";
            tbUsername.KeyPress += new KeyPressEventHandler(tbUsername_CharPress);
        }

        private void rbRomana_CheckedChanged(object sender, EventArgs e)
        {
            lbWelcome.Text = "Bine ati venit!";
            lbUsername.Text = "CNP:";
            lbPassword.Text = "Parola:";
            btnSignin.Text = "Conectare";
            btnNewAccount.Text = "Nu aveti cont?";
            btnForgotPass.Text = "Ati uitat parola?";
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome!";
            lbUsername.Text = "NIN:";
            lbPassword.Text = "Password:";
            btnSignin.Text = "Sign in";
            btnNewAccount.Text = "Don't have an account yet?";
            btnForgotPass.Text = "Forgot password?";
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccount account;
            if (rbRomana.Checked)
            {
                account = new CreateAccount();
            }
            else
            {
                account = new CreateAccount();
            }
            this.Hide();
            account.ShowDialog();
            this.Show();
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "")
            {
                string message = "";
                if (rbEng.Checked == true)
                {
                    message += "You didn't introduce the National Identification Number!";
                }
                else
                {
                    message += "Nu ati introdus Codul Numeric Personal!";
                }
                errorProvider.SetError(tbUsername, message);
            }
            else if(tbPassword.Text == "")
            {
                string message = "";
                if (rbEng.Checked == true)
                {
                    message += "You didn't introduce the password!";
                }
                else
                {
                    message += "Nu ati introdus parola!";
                }
                errorProvider.SetError(tbPassword, message);
            }
            else
            {
                errorProvider.Clear();
                searchDBforClient();
            }
        }

        private void logInAccount(Client c)
        {
            Adelurance_System ades = new Adelurance_System(c);
            this.Hide();
            ades.ShowDialog();
            this.Show();
            tbPassword.Clear();
            if(rbEng.Checked)
            {
                MessageBox.Show("You were disconnected!");
            }
            else
            {
                MessageBox.Show("Ai fost deconectat!");
            }
        }

        private void searchDBforClient()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionName);
                OleDbCommand interogation = new OleDbCommand($"SELECT * FROM clients WHERE cnp='{tbUsername.Text}' and pswd='{tbPassword.Text}'", connection);
                try
                {
                    connection.Open();
                    OleDbDataReader reader = interogation.ExecuteReader();
                    if (reader.Read() == false)
                    {
                        if (rbEng.Checked == true)
                        {
                            MessageBox.Show("You either typed incorrectly or you don't have an account! Try again!");
                        }
                        else
                        {
                            MessageBox.Show("Ati introdus gresit datele ori nu aveti cont! Incercati din nou!");
                        }
                        tbPassword.Clear();
                    }
                    else
                    {
                        do
                        {
                            if (reader["cnp"].ToString() == tbUsername.Text && reader["pswd"].ToString() == tbPassword.Text)
                            {
                                Client c = new Client(reader["cnp"].ToString(),
                                    reader["pswd"].ToString(), reader["FamilyName"].ToString(),
                                    reader["GivenName"].ToString(), reader["Email"].ToString(),
                                    Convert.ToDateTime(reader["DateOfBirth"].ToString()));
                                logInAccount(c);
                            }
                        } while (reader.Read());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You either typed incorrectly the password or the NIN!");
                }
                finally
                {
                    connection.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("The connection to the database failed!");
            }
        }

        private void tbUsername_CharPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string caption = "";
                string message = "";
                try
                {
                    if (tbUsername.Text.Length != 13)
                    {
                        if (rbEng.Checked == true)
                        {
                            message += "The username should contain exactly 13 characters!";
                            caption += "Error";
                        }
                        else
                        {
                            message += "CNP-ul ar trebui sa contina exact 13 caractere!";
                            caption += "Eroare";
                        }
                        displayUsernameMessage(caption, message);
                    }
                    else
                    {
                        int username = Convert.ToInt32(tbUsername.Text);
                    }
                }
                catch(Exception)
                {
                    if(rbEng.Checked == true)
                    {
                        message += "The username should not contain letters!";
                        caption += "Error";
                    }
                    else
                    {
                        message += "CNP-ul nu ar trebui sa contina litere!";
                        caption += "Eroare";
                    }
                    displayUsernameMessage(caption, message);
                }
            }
        }

        private void displayUsernameMessage(string caption, string message)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, button, MessageBoxIcon.Warning);
            tbUsername.Clear();
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            Reset_password r = new Reset_password();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}
