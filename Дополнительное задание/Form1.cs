﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дополнительное_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0 до 255");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -128 до 127");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -32768 до +32767");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0 до 65535");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -2147483648 до +2147483647");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0u до 4294967295U");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от -9223372036854775808L до +9223372036854775807L");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон от 0ul до 8446744073709551615UL");
        }
    }
}
