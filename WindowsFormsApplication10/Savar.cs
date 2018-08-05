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
    class Savar
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
        public Savar()
        {
            resim = KaynakYonetimi.ResimGetir("savar.png");
            Width = 40;
        }

        public void savarCizdir(Graphics g)
        {
            g.DrawImage(resim, X, Y, Width, Width);
        }
    }
}
