﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ProcessorCSV.DAL.Entities
{
    public partial class DocumentItem
    {
        public Guid Id { get; set; }
        public Guid DocumentID { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string Grade { get; set; }

        public virtual Document Document { get; set; }
    }
}