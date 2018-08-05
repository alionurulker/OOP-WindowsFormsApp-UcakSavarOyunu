using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication10
{
    class KaynakYonetimi
    {
        private static Dictionary<string, Image> resimler = new Dictionary<string, Image>();

        public static Image ResimGetir(string resimIsmi)
        {

            if (!resimler.ContainsKey(resimIsmi))
                resimler[resimIsmi] = Image.FromFile(resimIsmi);

            return resimler[resimIsmi];
        }

    }
}
