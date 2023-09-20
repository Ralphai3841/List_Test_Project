using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Test_Project
{
    class Kisiler
    {
        string ad;
        string soyad;
        string meslek;

        public string ADI
        {
            get { return ad; }
            set {  ad = value; }
        }

        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string MESLEKI
        {
            get { return meslek; }
            set { meslek = value; }
        }
    }
}
