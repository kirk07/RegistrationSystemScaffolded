using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistrationSystemScaffolded.Models;

namespace RegistrationSystemScaffolded.Data
{
    public class RegistrationDBContext : DbContext
    {
        public RegistrationDBContext(DbContextOptions<RegistrationDBContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
