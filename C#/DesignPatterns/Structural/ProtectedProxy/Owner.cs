using System;
using System.Text;

namespace ProtectedProxy
{
    public class Owner : IStaff
    {
        public bool IsOwner()
        {
            return true;
        }

        public string GenerateDailyReport()
        {
            var builder = "********************Location X Daily Report********************\n";
            builder += "Location ID: 012\n";
            builder += "Today's Date: Sun Sep 14 13:28:12 IST 2014\n";
            builder += "Total Pizza Sell: 112\n";
            builder += "Total Sale: $2534\n";
            builder += "Net Profit: $1985\n";
            builder += "***************************************************************";
            return builder;
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}