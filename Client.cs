using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsigurariDeViataSiBunuri
{
    public class Client
    {
        string cNP;
        string password;
        string familyName;
        string givenName;
        string email;
        DateTime dateOfBirth;

        public Client(string CNP, string password)
        {
            this.cNP = CNP;
            this.password = password;
        }

        public Client(string cNP, string password, string familyName, string givenName, string email, DateTime dateOfBirth) : this(cNP, password)
        {
            this.familyName = familyName;
            this.givenName = givenName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
        }

        public string CNP
        {
            get => cNP;
        }

        public string Password
        {
            get => password;
        }

        public string FamilyName
        {
            get => familyName;
        }

        public string GivenName
        {
            get => givenName;
        }

        public string Email
        {
            get => email;
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
        }
    }
}
