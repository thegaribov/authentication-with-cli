using AuthenticationWithClie.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.Database.Repository
{
    public class ReportRepository
    {
        private static int _idCounter;

        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }


        private static List<Report> Reports { get; set; } = new List<Report>();

        public static Report Add(User from, User to, string content)
        {
            Report report = new Report(from, to, content);
            Reports.Add(report);
            return report;
        }
        public static List<Report> GetAll()
        {
            return Reports;
        }
    }
}
