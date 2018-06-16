using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REdit_prototype
{
    public partial class Form1 : Form
    {
        WordObject wordToAdd = new WordObject();
        

        List<WordObject> listOfWords = new List<WordObject>();
        string filepath = @"C:\temp\SerializationTestWindowsForms";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            
            
            wordToAdd.word = txtWord.Text;

            try
            {
                wordToAdd.count = Convert.ToInt32(txtCount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Integer format");
            }

            try
            {
                wordToAdd.dateLastUsed = DateTime.Today;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Date format");
            }
            wordToAdd.grammarType = txtGrammar.Text;

            //Add words to list
            listOfWords.Add(wordToAdd);

            //clear textboxes
            txtWord.Clear();
            txtCount.Clear();
            txtDate.Clear();
            txtGrammar.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayWords_Click(object sender, EventArgs e)
        {
            foreach (WordObject word in listOfWords)
            {
                rtbDisplayWords.AppendText ($"{word.word}\n");
                    //$"{word.word}\n{Convert.ToString(word.count)}\n{word.grammarType}";
            }
        }

        private void rtbDisplayWords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
