using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema_class
{
    class bilet
    {
        public int koltuk_sayısı;
        public int bakiye=0;
       

        public void biletsat() 
        {
            koltuk_sayısı--;
           
            bakiye =bakiye+10;
           


        }
        public void biletiptal()
        {
            koltuk_sayısı++;
            bakiye = bakiye - 10;
          
        }
       
      

    }
}
