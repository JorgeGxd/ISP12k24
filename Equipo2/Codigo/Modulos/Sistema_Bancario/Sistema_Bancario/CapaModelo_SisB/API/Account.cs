﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; }

        public Account(int id, string name, string number, double balance)
        {
            Id = id;
            Name = name;
            Number = number;
            Balance = balance;
        }
    }
}
