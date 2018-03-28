using AForge.Imaging;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileComparerWinForms
{
    public partial class Form1 : Form
    {
        private string original;
        private string scaled;
        private bool pic1;
        private bool pic2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            largePicBox.Visible = false;
            smallPicBox.Visible = false;
            btnCompare.Enabled = false;
            ShowStatus("");
        }

        private void LinkLarge_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select original image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                original = fileDialog.FileName.ToString();
                largeLink.Text = original;
                largePicBox.Image = System.Drawing.Image.FromFile(original);
                largePicBox.Visible = true;
                pic1 = true;
            }
            ValidateSelections();
        }

        private void LinkSmall_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select scaled image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                scaled = fileDialog.FileName.ToString();
                smallLink.Text = scaled;
                smallPicBox.Image = System.Drawing.Image.FromFile(scaled);
                smallPicBox.Visible = true;
                pic2 = true;
            }
            ValidateSelections();
        }

        private void ValidateSelections()
        {
            ShowStatus("");
            if (pic1 && pic2)
            {
                btnCompare.Enabled = true;
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            ShowStatus("Working...");

            Bitmap largeImage = (Bitmap)Bitmap.FromFile(original);
            Bitmap smallImage = (Bitmap)Bitmap.FromFile(scaled);

            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.9f);
            
            TemplateMatch[] matches = tm.ProcessImage(largeImage, smallImage);

            if (matches.Length > 0)
            {
                TemplateMatch match = matches[0];
                ShowStatus("Match found at X: " + 
                    match.Rectangle.Location.X + "; Y:" + 
                    match.Rectangle.Location.Y);
            }
            else
            {
                ShowStatus("Match not found");
            }

        }

        private void ShowStatus(string status)
        {
            outputMessage.Text = status;
            outputMessage.Invalidate();
            outputMessage.Update();
            outputMessage.Refresh();
        }

    }
}
