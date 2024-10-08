﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3EntityFrameworkCore.Entities
{
    public class CourseInstructor
    {
        //[Key, Column(Order = 0)]
        public int CourseId { get; set; }

        //[Key, Column(Order = 1)]
        public int InstructorId { get; set; }

        public DateTime HiringDate { get; set; }

        public Course Course { get; set; }

        public Instructor Instructor { get; set; }
    }
}
