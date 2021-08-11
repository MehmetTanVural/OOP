using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    // miras inheritance  // tuzelmusteri de bir musteridir musteride olan her sey tuzel musteride olur
    // sadece kendine has ozellikleri yazarız
    class TuzelMusteri:Musteri
    {
  
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
