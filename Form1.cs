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
        bool pencil = false;
        Font font1 = new Font("Calibri", 48);
        string ho;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Sudoku\photos\sudoku_grid.png");
            DefColor(sender, e);
            Console.WriteLine(r1c1.BackColor);
            btnNote.BackColor = default(Color);
        }

        public void DefColor(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name != "btnNote")
                {
                    c.BackColor = default(Color);
                }
            }
        }


        private void btnKeyDown(object sender, KeyEventArgs e)
        {
            place(sender, e);
        }

        private void place(object sender, KeyEventArgs e)
        {
            if (!pencil)
            {
                foreach (var butn in active)
                {
                    butn.Font = font1;
                    if (e.KeyCode == Keys.D1)
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
                    else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.D0)
                    {
                        butn.Text = "";
                    }
                    else if (e.KeyCode == Keys.Space)
                    {
                        btnNotes(sender, e);
                    }
                }
            }
            else
            {
                foreach(var butn in active)
                {
                    butn.Font = font1;
                    if (e.KeyCode == Keys.D1)
                    {
                        if (butn.Text.Contains("1"))
                        {
                            ho = butn.Text.Replace("1", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "1";
                        }
                    }
                    else if (e.KeyCode == Keys.D2)
                    {
                        if (butn.Text.Contains("2"))
                        {
                            ho = butn.Text.Replace("2", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "2";
                        }
                    }
                    else if (e.KeyCode == Keys.D3)
                    {
                        if (butn.Text.Contains("3"))
                        {
                            string ho = butn.Text.Replace("3", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "3";
                        }
                    }
                    else if (e.KeyCode == Keys.D4)
                    {
                        if (butn.Text.Contains("4"))
                        {
                            string ho = butn.Text.Replace("4", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "4";
                        }
                    }
                    else if (e.KeyCode == Keys.D5)
                    {
                        if (butn.Text.Contains("5"))
                        {
                            string ho = butn.Text.Replace("5", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "5";
                        }
                    }
                    else if (e.KeyCode == Keys.D6)
                    {
                        if (butn.Text.Contains("6"))
                        {
                            string ho = butn.Text.Replace("6", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "6";
                        }
                    }
                    else if (e.KeyCode == Keys.D7)
                    {
                        if (butn.Text.Contains("7"))
                        {
                            string ho = butn.Text.Replace("7", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "7";
                        }
                    }
                    else if (e.KeyCode == Keys.D8)
                    {
                        if (butn.Text.Contains("8"))
                        {
                            string ho = butn.Text.Replace("8", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "8";
                        }
                    }
                    else if (e.KeyCode == Keys.D9)
                    {
                        if (butn.Text.Contains("9"))
                        {
                            string ho = butn.Text.Replace("9", "");
                            butn.Text = ho;
                        }
                        else
                        {
                            butn.Text = butn.Text + "9";
                        }
                    }
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
                    button.BackColor = Color.FromArgb(255, 229, 117);
                }
                
            }
            else
            {
                active.Clear();
                active.Add(button);
                DefColor(sender, e);
                button.BackColor = Color.FromArgb(255, 229, 117);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }

        private void btnNotes(object sender, EventArgs e)
        {
            if (pencil)
            {
                font1 = new Font("Calibri", 48);
                btnNote.BackColor = default(Color);
                pencil = false;
            }
            else
            {   
                font1 = new Font("Calibri", 12);
                btnNote.BackColor = Color.Lime;
                pencil = true;
            }
        }

    }
}
