using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace WindowsFormsApplication10
{
    class Mermi
    {
        private int x;
        private int y;
        private int width;

        Image resim;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Mermi()
        {
            resim = KaynakYonetimi.ResimGetir("mermi.png");
            width = 15;
        }

        public void mermiCizdir(Graphics g)
        {
            g.DrawImage(resim, X, Y, width, width);
        }
    }
}
