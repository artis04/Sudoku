namespace Sudoku
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lvl_easy = new System.Windows.Forms.RadioButton();
            this.lvl_medium = new System.Windows.Forms.RadioButton();
            this.lvl_hard = new System.Windows.Forms.RadioButton();
            this.lvl_expert = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvl_easy
            // 
            this.lvl_easy.AutoSize = true;
            this.lvl_easy.Checked = true;
            this.lvl_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_easy.Location = new System.Drawing.Point(19, 60);
            this.lvl_easy.Name = "lvl_easy";
            this.lvl_easy.Size = new System.Drawing.Size(124, 46);
            this.lvl_easy.TabIndex = 0;
            this.lvl_easy.TabStop = true;
            this.lvl_easy.Text = "Easy";
            this.lvl_easy.UseVisualStyleBackColor = true;
            // 
            // lvl_medium
            // 
            this.lvl_medium.AutoSize = true;
            this.lvl_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_medium.Location = new System.Drawing.Point(19, 112);
            this.lvl_medium.Name = "lvl_medium";
            this.lvl_medium.Size = new System.Drawing.Size(174, 46);
            this.lvl_medium.TabIndex = 1;
            this.lvl_medium.Text = "Medium";
            this.lvl_medium.UseVisualStyleBackColor = true;
            // 
            // lvl_hard
            // 
            this.lvl_hard.AutoSize = true;
            this.lvl_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_hard.Location = new System.Drawing.Point(19, 164);
            this.lvl_hard.Name = "lvl_hard";
            this.lvl_hard.Size = new System.Drawing.Size(121, 46);
            this.lvl_hard.TabIndex = 2;
            this.lvl_hard.Text = "Hard";
            this.lvl_hard.UseVisualStyleBackColor = true;
            // 
            // lvl_expert
            // 
            this.lvl_expert.AutoSize = true;
            this.lvl_expert.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_expert.Location = new System.Drawing.Point(19, 216);
            this.lvl_expert.Name = "lvl_expert";
            this.lvl_expert.Size = new System.Drawing.Size(150, 46);
            this.lvl_expert.TabIndex = 3;
            this.lvl_expert.Text = "Expert";
            this.lvl_expert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 185);
            this.button1.TabIndex = 5;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvl_expert);
            this.Controls.Add(this.lvl_hard);
            this.Controls.Add(this.lvl_medium);
            this.Controls.Add(this.lvl_easy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton lvl_easy;
        private System.Windows.Forms.RadioButton lvl_medium;
        private System.Windows.Forms.RadioButton lvl_hard;
        private System.Windows.Forms.RadioButton lvl_expert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}