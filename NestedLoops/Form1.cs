/*
 * Created by: Jadon Fournier
 * Created on: 11-Apr-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program uses nested loops to show the alphabet
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables
            int counter;
            int counter2;
            string container;
            string container2;

            //clear list
            this.lstList.Items.Clear();

            for (counter = 65; counter <= 90; counter++)
            {
                for (counter2 = 97; counter2 <= 122; counter2++)
                {
                    container = Char.ConvertFromUtf32(counter);
                    container2 = Char.ConvertFromUtf32(counter2);
                    this.lstList.Items.Add(container + "->" + container2);
                }
            }
        }
    }
}
