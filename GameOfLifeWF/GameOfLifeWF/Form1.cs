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
        string nisse2 = nisse.printArr(testArray);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.
        }
    }
}
