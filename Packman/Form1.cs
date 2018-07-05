using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packman
{
    public partial class Form1 : Form
    {
        public int leftPos = 12;
        public int topPos = 12;

        public Form1()
        {
            InitializeComponent();

            Crash();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pack.Left += leftPos;
                

               


            }
            else if (e.KeyCode == Keys.Down)
            {
                pack.Top += topPos;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pack.Left -= leftPos;


                if (pack.Left <= obstacles.Left+obstacles.Width)
                {

                    pack.Left = leftPos;
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                pack.Top -= topPos;

                
            }
        }

        public void Crash()
        {
          

        }
    }
}
