using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Periminen2
{
    class ukko
    {
        public Image[] anim = null;
        public int animLsk = 0;
        public Point loc;
        int kuvalkm;

        public ukko(Point _loc)
        {
            loc = _loc; 
            StreamReader lukija = new StreamReader("Osumat.txt", Encoding.Default);

            String rivit = lukija.ReadToEnd();
            String[] sanat = rivit.Split('\n');
            lukija.Close();

            kuvalkm = int.Parse(sanat[0]);
            int tiedoslkm = int.Parse(sanat[1]);

            int i = 0;
            anim = new Image[kuvalkm];

            for (i = 0; i < kuvalkm; i++)
            {
                anim[i] = Image.FromFile(sanat[i + 2]);
            }
        }

        public void Animoi()
        {
            animLsk++;
            if (animLsk >= kuvalkm)
                animLsk = 0;
        }
    }
}
