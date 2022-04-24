using CodeFirstApp.Models;
using CodeFirstApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async void TestSaveJob()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
.UseInMemoryDatabase(databaseName: "Test_AddNewJob").Options;
            using (var context = new ApplicationDbContext(options))
            {
                var service = new JobService(context);
                var testjob = new JobModel()
                {
                    Name = "Accounting Manager",
                    Description = "Managing the daily operations"
                };
                var result = service.AddJob(testjob).Result;

                var joblist = service.GetAll().Result;
                Assert.Equal(true, result > 0);
            }
        }

        [Fact]
        public void TestGetJobs()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
.UseInMemoryDatabase(databaseName: "Test_AddNewJob").Options;
            using (var context = new ApplicationDbContext(options))
            {
                var service = new JobService(context);
                var joblist = service.GetAll().Result;
                Assert.Empty(joblist);
            }
        }
    }


}