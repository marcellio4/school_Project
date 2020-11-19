using System;

namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator reportGenerator;

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            if (staff.IsOwner())
            {
                reportGenerator = staff.ReportGenerator;
            }
            else
            {
                reportGenerator = staff.ReportGenerator;
            }

        }

        public string GenerateDailyReport()
        {
            return reportGenerator.GenerateDailyReport();
        }
    }
}