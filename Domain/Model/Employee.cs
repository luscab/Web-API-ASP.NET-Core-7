﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Domain.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]

        public int id { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }
        public string? photo { get; private set; }

        public Employee(string name, int age, string photo)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
            this.photo = photo;
        }

        public Employee() { }
    }
}
