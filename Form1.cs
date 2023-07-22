using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordShuffle
{
    public partial class Form1 : Form
    {
        List<string> words = new List<string>();
        Button bnPlay = new Button();
        string newText;
        int i = 0, guessed = 0;
        public Form1()
        {
            InitializeComponent();
            lblInfo.Text ="The words loaded in here are marine life names.";
            Setup();
        }

        private void KeyIsPreessed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (words[i].ToLower() == tb1.Text.ToLower())
                {
                    if (i < words.Count - 1)
                    {
                        MessageBox.Show("Correct!", "It was: ");
                        tb1.Clear();
                        i += 1;
                        newText = Shuffle(words[i]);
                        lblWord.Text = newText;
                        lblWc.Text = ("word number: " + (i + 1) + "/" + words.Count);
                        guessed = 0;
                        lblWg.Text = "Guessed: " + guessed + " time/s";
                    }
                    else
                    {
                        lblWord.Text = "Well done!";
                        tb1.Clear();
                        
                        bnPlay.Width = 100;
                        bnPlay.Height = 40;
                        bnPlay.Location = new Point(469, 420);
                        bnPlay.Text = "Play Again";
                        bnPlay.Font = new Font("Impact", 11);
                        bnPlay.BackColor = Color.Indigo;
                        bnPlay.ForeColor = Color.White;
                        bnPlay.Click += new EventHandler(PlayAgain);
                        Controls.Add(bnPlay);

                        return;
                    }
                }
                else 
                {
                    guessed += 1;
                    lblWg.Text = "Guessed: " + guessed + " time/s";
                }
                e.Handled = true;
            }
        }

        private void Setup()
        {
            words = File.ReadLines("words.txt").ToList();
            newText = Shuffle(words[i]);
            lblWord.Text = newText;
            lblWc.Text = ("word number: " +(i+1)+ "/" +words.Count);
        }

        private string Shuffle(string text)
        {
            return new string(text.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        private void PlayAgain(object sender, EventArgs e)
        {
            Controls.Remove(bnPlay);
            guessed = 0;
            lblWg.Text = "Guessed: " + guessed + " time/s";
            i = 0;
            Setup();
           
        }

    }
}
