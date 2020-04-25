using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lvl_easy.Checked == true)
            {
                string level = "easy";
            }
            else if(lvl_medium.Checked == true)
            {
                
            }
            else if (lvl_hard.Checked == true)
            {

            }
            else
            {

            }
        }
    }
}
