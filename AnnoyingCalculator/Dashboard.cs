using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnoyingCalculator
{
    public partial class Dashboard : Form
    {
        private int _a;
        private int _b;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text != null)
                tempTextBox.Text = sixButton.Text;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            // sa implementez cateva ifuri care spun din ce buton vin
            resultTextBox.Text = oneButton.Text;
        }

        private void substractonButton_Click(object sender, EventArgs e)
        {
            RandomnessGeneratorHelper randGen = new RandomnessGeneratorHelper();

            if (int.TryParse(tempTextBox.Text,out _a) && int.TryParse(resultTextBox.Text, out _b))
            {
                var result = randGen.RandomAnnoy(_a, _b, TypeOfCalculus.Substraction);

                if (result == _a - _b)
                {
                    MessageBox.Show("Oh, you did it!","Nice!");
                }

                resultTextBox.Text = result.ToString();

                tempTextBox.Text = "";
            }
        }
    }
}
