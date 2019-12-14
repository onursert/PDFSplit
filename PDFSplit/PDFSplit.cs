using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PDFSplit
{
    public partial class PDFSplit : Form
    {
        public PDFSplit()
        {
            InitializeComponent();
        }

        private void buttonSelectPDF_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Select PDF";
            openFileDialog1.Filter = " PDF|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectPDF.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select Location";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxLocation.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            PdfReader reader = new PdfReader(textBoxSelectPDF.Text);
            int number = reader.NumberOfPages;
            int first = Convert.ToInt16(textBoxRange1.Text);
            int last = Convert.ToInt16(textBoxRange2.Text);

            Document document = new Document();
            PdfCopy copy = new PdfCopy(document, new FileStream(textBoxLocation.Text + "//" + "Splitted PDF File " + first + " - " + last + ".pdf", FileMode.Create));

            if (first == 0 && last == 0)
            {
                document.Open();
                for (int i = 1; i <= number; i++)
                {
                    copy.AddPage(copy.GetImportedPage(reader, i));
                }
                document.Close();
            }
            else
            {
                document.Open();
                for (int i = first; i <= last; i++)
                {
                    copy.AddPage(copy.GetImportedPage(reader, i));
                }
                document.Close();
            }

            Process.Start(textBoxLocation.Text);
            progressBar1.Value = 100;
        }

        //Allow only number.
        private void textBoxRange1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxRange2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}