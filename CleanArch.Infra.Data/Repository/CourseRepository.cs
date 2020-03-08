using CleanArch.Domain.Interface;
using CleanArch.Domain1.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourserRepository
    {
        private UniversityDBcontext _ctx;
        public CourseRepository(UniversityDBcontext ctx)
        {
            this._ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Course;
        }
    }
}
