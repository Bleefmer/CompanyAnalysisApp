using CompanyAnalysisApp.Models;
using Microsoft.Extensions.Configuration;
namespace CompanyAnalysisApp.Services
{
    public class EmployeeAnalyzerService
    {
        private readonly IConfiguration _configuration;

        public EmployeeAnalyzerService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetLargestCompany()
        {
            var companies = _configuration.GetSection("Companies").Get<List<Company>>();
            var largestCompany = companies.OrderByDescending(c => c.Employees).FirstOrDefault();
            return largestCompany != null ? largestCompany.Name : "No data";
        }
    }
}
