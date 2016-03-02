using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeWF
{
    public partial class Form1 : Form
    {
        Board nisse = new Board();
        int[,] testArray = new int[20, 75];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nisse2 = nisse.printArr(testArray);
            textBox2.Text = nisse2;
        }
    }
}
