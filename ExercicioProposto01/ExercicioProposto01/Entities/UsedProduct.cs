using ExercicioProposto01.Entities.Enums;

using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto01.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFacture { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, StatusProduct statusProduct, TypeProduct type, DateTime manuFacture): base(name, price, statusProduct, type)
        {
            ManuFacture = manuFacture;
        }

        public override string PriceTag()
        {
            return Name + " (" + Type +") $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (data) de fabricação: " + ManuFacture.ToString("dd/MM/yyyy") + ")";
        }
    }
}
