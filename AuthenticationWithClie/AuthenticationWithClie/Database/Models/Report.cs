using AuthenticationWithClie.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.Database.Models
{
    public sealed class Report
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public User From { get; set; }
        public User To { get; set; }
        public DateTime ReportDate { get; set; } = DateTime.Now;

        public Report(User from, User to, string content)
        {
            Id = ReportRepository.IdCounter;
            Content = content;
            From = from;
            To = to;
        }

        public string GetInfo()
        {
            return $"From : {From.Email}, To : {To.Email}, Content : {Content}, Is admin {To is Admin}, Report date : {ReportDate.ToString("HH:mm dd.MM.yyyy")}";
        }
    }
}
