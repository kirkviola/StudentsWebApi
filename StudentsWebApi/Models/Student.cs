using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(2), Required]
        public string StateCode { get; set; }
        public int SAT { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal GPA { get; set; }

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }

        public Student() { }

    }
}
