﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_Online
{
    public partial class Form1 : Form
    {
        static public bool isPlayerCross = false;
        static public Bot opponent = new Bot(isPlayerCross);
        public Form1()
        {
            this.Size = new Size(580, 600);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] field = new int[] {
                0, 0, 0, 
                0, 0, 0, 
                0, 0, 0};
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
