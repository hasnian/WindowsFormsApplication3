using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;

namespace WindowsFormsApplication3
{
    
    public partial class Speech : Form

    {
        SpeechRecognitionEngine speechengine = new SpeechRecognitionEngine();
        bool rec = false;
        public Speech()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            dbclass.InsertTransaction(words.Text);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            speechengine.RecognizeAsyncStop();
            panel2.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<String> str = dbclass.GetTransactions();

            Choices words = new Choices();
            words.Add(str.ToArray());
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(words);
     
            // Create the Grammar instance.
            Grammar g = new Grammar(gb);

            speechengine.LoadGrammarAsync(g);
            speechengine.SetInputToDefaultAudioDevice();

            speechengine.SpeechRecognized += sr_SpeechRecognized;


        }

        void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            List<String> str = dbclass.GetTransactions();
            foreach (RecognizedWordUnit word in e.Result.Words)
            {
                String a = word.ToString();
                if (str.Contains(e.Result.Text))
                {
                 
                    words_box.Text += e.Result.Text;
                }
                else
                {
                    Console.WriteLine(e.Result.Text);
                }


            }
        }


        private void search_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/#q=" + (words_box.Text));

        }

        private void back_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void words_box_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (rec == false)
            {
                speechengine.RecognizeAsync(RecognizeMode.Multiple);
                rec = true;
            }

        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (rec == true)
            {
                speechengine.RecognizeAsyncStop();
                rec = false;
            }
        }
    }
}
