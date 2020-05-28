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
    public partial class Form1 : Form
    {
        public Pen kyna = new Pen(new SolidBrush(Color.Black), 1);
        public Pen kyna2 = new Pen(new SolidBrush(Color.Red), 3);

        public Alue vihollisMeri = new Alue();
        public Alue omaMeri = new Alue();

        public int leveys;
        public int korkeus;

        public int Ammukset;
        public int laivat = 0;
        public int maxLaivat = 5;

        public int omatLaivat = 1;
        public int suunta = 0;

        public tekoAly vihollinen;

        List<ukko> ukot = new List<ukko>();

        public Form1()
        {
            InitializeComponent();

            vihollisMeri.LuoAlue();
            vihollisMeri.SijoitaLaivat(maxLaivat);

            omaMeri.LuoAlue();

            lblUpotetut.Text = "Upotetut laivat: " + laivat + "/" + maxLaivat;

            vihollinen = new tekoAly(pnlOmaMeri, omaMeri);

            pnlMeri.MouseClick -= pnlMeri_MouseClick;
            pnlMeri.MouseMove -= pnlMeri_MouseMove;
        }

        private void pnlMeri_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = Graphics.FromHwnd(pnlMeri.Handle);
            Graphics g2 = Graphics.FromHwnd(pnlOmaMeri.Handle);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    g1.DrawRectangle(kyna, j * 30, i * 30, 30, 30);
                    g2.DrawRectangle(kyna, j * 30, i * 30, 30, 30);
                }
            }

            g1.Dispose();
            g2.Dispose();
        }

        private void pnlMeri_MouseMove(object sender, MouseEventArgs e)
        {
            leveys = Cursor.Position.X - this.Location.X - pnlMeri.Location.X- 9;
            korkeus = Cursor.Position.Y - this.Location.Y - pnlMeri.Location.Y - 30;
            
            lblKoordinaatit.Text = (leveys/30) + ":" + (korkeus/30);

            //pnlMeri.Refresh();
            /*
            Graphics g = Graphics.FromHwnd(pnlMeri.Handle);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    g.DrawRectangle(kyna, j * 30, i * 30, 30, 30);
                }
            }
            g.DrawRectangle(kyna2, leveys / 30 * 30, korkeus / 30 * 30, 30, 30);
            g.Dispose();
             */
        }

        private void pnlMeri_MouseClick(object sender, MouseEventArgs e)
        {
            lblViesti.Text = vihollisMeri.OsuikoLaivat(pnlMeri, leveys / 30, korkeus / 30);
            if (lblViesti.Text == "Osui ja upposi!")
            {
                laivat++;
                ukot.Add(new ukko(new Point(leveys / 30 * 30, korkeus / 30 * 30)));
            }
            Ammukset++;
            lblAmmo.Text = "Käytettyt ammukset: " + Ammukset;
            lblUpotetut.Text = "Upotetut laivat: " + laivat + "/" + maxLaivat;
            vihollinen.toimi();

            if (laivat == 5)
            {
                MessageBox.Show("Voitto!");
                Reset();
            }
            else if (vihollinen.upotettutLaivat == 5)
            {
                vihollisMeri.PiirraLaivat(pnlMeri);
                MessageBox.Show("Tekoäly voitti!");
                Reset();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            vihollisMeri.LuoAlue();
            omaMeri.LuoAlue();
            vihollisMeri.SijoitaLaivat(maxLaivat);
            laivat = 0;
            Ammukset = 0;
            lblAmmo.Text = "0";
            lblUpotetut.Text = "Upotetut laivat: " + laivat + "/" + maxLaivat;
            ukot = new List<ukko>();
            pnlMeri.Refresh();

            pnlOmaMeri.MouseMove += new MouseEventHandler(pnlOmaMeri_MouseMove);
            pnlOmaMeri.MouseClick += new MouseEventHandler(pnlOmaMeri_MouseClick);
            pnlOmaMeri.Refresh();

            pnlMeri.MouseClick -= pnlMeri_MouseClick;
            pnlMeri.MouseMove -= pnlMeri_MouseMove;

            lblState.Visible = true;
            lblAmmu.Visible = false;
            vihollinen.reset();

            omatLaivat = 1;
        }

        private void Reset()
        {
            vihollisMeri.LuoAlue();
            omaMeri.LuoAlue();
            vihollisMeri.SijoitaLaivat(maxLaivat);
            laivat = 0;
            Ammukset = 0;
            lblAmmo.Text = "0";
            lblUpotetut.Text = "Upotetut laivat: " + laivat + "/" + maxLaivat;
            ukot = new List<ukko>();
            pnlMeri.Refresh();

            pnlOmaMeri.MouseMove += new MouseEventHandler(pnlOmaMeri_MouseMove);
            pnlOmaMeri.MouseClick += new MouseEventHandler(pnlOmaMeri_MouseClick);
            pnlOmaMeri.Refresh();

            pnlMeri.MouseClick -= pnlMeri_MouseClick;
            pnlMeri.MouseMove -= pnlMeri_MouseMove;

            lblState.Visible = true;
            lblAmmu.Visible = false;
            vihollinen.reset();

            omatLaivat = 1;
        }

        private void tmrAnimaatio_Tick(object sender, EventArgs e)
        {
            if (ukot == null)
                return;
            Graphics gr = Graphics.FromHwnd(pnlMeri.Handle);

            foreach(ukko u in ukot)
            {
                gr.DrawImage(u.anim[u.animLsk], u.loc);
                u.Animoi();
            }

            gr.Dispose();
        }

        private void pnlOmaMeri_MouseMove(object sender, MouseEventArgs e)
        {
            pnlOmaMeri.Refresh();
            Graphics g = Graphics.FromHwnd(pnlOmaMeri.Handle);
            
            for (int i = 0; i < 11; i++)
            {
                g.DrawLine(kyna, 0, i * 30, 300, i * 30);
                g.DrawLine(kyna, i * 30, 0, i * 30, 300);
            }
            if(suunta == 0)
                g.DrawRectangle(kyna2, e.X / 30 * (30), e.Y / 30 * 30, 30 * omatLaivat, 30);
            else
                g.DrawRectangle(kyna2, e.X / 30 * (30), e.Y / 30 * 30, 30, 30 * omatLaivat);
            g.Dispose();

            leveys = Cursor.Position.X - this.Location.X - pnlOmaMeri.Location.X - 9;
            korkeus = Cursor.Position.Y - this.Location.Y - pnlOmaMeri.Location.Y - 30;

            omaMeri.PiirraLaivat(pnlOmaMeri);
        }

        private void pnlOmaMeri_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (suunta == 0)
                    suunta = 1;
                else
                    suunta = 0;
            }
            else
            {
                if (!omaMeri.sijoitaLaivaCoor(leveys / 30, korkeus / 30, omatLaivat, suunta, pnlOmaMeri))
                    return;
                omatLaivat++;
                if (omatLaivat == 6)
                {
                    pnlOmaMeri.MouseMove -= new MouseEventHandler(pnlOmaMeri_MouseMove);
                    pnlOmaMeri.MouseClick -= new MouseEventHandler(pnlOmaMeri_MouseClick);
                    pnlOmaMeri.Refresh();

                    pnlMeri.MouseClick += pnlMeri_MouseClick;
                    pnlMeri.MouseMove += pnlMeri_MouseMove;

                    lblState.Visible = false;
                    lblAmmu.Visible = true;

                    omaMeri.PiirraLaivat(pnlOmaMeri);

                    Graphics g = Graphics.FromHwnd(pnlOmaMeri.Handle);

                    for (int i = 0; i < 11; i++)
                    {
                        g.DrawLine(kyna, 0, i * 30, 300, i * 30);
                        g.DrawLine(kyna, i * 30, 0, i * 30, 300);
                    }

                    g.Dispose();
                }
            }
        }
    }
}
