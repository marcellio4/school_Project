using System;

namespace ProtectedProxy
{
    public class Employee : IStaff
    {
        public bool IsOwner()
        {
            return false;
        }

        public string GenerateDailyReport()
        {
            return "Not Authorised to view report";
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}