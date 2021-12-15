using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi.Models
{
    public class Major
    {
        public int Id { get; set; }
        [StringLength(4), Required]
        public string Code { get; set; }
        [StringLength(30), Required]
        public string Description { get; set; }
        [Required]
        public int MinSAT { get; set; }

        // Below is for fluent api to establish foreign key
        //public virtual IEnumberable<Student> Students { get; set; }

        public Major() { }
    }
}
