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
    public partial class CreateAccount : Form
    {
        string connectionName;
        Random rd = new Random();
        int rand;
        public CreateAccount()
        {
            InitializeComponent();
            connectionName = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DB.accdb";
            tbCNP.KeyPress += new KeyPressEventHandler(tbCNP_CharPress);
            tbFamilyName.KeyPress += new KeyPressEventHandler(tbNames_NumberPress);
            tbGivenName.KeyPress += new KeyPressEventHandler(tbNames_NumberPress);
            tbConfirmEmail.KeyPress += new KeyPressEventHandler(tbCNP_CharPress);
        }

        private void tbCNP_CharPress(object sender, KeyPressEventArgs e)
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

        private void tbNames_NumberPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbGivenName.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbGivenName, "You didn't introduce the given name!");
                }
                else
                {
                    errorProvider.SetError(tbGivenName, "Nu ati introdus prenumele!");
                }
            }
            else if (tbFamilyName.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbFamilyName, "You didnt't introduce the family name!");
                }
                else
                {
                    errorProvider.SetError(tbFamilyName, "Nu ati introdus numele!");
                }
            }
            else if (tbPassword.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbPassword, "You didn't introduce the password!");
                }
                else
                {
                    errorProvider.SetError(tbPassword, "Nu ati introdus parola!");
                }
            }
            else if (tbConfirmPassw.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbConfirmPassw, "You didn't confirm the password!");
                }
                else
                {
                    errorProvider.SetError(tbConfirmPassw, "Nu ati confirmat parola!");
                }
            }
            else if (tbEmail.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbEmail, "You didn't introduce the email!");
                }
                else
                {
                    errorProvider.SetError(tbEmail, "Nu ati introdus email-ul!");
                }
            }
            else if (tbConfirmEmail.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbConfirmEmail, "You didn't confirm the email!");
                }
                else
                {
                    errorProvider.SetError(tbConfirmEmail, "Nu ati confirmat email-ul!");
                }
            }
            else if (tbCNP.Text == "")
            {
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbCNP, "You didn't introduce the NIN!");
                }
                else
                {
                    errorProvider.SetError(tbCNP, "Nu ati introdus CNP-ul!");
                }
            }
            else
            {
                bool alreadyHasAccount = false;
                errorProvider.Clear();
                if (verifyData() == true)
                {
                    try
                    {
                        Client c = new Client(
                            tbCNP.Text, tbPassword.Text, tbFamilyName.Text,
                            tbGivenName.Text, tbEmail.Text, Convert.ToDateTime(dateTimePicker.Value.ToString()));
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand query = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            query.CommandText = $"INSERT INTO clients(GivenName, FamilyName, CNP, Email, Pswd, DateOfBirth) VALUES('{c.GivenName}', '{c.FamilyName}', '{c.CNP}', '{c.Email}', '{c.Password}', '{c.DateOfBirth}')";
                            query.Connection = connection;
                            query.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            if(rbEng.Checked)
                            {
                                MessageBox.Show("The data could not be added! You probably already have an account!");
                            }
                            else
                            {
                                MessageBox.Show("Datele nu au putut fi adaugate! Probabil deja aveti un cont!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        if(rbEng.Checked == true)
                        {
                            MessageBox.Show("You didn't introduce the data correctly!");
                        }
                        else
                        {
                            MessageBox.Show("Nu ati introdus corect datele!");
                        }
                        alreadyHasAccount = true;
                    }
                    if(alreadyHasAccount==false)
                    {
                        if (rbEng.Checked == true)
                        {
                            MessageBox.Show("Your account was succesfully created!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Contul dvs. a fost creat cu succes!", "Cont", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
            }
        }

        private bool verifyData()
        {
            bool verify = true;
            if (!tbEmail.Text.Contains(".ro") ||
                !tbEmail.Text.Contains(".com"))
            {
                if (!tbEmail.Text.Contains("@"))
                {
                    verify = false;
                    if (rbEng.Checked == true)
                    {
                        errorProvider.SetError(tbEmail, "This format for email isn't supported!");
                    }
                    else
                    {
                        errorProvider.SetError(tbEmail, "Acest format nu este acceptat pentru mail!");
                    }
                }
            }
            if(tbCNP.Text.Length != 13)
            {
                verify = false;
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbCNP, "The NIN should contain exactly 13 characters!");
                }
                else
                {
                    errorProvider.SetError(tbCNP, "CNP-ul trebuie sa contina exact 13 caractere!");
                }
            }
            if(tbPassword.Text != tbConfirmPassw.Text)
            {
                verify = false;
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbConfirmPassw, "The passwords don't match!");
                }
                else
                {
                    errorProvider.SetError(tbConfirmPassw, "Parolele nu se potrivesc!");
                }
            }
            if(rand.ToString() != tbConfirmEmail.Text)
            {
                verify = false;
                if(rbEng.Checked == true)
                {
                    errorProvider.SetError(tbConfirmEmail, "The code doesn't match!");
                }
                else
                {
                    errorProvider.SetError(tbConfirmEmail, "Codul nu se potriveste!");
                }
            }
            return verify;
        }

        private void btnConfEmail_Click(object sender, EventArgs e)
        {
            rand = rd.Next(1000, 9999);
            MailMessage message = new MailMessage("pawproiect@gmail.com", tbEmail.Text);
            message.Subject = "Confirmation mail";
            message.Body = "Thank you for using our sevices!" + Environment.NewLine
                + "Your number is " + rand.ToString() + ".";
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("pawproiect@gmail.com", "proiect123");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(message);
            if(rbEng.Checked)
            {
                MessageBox.Show("The email was sent to your address!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mail-ul a fost trimis la adresa dvs.!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            lbWelcome.Text = "Create your account!";
            lbGivenName.Text = "Given name*";
            lbFamilyName.Text = "Family name*";
            lbCNP.Text = "NIN*";
            lbEmail.Text = "Email*";
            lbConfirmEmail.Text = "Confirm email*";
            lbPassword.Text = "Password*";
            lbConfirmPassw.Text = "Confirm password*";
            lbDateOfBirth.Text = "Date of birth*";
            btnConfEmail.Text = "Send confirmation email";
            btnCreateAccount.Text = "Create account";
            lbGoBack.Text = "In order to go back to Sign In page, press X";
        }

        private void rbRom_CheckedChanged(object sender, EventArgs e)
        {
            lbWelcome.Text = "Creeaza-ti contul!";
            lbGivenName.Text = "Prenume*";
            lbFamilyName.Text = "Nume*";
            lbCNP.Text = "CNP*";
            lbEmail.Text = "Email*";
            lbConfirmEmail.Text = "Confirma email*";
            lbPassword.Text = "Parola*";
            lbConfirmPassw.Text = "Confirma parola*";
            lbDateOfBirth.Text = "Data de nastere*";
            btnConfEmail.Text = "Trimite mail de confirmare";
            btnCreateAccount.Text = "Creeaza cont";
            lbGoBack.Text = "Pentru a reveni la pagina de conectare, apasati X";
        }
    }
}