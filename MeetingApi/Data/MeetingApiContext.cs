using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeetingApi.Models;

namespace MeetingApi.Data
{
    public class MeetingApiContext : DbContext
    {
        public MeetingApiContext (DbContextOptions<MeetingApiContext> options)
            : base(options)
        {
        }

        public DbSet<MeetingApi.Models.Meeting> Meeting { get; set; } = default!;
    }
}
