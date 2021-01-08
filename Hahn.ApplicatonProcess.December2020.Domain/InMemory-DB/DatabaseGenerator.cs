using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.December2020.Domain.InMemory_DB
{
   public class DatabaseGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicantContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicantContext>>()))
            {
                
                if (context.Applicants.Any())
                {
                    return;   
                }

                context.Applicants.AddRange(
                    new Model.ApplicantModel
                    {
                        ID = 1,
                        Name = "Test One",
                        FamilyName = "FamilyOne",
                        Address = "Cairo",
                        Age = 20,
                        EMailAddress ="test@yahoo.com" , 
                        CountryofOrigin = "Egypt" ,
                        Hired = true
                        
                    },
                    new Model.ApplicantModel
                    {
                        ID = 2,
                        Name = "Test Two",
                        FamilyName = "FamilyTwo",
                        Address = "London",
                        Age = 22,
                        EMailAddress = "test_two@yahoo.com",
                        CountryofOrigin = "London",
                        Hired = false
                    },
                    new Model.ApplicantModel
                    {
                        ID = 3,
                        Name = "Test three",
                        FamilyName = "FamilyThree",
                        Address = "USA",
                        Age = 24,
                        EMailAddress = "test_three@yahoo.com",
                        CountryofOrigin = "USA",
                        Hired = false
                    },
                  
                    new Model.ApplicantModel
                    {
                        ID = 4,
                        Name = "Test Four",
                        FamilyName = "FamilyFour",
                        Address = "India",
                        Age = 27,
                        EMailAddress = "test_four@outlook.com",
                        CountryofOrigin = "India",
                        Hired = true
                    });

                context.SaveChanges();
            }
        }
    }
}
