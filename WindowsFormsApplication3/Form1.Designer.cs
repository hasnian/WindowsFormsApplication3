namespace WindowsFormsApplication3
{
    partial class Speech
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.words = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.words_box = new System.Windows.Forms.TextBox();
            this.toinsert = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.insert);
            this.panel1.Controls.Add(this.words);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 261);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.MaximumSize = new System.Drawing.Size(40, 40);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 40);
            this.back.TabIndex = 2;
            this.back.Text = "<<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // insert
            // 
            this.insert.FlatAppearance.BorderSize = 50;
            this.insert.Location = new System.Drawing.Point(102, 79);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 40);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // words
            // 
            this.words.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.words.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.words.Location = new System.Drawing.Point(23, 145);
            this.words.Multiline = true;
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(236, 78);
            this.words.TabIndex = 0;
            this.words.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.words_box);
            this.panel2.Controls.Add(this.toinsert);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.stop);
            this.panel2.Controls.Add(this.start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 261);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // words_box
            // 
            this.words_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.words_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.words_box.Location = new System.Drawing.Point(23, 69);
            this.words_box.Multiline = true;
            this.words_box.Name = "words_box";
            this.words_box.Size = new System.Drawing.Size(363, 167);
            this.words_box.TabIndex = 4;
            this.words_box.TextChanged += new System.EventHandler(this.words_box_TextChanged);
            // 
            // toinsert
            // 
            this.toinsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toinsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.toinsert.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toinsert.Location = new System.Drawing.Point(0, 0);
            this.toinsert.MaximumSize = new System.Drawing.Size(40, 40);
            this.toinsert.Name = "toinsert";
            this.toinsert.Size = new System.Drawing.Size(36, 40);
            this.toinsert.TabIndex = 3;
            this.toinsert.Text = "<<";
            this.toinsert.UseVisualStyleBackColor = false;
            this.toinsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(295, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 35);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(170, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(71, 35);
            this.stop.TabIndex = 1;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(46, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(71, 35);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Speech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Speech";
            this.Text = "Speech recognizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox words;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button toinsert;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox words_box;
    }
}

