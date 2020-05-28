using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Periminen2 
{
    public class Alue
    {
        public int[][] alueData = new int[11][];
        int i;
        int j;

        private laiva[] laivat = new laiva[5];
        private int laivatMaara = 0;

        public void LuoAlue()
        {
            laivatMaara = 0;
            laiva[] laivat = new laiva[5];

            alueData[0] = new int[10]{0,0,0,0,0,0,0,0,0,0};
            alueData[1] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[2] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[3] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[4] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[5] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[6] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[7] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[8] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[9] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            alueData[10] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public void SijoitaLaivat(int _laivatMaara)
        {
            Random rnd = new Random();
            int luku1 = rnd.Next(10);
            int luku2 = rnd.Next(10);

            int pysty = 0;

            bool sijoitus = true;

            laivat = new laiva[_laivatMaara];


            for (i = 1; i < _laivatMaara + 1; i++)
            {
                        pysty = rnd.Next(2);
                        do
                        {
                            luku1 = rnd.Next(10);
                            luku2 = rnd.Next(10);
                        }
                        while (alueData[luku1][luku2] == 1);

                        do
                        {
                            sijoitus = false;
                            if (pysty == 1)
                            {
                                //PYSTY
                                for (j = 0; j < i; j++)
                                {
                                    if (luku1 + i < 9)
                                    {
                                        if (alueData[luku1 + j][luku2] == 1)
                                        {
                                            sijoitus = true;
                                            luku1 = luku1 + 1;
                                            break;
                                        }
                                        if (luku1 > 0 && luku1 < 9)
                                        {
                                            if (alueData[luku1 + j + 1][luku2] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                        if (luku1 < 9 && luku1 > 0)
                                        {
                                            if (alueData[luku1 + j - 1][luku2] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                        if (luku2 < 9 && luku2 > 0)
                                        {
                                            if (alueData[luku1 + j][luku2 + 1] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                        if (luku2 > 0 && luku2 < 9)
                                        {
                                            if (alueData[luku1 + j][luku2 - 1] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        luku2 = luku2 + 1;
                                        luku1 = 0;
                                        sijoitus = true;
                                        if (luku2 > 9)
                                            luku2 = 0;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                //VAAKA
                                for (j = 0; j < i; j++)
                                {
                                    if (luku2 + i < 9 && luku1 < 9)
                                    {
                                        if (alueData[luku1][luku2 + j] == 1)
                                        {
                                            sijoitus = true;
                                            luku1 = luku1 + 1;
                                            break;
                                        }
                                        if (luku2 > 0 && luku2 < 9)
                                        {
                                            if (alueData[luku1][luku2 + j - 1] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                        if (luku2 < 9 && luku2 > 0)
                                        {
                                            if (alueData[luku1][luku2 + j + 1] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                        if (luku1 < 9 && luku1 > 0)
                                        {
                                            if (alueData[luku1 + 1][luku2 + j] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                        if (luku1 > 0 && luku1 < 9)
                                        {
                                            if (alueData[luku1 - 1][luku2 + j] == 1)
                                            {
                                                sijoitus = true;
                                                luku1 = luku1 + 1;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        luku2 = luku2 + 1;
                                        luku1 = 0;
                                        sijoitus = true;
                                        if (luku2 > 9)
                                            luku2 = 0;
                                        break;
                                    }
                                }
                            }
                        }
                        while (sijoitus);

                        laivat[i - 1] = new laiva(i);
                        laivat[i - 1].sijoita(luku1, luku2, i, pysty);

                        if (pysty == 1)
                        {
                            for (j = 0; j < i; j++)
                            {
                                alueData[luku1 + j][luku2] = 1;
                            }
                        }
                        else
                        {
                            for (j = 0; j < i; j++)
                            {
                                alueData[luku1][luku2 + j] = 1;
                            }
                        }
                
            }

        }

        public String OsuikoLaivat(Panel _pnlMeri, int X, int Y)
        {
            Graphics g = Graphics.FromHwnd(_pnlMeri.Handle);
            Brush kyna = new SolidBrush(Color.Red);
            Brush kyna2 = new SolidBrush(Color.Blue);
            Brush kyna3 = new SolidBrush(Color.Black);
            String viesti = "";

            if (Y > 9)
                Y = 9;
            if (X > 9)
                X = 9;
            if (alueData[Y][X] == 2)
            {
                g.FillEllipse(kyna3, X * 30, Y * 30, 30, 30);
                return "Ohi";
            }
            if (alueData[Y][X] == 1)
            {
                g.FillEllipse(kyna, X * 30, Y * 30, 30, 30);
                viesti = "Osui";
                for (i = 0; i < laivat.Length; i++)
                {
                    if (laivat[i].haePaikka(Y, X))
                    {
                        if (laivat[i].osumaPisteet <= 0)
                        {
                            viesti = viesti + " ja upposi!";
                        }
                    }
                }
            }
            else
            {
                g.FillEllipse(kyna2, X * 30, Y * 30, 30, 30);
                viesti = "Ohi";
            }
            alueData[Y][X] = 2;
            return viesti;
        }

        public bool TarkistaLaivat()
        {
            bool upposi = false;

            return upposi;
        }

        public bool sijoitaLaivaCoor(int _x, int _y, int _koko, int suunta, Panel _pnlMeri)
        {
            Graphics g = Graphics.FromHwnd(_pnlMeri.Handle);
            Brush kyna = new SolidBrush(Color.Purple);
            Brush kyna2 = new SolidBrush(Color.Blue);

            if (suunta == 0)
            {
                if (_x + _koko > 10)
                    return false;
            }
            if (suunta == 1)
            {
                if (_y + _koko > 10)
                    return false;
            }

            for (j = 0; j < _koko; j++)
            {
                if (suunta == 0)
                {
                    if (_y > 0)
                    {
                        if (alueData[_y - 1][_x + j] == 1)
                            return false;
                    }
                    if (_y < 9)
                    {
                        if (alueData[_y + 1][_x + j] == 1)
                            return false;
                    }
                    if (_x + j > 0)
                    {
                        if (alueData[_y][_x + j - 1] == 1)
                            return false;
                    }
                    if (_x + j < 9)
                    {
                        if (alueData[_y][_x + j + 1] == 1)
                            return false;
                    }
                    if (alueData[_y][_x + j] == 1)
                        return false;
                }
                else
                {
                    if (_x > 0)
                    {
                        if (alueData[_y + j][_x - 1] == 1)
                            return false;
                    }
                    if (_x < 9)
                    {
                        if (alueData[_y + j][_x + 1] == 1)
                            return false;
                    }
                    if (_y > 0)
                    {
                        if (alueData[_y + j - 1][_x] == 1)
                            return false;
                    }
                    if (_y < 9)
                    {
                        if (alueData[_y + j + 1][_x] == 1)
                            return false;
                    }
                    if (alueData[_y + j][_x] == 1)
                        return false;
                }
            }

            for (j = 0; j < _koko; j++)
            {
                if (suunta == 0)
                {
                    alueData[_y][_x + j] = 1;
                    g.FillRectangle(kyna, _x * 30 + (j * 30), _y * 30, 30, 30);
                }
                else
                {
                    alueData[_y + j][_x] = 1;
                    g.FillRectangle(kyna, _x * 30, _y * 30 + (j * 30), 30, 30);
                }
            }

            laivat[laivatMaara] = new laiva(_koko);
            laivat[laivatMaara].sijoita(_y, _x, _koko, suunta);
            laivatMaara++;

            g.Dispose();

            return true;
        }

        public void PiirraLaivat(Panel _pnlMeri)
        {
            Graphics g = Graphics.FromHwnd(_pnlMeri.Handle);
            Brush kyna = new SolidBrush(Color.Purple);
            Brush kyna2 = new SolidBrush(Color.Blue);

            for (i = 0; i < alueData.Length - 1; i++)
            {
                for (j = 0; j < alueData[j].Length; j++)
                {
                    if (alueData[i][j] == 1)
                    {
                        g.FillRectangle(kyna, j * 30, i * 30, 30, 30);
                    }
                }
            }

            g.Dispose();
        }

        public int haePiste(int _x, int _y)
        {
            if (_y == -1)
                return 2;
            int piste = alueData[_y][_x];
            return piste;
        }
    }
}
