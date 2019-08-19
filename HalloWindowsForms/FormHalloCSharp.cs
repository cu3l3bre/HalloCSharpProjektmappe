using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloWindowsForms
{
    public partial class FormHalloCSharp : Form
    {
        public FormHalloCSharp()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_ShowText_Click(object sender, EventArgs e)
        {
            label_Text.Visible = true;
        }

        private void Button_HideText_Click(object sender, EventArgs e)
        {
            label_Text.Visible = false;
        }

        private void TextBox_Eingabe_TextChanged(object sender, EventArgs e)
        {
            label_Text.Text = textBox_Eingabe.Text;
        }

        private void Button_CountWords_Click(object sender, EventArgs e)
        {
            string[] separators = { " ", "," , "\r\n" };

            string tmpText = textBox_Eingabe.Text;

            string[] numberWords = tmpText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            label_NumberWords.Text = numberWords.Length.ToString();
        }
    }
}
