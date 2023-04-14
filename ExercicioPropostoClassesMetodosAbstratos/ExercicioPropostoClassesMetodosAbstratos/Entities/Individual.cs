using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoClassesMetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        //public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double result = 0;
            double abatement = 0;

            if (AnualIncome < 20000.00) {
                result = AnualIncome * 0.15;
            }else
            {
                result = AnualIncome * 0.25;
            }
            
            if(HealthExpenditures > 0)
            {
                abatement = HealthExpenditures * 0.5;
                result = result - abatement;
            }

            return result;
        }
    }
}
