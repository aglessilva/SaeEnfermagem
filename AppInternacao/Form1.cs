using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInternacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isCollapsed = true;

        int[] left = { 102, 177, 252, 327, 401 };
        int cont = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pByStep.Left += 3 ;

            if (pByStep.Left >= left[cont])
            {
                pByStep.Left = left[cont];
                timer1.Stop();
                cont++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelDropDown.Height += 10;

                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;

                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void panelDropDown_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = .85;
        }
    }
}
