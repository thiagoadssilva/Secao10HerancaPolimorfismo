using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name,int hour, double valuePerHour ,double additionalCherge) : base (name, hour, valuePerHour)
        {
            AdditionalCharge = additionalCherge;
        }

        public override double Payment()
        {
            double value = base.Payment();
            return value + (AdditionalCharge * 1.1);
        }

        /*Aula*/
        /*public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }*/
    }
}
