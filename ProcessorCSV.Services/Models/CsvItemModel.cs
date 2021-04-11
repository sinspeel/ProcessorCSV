using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Services.Models
{
    public class CsvItemModel
    {
        [Name("Student Number")]
        public string StudentNumber { get; set; }
        [Name("Firstname")]
        public string FirstName { get; set; }
        [Name("Surname")]
        public string Surname { get; set; }
        [Name("Course Code")]
        public string CourseCode { get; set; }
        [Name("Course Description")]
        public string CourseDescription { get; set; }
        [Name("Grade")]
        public string Grade { get; set; }
    }
}
