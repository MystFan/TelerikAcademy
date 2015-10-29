using StudentSystem.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Services.Models
{
    public class CourseOutputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Materials { get; set; }

        public IEnumerable<StudentOutputModel> Students { get; set; }
    }
}