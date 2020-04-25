using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        List<Button> active = new List<Button>();
        bool exists;
        bool pencil = false;
        Font font1 = new Font("Calibri", 48);
        string ho;
        string difficulty = "";
        List<Button> btnLabels = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hide_level_btn(sender, e);
            pictureBox1.Image = Image.FromFile(@"Sudoku\photos\sudoku_grid.png");
            DefColor(sender, e);
            btnNote.BackColor = default(Color);
        }

        public void DefColor(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name != "btnNote")
                {
                    c.BackColor = default(Color);
                    if (btnLabels.Contains(c))
                    {
                        c.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        c.ForeColor = Color.FromArgb(0, 0, 255);
                    }
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
                    if (btnLabels.Contains(butn)){
                        return;
                    }
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

        private void OpenLevels(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"sudoku\levels\levels.txt");
            List<string> Levels = new List<string> { };
            List<string> Elevels = new List<string> { };
            List<string> Mlevels = new List<string> { };
            List<string> Hlevels = new List<string> { };
            List<string> Exlevels = new List<string> { };
            bool level = false;
            bool easy = false;
            bool medium = false;
            bool hard = false;
            bool expert = false;
            foreach (string line in lines)
            {
                if (level)
                {
                    if (easy)
                    {
                        Elevels.Add(line);
                    }
                    else if (medium)
                    {
                        Mlevels.Add(line);
                    }
                    else if (hard)
                    {
                        Hlevels.Add(line);
                    }
                    else if (expert)
                    {
                        Exlevels.Add(line);
                    }
                    Levels.Add(line);
                    level = false;
                }
                try
                {
                    if (line.Substring(0, 5) == "Level")
                    {
                        level = true;
                    }
                    easy = false;
                    medium = false;
                    hard = false;
                    expert = false;
                    if (line.Substring(9,1) == "0")
                    {
                        easy = true;
                    }
                    else if (line.Substring(9,1) == "1")
                    {
                        medium = true;
                    }
                    else if (line.Substring(9,1) == "2")
                    {
                        hard = true;
                    }
                    else if (line.Substring(9,1) == "3")
                    {
                        expert = true;
                    }

                }
                catch { }
            }

            // In list Levels is loaded all available levels
            /*string ActiveLevel = Levels[1];*/
            string ActiveLevel;
            Random index = new Random();

            if (difficulty == "easy")
            {
                ActiveLevel = Elevels[index.Next(0, Elevels.Count)];
            }
            else if (difficulty == "medium")
            {
                ActiveLevel = Mlevels[index.Next(0, Mlevels.Count)];
            }
            else if (difficulty == "hard")
            {
                ActiveLevel = Hlevels[index.Next(0, Hlevels.Count)];
            }
            else 
            {
                ActiveLevel = Exlevels[index.Next(0, Exlevels.Count)];
            }

            List<string> setup = ActiveLevel.Split(',').ToList();

            sbyte i = 0;
            foreach (Control c in this.Controls)
            {
                Button button = c as Button;
                try
                {
                    c.Text = setup[i];
                    if (c.Text == "0")
                    {
                        c.Text = "";
                    }
                    else
                    {
                        btnLabels.Add(button);
                    }
                    i++;
                }
                catch
                {   
                }
            }
        }
        private void hide_level_btn(object sender, EventArgs e)
        {
            lvl_easy.Visible = false;
            lvl_medium.Visible = false;
            lvl_hard.Visible = false;
            lvl_expert.Visible = false;
            btnNewGame.Visible = true;
            btnNote.Visible = true;
            btn_check.Visible = true;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lvl_easy.Visible = true;
            lvl_medium.Visible = true;
            lvl_hard.Visible = true;
            lvl_expert.Visible = true;
            btnNewGame.Visible = false;
            btnClear.Visible = false;
            btnNote.Visible = false;
            btn_check.Visible = false;
        }

        private void level_button(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Name == "lvl_easy")
            {
                difficulty = "easy";
            }
            else if (button.Name == "lvl_medium")
            {
                difficulty = "medium";
            }
            else if (button.Name == "lvl_hard")
            {
                difficulty = "hard";
            }
            else
            {
                difficulty = "expert";
            }
            hide_level_btn(sender, e);
            OpenLevels(sender, e);
            DefColor(sender, e);
        }
        private void btnNotes(object sender, EventArgs e)
        {
            if (pencil)
            {
                font1 = new Font("Calibri", 48, FontStyle.Bold);
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

        private void btn_check_Click(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"sudoku\levels\Answers.txt");
            List<string> Results = new List<string> { };
            bool level = false;
            foreach (string line in lines)
            {
                if (level)
                {
                    Results.Add(line);
                    level = false;
                }
                try
                {
                    if (line.Substring(0, 5) == "Level")
                    {
                        level = true;
                    }
                }
                catch { }
            }

            // In list Levels is loaded all available levels
            string ActiveLevel = Results[0];
            List<string> Result = ActiveLevel.Split(',').ToList();
            List<string> Answer = new List<string>();
            sbyte k = 1;
            foreach (Control c in this.Controls)
            {
                if (k <= 81)
                {
                    Console.WriteLine(c.Text);
                    Answer.Add(c.Text);
                }
                k++;
            }

            Console.WriteLine("#########");
            Console.WriteLine(Answer.Count);
            Console.WriteLine(Result.Count);

            k = 0;
            bool incorrect = false;
            while(k < 81)
            {
                if (Answer[k] != Result[k])
                {
                    incorrect = true;
                }
                k++;
            }
            if (incorrect)
            {
                MessageBox.Show("There has been mistake");
            }
            else
            {
                MessageBox.Show("Congratulations, No mistakes!");
            }
            
            if (Answer.Equals(Result))
            {
                MessageBox.Show("Congratolations");
            }
        }
    }
}
