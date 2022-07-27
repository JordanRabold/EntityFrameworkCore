using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class Student
    {
        [Key] // Tell EF core to make this a primary key (PK)
        public int Id { get; set; } 

        public string? FullName { get; set; } // object

        public DateTime DateOfBirth { get; set; } // object
    }
}
