using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace caruselorizontal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while( i < 20){
           
            elementcarusel1.Left -= i;
            elementcarusel2.Left = elementcarusel1.Left + elementcarusel1.Width + 6;
            elementcarusel3.Left = elementcarusel2.Left + elementcarusel2.Width + 6;
            elementcarusel4.Left = elementcarusel3.Left + elementcarusel3.Width + 6;
            elementcarusel5.Left = elementcarusel4.Left + elementcarusel4.Width + 6;
            i+=5;
            Thread.Sleep(100);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while( i < 20){
           
            elementcarusel1.Left += i;
            elementcarusel2.Left = elementcarusel1.Left + elementcarusel1.Width + 6;
            elementcarusel3.Left = elementcarusel2.Left + elementcarusel2.Width + 6;
            elementcarusel4.Left = elementcarusel3.Left + elementcarusel3.Width + 6;
            elementcarusel5.Left = elementcarusel4.Left + elementcarusel4.Width + 6;
            i+=5;
            Thread.Sleep(100);
            }
        }
    }
}
