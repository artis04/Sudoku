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
    public partial class Form1 : Form
    {
        List<Button> active = new List<Button>();
        bool exists;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Sudoku\photos\sudoku_grid.png");
            Mark(sender, e);
        }

        public void Mark(object sender, EventArgs e)
        {
            r1c1.BackColor = default(Color);
            r1c2.BackColor = default(Color);
            r1c3.BackColor = default(Color);
            r1c4.BackColor = default(Color);
            r1c5.BackColor = default(Color);
            r1c6.BackColor = default(Color);
            r1c7.BackColor = default(Color);
            r1c8.BackColor = default(Color);
            r1c9.BackColor = default(Color);
            r2c1.BackColor = default(Color);
            r2c2.BackColor = default(Color);
            r2c3.BackColor = default(Color);
            r2c4.BackColor = default(Color);
            r2c5.BackColor = default(Color);
            r2c6.BackColor = default(Color);
            r2c7.BackColor = default(Color);
            r2c8.BackColor = default(Color);
            r2c9.BackColor = default(Color);
            r3c1.BackColor = default(Color);
            r3c2.BackColor = default(Color);
            r3c3.BackColor = default(Color);
            r3c4.BackColor = default(Color);
            r3c5.BackColor = default(Color);
            r3c6.BackColor = default(Color);
            r3c7.BackColor = default(Color);
            r3c8.BackColor = default(Color);
            r3c9.BackColor = default(Color);

        }


        private void btnKeyDown(object sender, KeyEventArgs e)
        {
            place(sender, e);
        }

        private void place(object sender, KeyEventArgs e)
        {
            foreach (var butn in active)
            {
                if(e.KeyCode == Keys.D1)
                {
                    butn.Text = "1";
                }
                else if (e.KeyCode == Keys.D2)
                {
                    butn.Text = "2";
                }
                else if (e.KeyCode == Keys.D3)
                {
                    butn.Text = "3";
                }
                else if (e.KeyCode == Keys.D4)
                {
                    butn.Text = "4";
                }
                else if (e.KeyCode == Keys.D5)
                {
                    butn.Text = "5";
                }
                else if (e.KeyCode == Keys.D6)
                {
                    butn.Text = "6";
                }
                else if (e.KeyCode == Keys.D7)
                {
                    butn.Text = "7";
                }
                else if (e.KeyCode == Keys.D8)
                {
                    butn.Text = "8";
                }
                else if (e.KeyCode == Keys.D9)
                {
                    butn.Text = "9";
                }
            }
          


        }


        private void btn_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                exists = active.Contains(button);
                if (exists)
                {
                    active.Remove(button);
                    button.BackColor = default(Color);
                }
                else
                {
                    active.Add(button);
                    button.BackColor = Color.FromArgb(255, 255, 0);
                }
                
            }
            else
            {
                active.Clear();
                active.Add(button);
                Mark(sender, e);
                button.BackColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }
    }
}
