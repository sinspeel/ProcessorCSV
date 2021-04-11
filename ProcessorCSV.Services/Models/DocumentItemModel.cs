using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Services.Models
{
    public class DocumentItemModel
    {
        public Guid Id { get; set; }
        public Guid DocumentID { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string Grade { get; set; }
    }
}
