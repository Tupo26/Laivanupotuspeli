using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Periminen2
{
    class ajatusKartta : Alue
    {
        public ajatusKartta()
        {
            LuoAlue();
        }

        public void asetaPiste(int _x, int _y)
        {
            alueData[_y][_x] = 2;
        }
    }
}
