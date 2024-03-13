using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220105
{
    internal class KodeBuah1
    {
        public String NamaBuah;
        public String KodeBuah;
        public List<KodeBuah> listKodeBuah = new List<KodeBuah>();

        PublicKey KodeBuah2(String a = " " String k = 0)
        {
            this.NamaBuah = a;
            this.KodeBuah = k;
        }

        public void setKodeBuah()
        {
            this.listKodeBuah.Add(new KodeBuah2("Apel","A00"));
        }
    }
}
