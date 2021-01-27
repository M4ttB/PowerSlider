
namespace NewForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createSlideBtn = new System.Windows.Forms.Button();
            this.searchImages_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nxtImage_btn = new System.Windows.Forms.Button();
            this.prevImage_btn = new System.Windows.Forms.Button();
            this.setImage_btn = new System.Windows.Forms.Button();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.bold_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(74, 8);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(227, 23);
            this.titleBox.TabIndex = 0;
            this.titleBox.Text = "Enter Title";
            // 
            // contentBox
            // 
            this.contentBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contentBox.Location = new System.Drawing.Point(74, 46);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(227, 85);
            this.contentBox.TabIndex = 1;
            this.contentBox.Text = "Enter Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contents";
            // 
            // createSlideBtn
            // 
            this.createSlideBtn.Location = new System.Drawing.Point(195, 168);
            this.createSlideBtn.Name = "createSlideBtn";
            this.createSlideBtn.Size = new System.Drawing.Size(106, 26);
            this.createSlideBtn.TabIndex = 4;
            this.createSlideBtn.Text = "Create My Slide";
            this.createSlideBtn.UseVisualStyleBackColor = true;
            this.createSlideBtn.Click += new System.EventHandler(this.createSlideBtn_Click);
            // 
            // searchImages_btn
            // 
            this.searchImages_btn.Location = new System.Drawing.Point(74, 168);
            this.searchImages_btn.Name = "searchImages_btn";
            this.searchImages_btn.Size = new System.Drawing.Size(115, 26);
            this.searchImages_btn.TabIndex = 5;
            this.searchImages_btn.Text = "Search Images";
            this.searchImages_btn.UseVisualStyleBackColor = true;
            this.searchImages_btn.Click += new System.EventHandler(this.searchImages_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(332, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 123);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // nxtImage_btn
            // 
            this.nxtImage_btn.Location = new System.Drawing.Point(522, 161);
            this.nxtImage_btn.Name = "nxtImage_btn";
            this.nxtImage_btn.Size = new System.Drawing.Size(55, 40);
            this.nxtImage_btn.TabIndex = 7;
            this.nxtImage_btn.Text = "Next Image";
            this.nxtImage_btn.UseVisualStyleBackColor = true;
            this.nxtImage_btn.Click += new System.EventHandler(this.nxtImage_btn_Click);
            // 
            // prevImage_btn
            // 
            this.prevImage_btn.Location = new System.Drawing.Point(362, 161);
            this.prevImage_btn.Name = "prevImage_btn";
            this.prevImage_btn.Size = new System.Drawing.Size(75, 40);
            this.prevImage_btn.TabIndex = 8;
            this.prevImage_btn.Text = "Previous Image";
            this.prevImage_btn.UseVisualStyleBackColor = true;
            this.prevImage_btn.Click += new System.EventHandler(this.prevImage_btn_Click);
            // 
            // setImage_btn
            // 
            this.setImage_btn.Location = new System.Drawing.Point(443, 161);
            this.setImage_btn.Name = "setImage_btn";
            this.setImage_btn.Size = new System.Drawing.Size(73, 40);
            this.setImage_btn.TabIndex = 9;
            this.setImage_btn.Text = "Set Image";
            this.setImage_btn.UseVisualStyleBackColor = true;
            this.setImage_btn.Click += new System.EventHandler(this.setImage_btn_Click);
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Location = new System.Drawing.Point(415, 139);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(116, 15);
            this.pictureLabel.TabIndex = 10;
            this.pictureLabel.Text = "Select Loaded Image";
            // 
            // bold_btn
            // 
            this.bold_btn.Location = new System.Drawing.Point(74, 135);
            this.bold_btn.Name = "bold_btn";
            this.bold_btn.Size = new System.Drawing.Size(227, 23);
            this.bold_btn.TabIndex = 11;
            this.bold_btn.Text = "Bold Keyword";
            this.bold_btn.UseVisualStyleBackColor = true;
            this.bold_btn.Click += new System.EventHandler(this.bold_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 206);
            this.Controls.Add(this.bold_btn);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.setImage_btn);
            this.Controls.Add(this.prevImage_btn);
            this.Controls.Add(this.nxtImage_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchImages_btn);
            this.Controls.Add(this.createSlideBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Name = "mainForm";
            this.Text = "PowerSlider";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createSlideBtn;
        private System.Windows.Forms.Button searchImages_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nxtImage_btn;
        private System.Windows.Forms.Button prevImage_btn;
        private System.Windows.Forms.Button setImage_btn;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Button bold_btn;
    }
}

