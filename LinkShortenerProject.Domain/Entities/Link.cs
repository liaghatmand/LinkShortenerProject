using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenerProject.Domain.Entities
{
    public class Link
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
