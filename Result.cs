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
    public partial class Result : Form
    {

        public Result(List<TextBox> dataTextBoxes)
        {
            InitializeComponent();


            foreach (TextBox tb in dataTextBoxes)
            {
                switch (tb.Name)
                {
                    case "textBoxFirstName":
                        labelFirstNameResult.Text = tb.Text;
                        break;
                    case "textBoxLastName":
                        labelLastNameResult.Text = tb.Text;
                        break;
                    case "textBoxAddress":
                        labelAddressResult.Text = tb.Text;
                        break;
                    case "textBoxPhoneNumber":
                        labelPhoneNumberResult.Text = tb.Text;
                        break;
                    default:
                        throw new System.FormatException("Not know textBox: " + tb.Name);

                }


            }


        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
