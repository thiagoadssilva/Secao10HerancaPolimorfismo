using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoClassesMetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double result = 0;

            if (NumberOfEmployees < 10)
            {
                result = AnualIncome * 0.16;
            }
            else
            {
                result = AnualIncome * 0.14;
            }

            return result;
        }
    }
}
