namespace FileComparerWinForms
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

     
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.largeLink = new System.Windows.Forms.LinkLabel();
            this.smallLink = new System.Windows.Forms.LinkLabel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.largePicBox = new System.Windows.Forms.PictureBox();
            this.outputMessage = new System.Windows.Forms.Label();
            this.smallPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).BeginInit();
            this.SuspendLayout();
         

            this.largeLink.AutoSize = true;
            this.largeLink.LinkColor = System.Drawing.Color.Black;
            this.largeLink.Location = new System.Drawing.Point(12, 9);
            this.largeLink.Name = "largeLink";
            this.largeLink.Size = new System.Drawing.Size(104, 13);
            this.largeLink.TabIndex = 0;
            this.largeLink.TabStop = true;
            this.largeLink.Text = "Select original image\r\n";
            this.largeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLarge_Clicked);
            

            this.smallLink.AutoSize = true;
            this.smallLink.LinkColor = System.Drawing.Color.Black;
            this.smallLink.Location = new System.Drawing.Point(12, 42);
            this.smallLink.Name = "smallLink";
            this.smallLink.Size = new System.Drawing.Size(102, 13);
            this.smallLink.TabIndex = 1;
            this.smallLink.TabStop = true;
            this.smallLink.Text = "Select scaled image";
            this.smallLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSmall_Clicked);
  

            this.btnCompare.Location = new System.Drawing.Point(12, 75);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(112, 39);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare images";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.CompareBtn_Click);


            this.fileDialog.FileName = "openFileDialog1";


            this.largePicBox.Location = new System.Drawing.Point(12, 130);
            this.largePicBox.Name = "largePicBox";
            this.largePicBox.Size = new System.Drawing.Size(234, 236);
            this.largePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePicBox.TabIndex = 4;
            this.largePicBox.TabStop = false;


            this.outputMessage.AutoSize = true;
            this.outputMessage.BackColor = System.Drawing.SystemColors.Control;
            this.outputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessage.Location = new System.Drawing.Point(139, 395);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(263, 24);
            this.outputMessage.TabIndex = 5;
            this.outputMessage.Text = "Your result will be shown here";


            this.smallPicBox.Location = new System.Drawing.Point(288, 130);
            this.smallPicBox.Name = "smallPicBox";
            this.smallPicBox.Size = new System.Drawing.Size(237, 236);
            this.smallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smallPicBox.TabIndex = 4;
            this.smallPicBox.TabStop = false;
   

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.smallPicBox);
            this.Controls.Add(this.largePicBox);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.smallLink);
            this.Controls.Add(this.largeLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Compare Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel largeLink;
        private System.Windows.Forms.LinkLabel smallLink;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox largePicBox;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.PictureBox smallPicBox;
    }
}

