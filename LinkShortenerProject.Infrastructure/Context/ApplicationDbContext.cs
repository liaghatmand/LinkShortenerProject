using LinkShortenerProject.Application.Common.Interfaces;
using LinkShortenerProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenerProject.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Link> Links { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
