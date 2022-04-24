using CodeFirstApp.Models;

namespace CodeFirstApp.Services
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetList();
        Task<Job> GetJob(int Id);
        Task<int> AddJob(JobModel jobmodel);
        Task<int> UpdateJob(JobModel jobmodel);
        Task<int> DeleteJob(int Id);

    }
}
