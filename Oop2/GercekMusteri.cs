using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    // gercekmusteride bir musteridir // musteride olan her sey gercekde de kabul edilir
    // sadece kendıne has ozellıklerı yazazrız
    class GercekMusteri:Musteri
    {
  
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
