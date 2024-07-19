﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeInfo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int salary { get; set; }


        public string Address { get; set; }

    }
}
