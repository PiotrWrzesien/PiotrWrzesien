using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklepik
{
    public class koszyk
    {
        public List<Produkt> Produkty { get; set; } = new List<Produkt>();

        public decimal TotalPrinceBrutto { get; set; }
        get {return Produkty.Sum(p => prop.PriceBrutto);}

    public decimal VatValue
        get 
        {

    
    var TotalNetto = Produkty.Sum(p => p.PriceNetto);
    return TotalPriceBrutto - totalNetto;
        }


    }
}
