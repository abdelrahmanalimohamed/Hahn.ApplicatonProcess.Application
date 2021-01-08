using System;
using Hahn.ApplicatonProcess.December2020.Data;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.December2020.Domain.Model
{
    public class ApplicantModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string FamilyName { get; set; }

        public string Address { get; set; }

       // public IEnumerable<string> CountryOfOrigin { get; set; }

        public string CountryofOrigin { get; set; }
        public string EMailAddress { get; set; }

        public int Age { get; set; }

        public bool Hired { get; set; }

        public ApplicantModel()
        {

        }
        public ApplicantModel(Applicant applicant)
        {
            ID = applicant._ID;
            Name = applicant._Name;
            FamilyName = applicant._FamilyName;
            Address = applicant._Address;
            EMailAddress = applicant._EmailAddress;
            Age = applicant._Age;
            Hired = applicant._Hired;
            CountryofOrigin = applicant._CountryOfOrigin;

        }
    }
}
