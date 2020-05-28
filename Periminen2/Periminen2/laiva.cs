using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Periminen2
{
    class laiva
    {
        public int osumaPisteet;
        public int maxOsumaPisteet;
        public Point[] paikat;

        public laiva(int _osumaPisteet)
        {
            osumaPisteet = _osumaPisteet;
            maxOsumaPisteet = _osumaPisteet;
        }

        public void sijoita(int X, int Y, int _koko, int _suunta)
        {
            paikat = new Point[_koko];
            for (int i = 0; i < _koko; i++)
            {
                if (_suunta == 1)
                {
                    paikat[i] = (new Point(Y, X + i));
                }
                else
                {
                    paikat[i] = (new Point(Y + i, X));
                }
            }
        }

        public bool haePaikka(int Y, int X)
        {
            for (int i = 0; i < paikat.Length; i++)
            {
                if (paikat[i].Y == Y && paikat[i].X == X)
                {
                    osumaPisteet = osumaPisteet - 1;
                    return true;
                }
            }
            return false;
        }
    }
}
