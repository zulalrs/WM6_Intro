﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UcakSavarOyunu.Lib
{
   
    public class Ucak : OyunBase, IHareketEdebilir
    {
        public Ucak(Point point, ContainerControl container) : base(container)
        {
            Resim = new PictureBox()
            {
                Size = new Size(52, 44),
                Image = Properties.Resources.ucak,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = point
            };
            container.Controls.Add(Resim);
        }

        public void HareketE(Yonler yon)
        {
            if (yon == Yonler.Asagi)
            {
                Resim.Location = new Point()
                {
                    X = Resim.Location.X,
                    Y = Resim.Location.Y + 5
                };
            }
            else
                throw new Exception("Ucak sadece asagi hareket edebilir");
        }
    }
}
