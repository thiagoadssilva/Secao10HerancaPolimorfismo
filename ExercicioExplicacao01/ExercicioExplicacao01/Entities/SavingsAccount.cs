﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExplicacao01.Entities
{
    class SavingsAccount : Account
    {
        public double InteresRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interesRate) : base(number, holder, balance)
        {
            InteresRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }
    }
}
