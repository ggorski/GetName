using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetData
{



    public partial class FormMain : Form
    {
        private List<TextBox> dataTextBoxes;
        private int step = 0;

        public FormMain()
        {

            InitializeComponent();


            dataTextBoxes = tableLayoutPanelData.Controls.OfType<TextBox>().ToList();
            dataTextBoxes.Reverse();

            dataTextBoxes[0].Select();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            --step;

            if (step < 1)
            {
                buttonBack.Enabled = false;

            }

            buttonNext.Enabled = true;
            buttonNext.Text = "Next > ";


            dataTextBoxes[step + 1].Enabled = false;
            dataTextBoxes[step].Enabled = true;
            dataTextBoxes[step].Select();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            ++step;

            if (step > dataTextBoxes.Count - 2)
            {
                // TODO message box
                buttonNext.Text = "Result";

            }
            if (step > dataTextBoxes.Count - 1)
            {
                --step;
                try
                {
                    Result result = new Result(dataTextBoxes);
                    result.Show();
                }
                catch (System.FormatException ex)
                {
                    Console.Write("ERROR: " + ex.Message);
                    System.Environment.Exit(1);
                }

            }
            else
            {
                buttonBack.Enabled = true;

                dataTextBoxes[step - 1].Enabled = false;
                dataTextBoxes[step].Enabled = true;
                dataTextBoxes[step].Select();
            }
        }

        private void dataTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonNext_Click(sender, e);
            }
        }
    }
}
