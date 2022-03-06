using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep

{
    public class Produkt
    {
       public Produkt (string barcode, string name, decimal pricenetto)
            barcode = barcode;
            name = name ;
            pricenetto = pricenetto ;

        
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal PriceNetto { get; set; }
        public decimal PrinceBrutto { get; set; }
        {
        get { return PrinceNetto* 1,23m; }

    }









}

