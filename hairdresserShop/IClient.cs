using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{
     public interface IClient
    {
         int Age { get ; set ; }
        decimal Height { get ; set  ; }
         string CreditCardNumber { get ; set ; }
         string Name { get ; set ; }
         string Slot { get ; set ; }
        ShopServices Services { get; set; }

        void HairWash();

        void HairTrim();

        void HairDye();

    }

}
