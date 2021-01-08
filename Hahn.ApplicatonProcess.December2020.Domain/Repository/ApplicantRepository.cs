using Hahn.ApplicatonProcess.December2020.Domain.InMemory_DB;
using Hahn.ApplicatonProcess.December2020.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.December2020.Domain.Repository
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly ApplicantContext _applicantContext;
        private readonly IServiceScope _scope;

        public ApplicantRepository(IServiceProvider serviceProvider)
        {
            _scope = serviceProvider.CreateScope();

            _applicantContext = _scope.ServiceProvider.GetRequiredService<ApplicantContext>();

            DatabaseGenerator.Initialize(serviceProvider);

        }

        public async Task<int> CreateApplicant(ApplicantModel applicantModel)
        {
            if (applicantModel != null)
            {
               await _applicantContext.Applicants.AddAsync(applicantModel);
                await _applicantContext.SaveChangesAsync();

                return applicantModel.ID;
            }

            return 0;
        }

        public async Task<int> DeleteApplicant(int id)
        {
            int result = 0;

            if (_applicantContext != null)
            {
                var applicant = await _applicantContext.Applicants.FirstOrDefaultAsync(x => x.ID == id);

                if (applicant != null)
                {
                    _applicantContext.Applicants.Remove(applicant);

                    result = await _applicantContext.SaveChangesAsync();
                }
                return result;
            }

            return result;

        }

        public async Task<List<ApplicantModel>> GetAllApplicant()
        {
            var allapplicant = await _applicantContext.Applicants.ToListAsync();

            return allapplicant;
        }

        public async Task<ApplicantModel> GetApplicant(int? id)
        {
           //s var applicant = await _applicantContext.Applicants.FindAsync(id);

                return await (from p in _applicantContext.Applicants
                              where p.ID == id
                              select new ApplicantModel
                              {
                                  ID = p.ID , 
                                  Name = p.Name
                              }).FirstOrDefaultAsync();
        }




        public async Task<int> UpdateApplicant(int id , ApplicantModel applicantModel)
        {
            if (_applicantContext != null)
            {
                var applicant  = await (from p in _applicantContext.Applicants
                                        where p.ID == id
                                        select new ApplicantModel
                                        {
                                            ID = p.ID,
                                            Name = p.Name
                                        }).FirstOrDefaultAsync();

                applicant = applicantModel;

                _applicantContext.Applicants.Update(applicant);

              var result =   await _applicantContext.SaveChangesAsync();

                return result;
            }

            return 0;
        }

    }
}
