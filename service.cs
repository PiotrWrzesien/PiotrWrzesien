using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklepik
{
    public class service
    {

        public service()
        {
            CreateWareHouse();
        }
        private void CreateWarehouse()
            Werehouse.Add(new Produkt("001", "maslo",6,50m));
            Werehouse.Add(new Produkt("002", "chleb",4,50m));
            Werehouse.Add(new Produkt("003", "makaron",9,20m));
            Werehouse.Add(new Produkt("004", "dzem",8,15m));
            Werehouse.Add(new Produkt("005", "kielbasa",29,90m));
            Werehouse.Add(new Produkt("006", "szynka",21,90m));
            Werehouse.Add(new Produkt("007", "chipsy",5,90m));
            Werehouse.Add(new Produkt("008", "serek",3,50m));
            Werehouse.Add(new Produkt("009", "cukier",2,69m));
            Werehouse.Add(new Produkt("010", "sol",3,19m));


            while (true)
            { var userchoice = screen.ShowMenu();
        if (userChoice =="1")
            Screen.ShowProduktList(service werehouse);
            }
            else if (userChoice == "2")
            }
while (true)
{
    Console. Write("kod kreskowy lub nacisnij p po paragon")
        var code = Console.ReadLine();
    if (code.ToLower() ==("p")
        else
            {
                var produkt = serivce.Findprodukt(code);
            if (produkt != null)
                service.AddProduktToBasket(produkt);

            }

}


        public List<Produkt> Warehouse { get; set; }
        public koszyk koszyk { get; set; }

    }


}
