using CleanArch.Domain1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBcontext : DbContext
    {

        public UniversityDBcontext(DbContextOptions<UniversityDBcontext> options)
            :base(options)
        {

        }

        public DbSet<Course> MyProperty { get; set; }
        public IEnumerable<Course> Course { get; internal set; }
    }
}
