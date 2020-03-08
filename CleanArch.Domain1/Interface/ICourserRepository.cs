using CleanArch.Domain1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interface
{
    public interface ICourserRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
