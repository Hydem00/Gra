﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Instrukcja : Form
    {
        public Instrukcja()
        {
            InitializeComponent();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
            textBox1.Select();
        }
    }
}
