using AuthenticationWithClie.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.Database.Repository
{
    public class ReportRepository : Common.Repository<Report, Guid>
    {
        //private static int _idCounter;

        //public static int IdCounter
        //{
        //    get
        //    {
        //        _idCounter++;
        //        return _idCounter;
        //    }
        //}

        public static Report Add(User from, User to, string content)
        {
            Report report = new Report(from, to, content);
            DbContext.Add(report);
            return report;
        }


    }
}
