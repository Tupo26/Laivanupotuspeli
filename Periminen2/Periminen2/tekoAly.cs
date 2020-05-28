using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Collections;

namespace Periminen2
{
    public class tekoAly
    {
        Panel pnlVihollisMeri;
        Alue vihollisMeri;
        ajatusKartta aateKartta;
        int kaytettytAmmukset = 0;
        int Cx = 0;
        int Cy = 0;
        Boolean rutiini = true;
        int RuutiniiAloitus = 0;
        Random rnd = new Random();
        Boolean toinenKierros = false;

        ArrayList kohteet = new ArrayList();
        int kaydytKohteet;

        Point ensimmainenOsuma;
        String pystyVaiVaaka = "enTiia";

        public int upotettutLaivat = 0;

        public tekoAly(Panel _panel, Alue _alue)
        {
            pnlVihollisMeri = _panel;
            vihollisMeri = _alue;
            aateKartta = new ajatusKartta();
            RuutiniiAloitus = rnd.Next(0, 1);
        }

        public void toimi()
        {
            kaytettytAmmukset++;
            String osuiko;
            
            if (rutiini)
            {
                while (aateKartta.haePiste(Cx, Cy) == 2)
                {
                    Cx = Cx + 2;
                    if (Cx > 9)
                    {
                        if (!toinenKierros)
                        {
                            if (Cy % 2 == 0)
                                Cx = 1;
                            else
                                Cx = 0;
                        }
                        else
                        {
                            if (Cy % 2 == 0)
                                Cx = 0;
                            else
                                Cx = 1;
                        }
                        Cy++;
                    }
                    if (Cy > 9)
                    {
                        if (RuutiniiAloitus == 0)
                        {
                            Cy = 0;
                            Cx = 1;
                        }
                        else
                        {
                            Cy = 0;
                            Cx = 0;
                        }
                        toinenKierros = true;
                    }
                }

                osuiko = vihollisMeri.OsuikoLaivat(pnlVihollisMeri, Cx, Cy);

                if (osuiko == "Ohi")
                {
                    aateKartta.asetaPiste(Cx, Cy);
                }
                else if (osuiko == "Osui")
                {
                    aateKartta.asetaPiste(Cx, Cy);

                    ensimmainenOsuma = new Point(Cx, Cy);

                    kohteet = new ArrayList();
                    rutiini = false;
                    kaydytKohteet = 0;

                    if (Cx > 0)
                    {
                        if (aateKartta.haePiste(Cx - 1, Cy) != 2)
                        {
                            kohteet.Add(new Point(Cx - 1, Cy));
                        }
                    }
                    if (Cx < 9)
                    {
                        if (aateKartta.haePiste(Cx + 1, Cy) != 2)
                        {
                            kohteet.Add(new Point(Cx + 1, Cy));
                        }
                    }
                    if (Cy > 0)
                    {
                        if (aateKartta.haePiste(Cx, Cy - 1) != 2)
                        {
                            kohteet.Add(new Point(Cx, Cy - 1));
                        }
                    }
                    if (Cy < 9)
                    {
                        if (aateKartta.haePiste(Cx, Cy + 1) != 2)
                        {
                            kohteet.Add(new Point(Cx, Cy + 1));
                        }
                    }
                }
                else if (osuiko == "Osui ja upposi!")
                {
                    upotettutLaivat++;
                    rutiini = true;
                    aateKartta.asetaPiste(Cx, Cy);
                    if (Cx > 0)
                    {
                        aateKartta.asetaPiste(Cx - 1, Cy);
                    }
                    if (Cx < 9)
                    {
                        aateKartta.asetaPiste(Cx + 1, Cy);
                    }
                    if (Cy > 0)
                    {
                        aateKartta.asetaPiste(Cx, Cy - 1);
                    }
                    if (Cy < 9)
                    {
                        aateKartta.asetaPiste(Cx, Cy + 1);
                    }
                }

                Cx = Cx + 2;
                if (Cx > 9)
                {
                    if (!toinenKierros)
                    {
                        if (Cy % 2 == 0)
                            Cx = 1;
                        else
                            Cx = 0;
                    }
                    else
                    {
                        if (Cy % 2 == 0)
                            Cx = 0;
                        else
                            Cx = 1;
                    }
                    Cy++;
                }
                if (Cy > 9)
                {
                    if (RuutiniiAloitus == 0)
                    {
                        Cy = 0;
                        Cx = 1;
                    }
                    else
                    {
                        Cy = 0;
                        Cx = 0;
                    }
                    toinenKierros = true;
                }
            }
            else
            {
                if (kohteet.Count == 0 || kaydytKohteet >= kohteet.Count)
                {
                    rutiini = true;
                    pystyVaiVaaka = "enTiia";
                    Console.WriteLine("Takaisin rutiiniin");
                    return;
                }

                Point k = (Point)kohteet[kaydytKohteet];


                osuiko = vihollisMeri.OsuikoLaivat(pnlVihollisMeri, k.X, k.Y);
                aateKartta.asetaPiste(k.X, k.Y);

                kaydytKohteet++;

                if (osuiko == "Osui")
                {
                    if (pystyVaiVaaka == "enTiia")
                    {
                        if (ensimmainenOsuma.X == k.X)
                        {
                            pystyVaiVaaka = "pysty";
                            Console.WriteLine("Laiva on pystyssa");

                            if (ensimmainenOsuma.X > 0)
                                aateKartta.asetaPiste(ensimmainenOsuma.X - 1, ensimmainenOsuma.Y);
                            if (ensimmainenOsuma.X < 9)
                                aateKartta.asetaPiste(ensimmainenOsuma.X + 1, ensimmainenOsuma.Y);

                            if (k.X > 0 && k.X < 9)
                                aateKartta.asetaPiste(k.X + 1, k.Y);
                            if (k.X < 9 && k.X > 0)
                                aateKartta.asetaPiste(k.X - 1, k.Y);

                            kohteet = new ArrayList();
                            kaydytKohteet = 0;

                            if (k.X < 9 && k.X > 0)
                            {
                                if (aateKartta.haePiste(k.X, k.Y + 1) != 2)
                                {
                                    kohteet.Add(new Point(k.X, k.Y + 1));
                                }
                            }
                            if (k.X > 0 && k.X < 9)
                            {
                                if (aateKartta.haePiste(k.X, k.Y - 1) != 2)
                                {
                                    kohteet.Add(new Point(k.X, k.Y - 1));
                                }
                            }

                            if (ensimmainenOsuma.X < 9 && ensimmainenOsuma.X > 0)
                            {
                                if (aateKartta.haePiste(ensimmainenOsuma.X, ensimmainenOsuma.Y + 1) != 2)
                                {
                                    kohteet.Add(new Point(ensimmainenOsuma.X, ensimmainenOsuma.Y + 1));
                                }
                            }
                            if (k.X > 0 && k.X < 9)
                            {
                                if (aateKartta.haePiste(ensimmainenOsuma.X, ensimmainenOsuma.Y - 1) != 2)
                                {
                                    kohteet.Add(new Point(ensimmainenOsuma.X, ensimmainenOsuma.Y - 1));
                                }
                            }
                        }
                        else if (ensimmainenOsuma.Y == k.Y)
                        {
                            pystyVaiVaaka = "vaaka";
                            Console.WriteLine("Laiva on vaa'assa");

                            if (ensimmainenOsuma.Y > 0)
                                aateKartta.asetaPiste(ensimmainenOsuma.X, ensimmainenOsuma.Y - 1);
                            if (ensimmainenOsuma.Y < 9)
                                aateKartta.asetaPiste(ensimmainenOsuma.X, ensimmainenOsuma.Y + 1);

                            if (k.Y > 0)
                                aateKartta.asetaPiste(k.X, k.Y - 1);
                            if (k.Y < 9)
                                aateKartta.asetaPiste(k.X, k.Y + 1);

                            kohteet = new ArrayList();
                            kaydytKohteet = 0;

                            if (k.X < 9)
                            {
                                if (aateKartta.haePiste(k.X + 1, k.Y) != 2)
                                {
                                    kohteet.Add(new Point(k.X + 1, k.Y));
                                }
                            }
                            if (k.X > 0)
                            {
                                if (aateKartta.haePiste(k.X - 1, k.Y) != 2)
                                {
                                    kohteet.Add(new Point(k.X - 1, k.Y));
                                }
                            }
                            if (ensimmainenOsuma.X < 9)
                            {
                                if (aateKartta.haePiste(ensimmainenOsuma.X + 1, ensimmainenOsuma.Y) != 2)
                                {
                                    kohteet.Add(new Point(ensimmainenOsuma.X + 1, ensimmainenOsuma.Y));
                                }
                            }
                            if (ensimmainenOsuma.X > 0)
                            {
                                if (aateKartta.haePiste(ensimmainenOsuma.X - 1, ensimmainenOsuma.Y) != 2)
                                {
                                    kohteet.Add(new Point(ensimmainenOsuma.X - 1, ensimmainenOsuma.Y));
                                }
                            }
                        }
                    }

                    else if(pystyVaiVaaka == "vaaka")
                    {
                        kohteet = new ArrayList();
                        kaydytKohteet = 0;

                        if(k.Y > 0)
                            aateKartta.asetaPiste(k.X, k.Y - 1);
                        if (k.Y < 9)
                            aateKartta.asetaPiste(k.X, k.Y + 1);

                        if (k.X < 9)
                        {
                            if (aateKartta.haePiste(k.X + 1, k.Y) != 2)
                            {
                                kohteet.Add(new Point(k.X + 1, k.Y));
                            }
                        }
                        if (k.X > 0)
                        {
                            if (aateKartta.haePiste(k.X - 1, k.Y) != 2)
                            {
                                kohteet.Add(new Point(k.X - 1, k.Y));
                            }
                        }

                    }
                    else if (pystyVaiVaaka == "pysty")
                    {
                        kohteet = new ArrayList();
                        kaydytKohteet = 0;

                        if (k.X > 0 && k.X < 9)
                            aateKartta.asetaPiste(k.X + 1, k.Y);
                        if (k.X < 9 && k.X > 0)
                            aateKartta.asetaPiste(k.X - 1, k.Y);

                        if (k.Y < 9)
                        {
                            if (aateKartta.haePiste(k.X, k.Y + 1) != 2)
                            {
                                kohteet.Add(new Point(k.X, k.Y + 1));
                            }
                        }
                        if (k.Y > 0)
                        {
                            if (aateKartta.haePiste(k.X, k.Y - 1) != 2)
                            {
                                kohteet.Add(new Point(k.X, k.Y - 1));
                            }
                        }
                    }
                }

                else if (osuiko == "Osui ja upposi!")
                {
                    upotettutLaivat++;
                    rutiini = true;
                    pystyVaiVaaka = "enTiia";
                    if (k.X > 0)
                    {
                        if (aateKartta.haePiste(k.X - 1, k.Y) != 2)
                        {
                            aateKartta.asetaPiste(k.X - 1, k.Y);
                        }
                    }
                    if (k.X < 9)
                    {
                        if (aateKartta.haePiste(k.X + 1, k.Y) != 2)
                        {
                            aateKartta.asetaPiste(k.X + 1, k.Y);
                        }
                    }
                    if (k.Y > 0)
                    {
                        if (aateKartta.haePiste(k.X, k.Y - 1) != 2)
                        {
                            aateKartta.asetaPiste(k.X, k.Y - 1);
                        }
                    }
                    if (k.Y < 9)
                    {
                        if (aateKartta.haePiste(k.X, k.Y + 1) != 2)
                        {
                            aateKartta.asetaPiste(k.X, k.Y + 1);
                        }
                    }
                }
            }
        }

        public void reset()
        {
            kaytettytAmmukset = 0;
            upotettutLaivat = 0;
            Cy = 0;
            Cx = 0;
            rutiini = true;
            aateKartta.LuoAlue();
            RuutiniiAloitus = rnd.Next(0, 1);
            //Cx = RuutiniiAloitus;
        }
    }
}
