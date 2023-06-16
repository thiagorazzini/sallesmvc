﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
            
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Add(Seller s)
        {
            Sellers.Add(s);
        }

        public double TotalSales(DateTime initial, DateTime end)
        {
            return Sellers.Sum(s => TotalSales(initial, end));
        }
    }
}
