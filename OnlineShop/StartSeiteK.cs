﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class StartSeiteK : Form
    {
        public StartSeiteK()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sideBar.Size = new Size(234, 450);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideBar.Size = new Size(72, 450);
        }
    }
}
