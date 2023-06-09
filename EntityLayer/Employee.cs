﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Employee
    {
        private int id; 
        private string name;
        private string surname;
        private string city;
        private short salary;
        private bool state;
        private string job;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public short Salary { get => salary; set => salary = value; }
        public bool State { get => state; set => state = value; }
        public string Job { get => job; set => job = value; }
    }
}
