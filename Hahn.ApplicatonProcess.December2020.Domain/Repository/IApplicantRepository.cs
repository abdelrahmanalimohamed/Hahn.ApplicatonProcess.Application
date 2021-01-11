using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.December2020.Domain.Repository
{
    public interface IApplicantRepository
    {

        Task<int> CreateApplicant(Model.ApplicantModel applicantModel);

        Task <List<Model.ApplicantModel>> GetAllApplicant();

        Task<Model.ApplicantModel> GetApplicant(int id);

        Task<int> UpdateApplicant(int id , Model.ApplicantModel applicantModel);

        Task<int> DeleteApplicant(int id);
            
    }
}
