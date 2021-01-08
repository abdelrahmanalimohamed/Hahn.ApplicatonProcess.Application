using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.December2020.Data
{
   public class Applicant
    {
        private int ID;
        private string Name;
        private string FamilyName;
        private string Address;
        // private IEnumerable<string> CountryOfOrigin;
        private string CountryOfOrigin;
        private string EMailAdress;
        private int Age;
        private bool Hired;

        public int _ID
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string _Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }


        public string _FamilyName
        {
            get
            {
                return FamilyName;
            }

            set
            {
                FamilyName = value;
            }
        }

        public string _Address
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }


        public string _CountryOfOrigin
        {
            get
            {
                return CountryOfOrigin;
            }
            set
            {
                CountryOfOrigin = value;
            }
        }

        public string _EmailAddress
        {
            get
            {
                return EMailAdress;
            }

            set
            {
                EMailAdress = value;
            }
        }


        public int _Age
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        public bool _Hired
        {
            get
            {
                return Hired;
            }
            set
            {
                Hired = value;
            }
        }
    }
}
