using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;

namespace OpenGrade
{
    public partial class FormCutDir : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        public FormCutDir(Form _callingForm)
        {
            //get copy of the calling main form
            mf = _callingForm as FormGPS;

            InitializeComponent();
        }


        private void tboxCutName_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //fill something in
            if (String.IsNullOrEmpty(tboxCutName.Text)) tboxCutName.Text = "XX";
            else
            {

            }

            //append date time to name
            mf.cutName = tboxCutName.Text.Trim() +
                String.Format("{0}", DateTime.Now.ToString(" MMMdd", CultureInfo.InvariantCulture));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}