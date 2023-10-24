namespace GraphEditing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.flipHorizontalBtn = new System.Windows.Forms.Button();
            this.flipVerticalBtn = new System.Windows.Forms.Button();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.cD = new System.Windows.Forms.ColorDialog();
            this.previousImageBtn = new System.Windows.Forms.Button();
            this.nextImsgeBtn = new System.Windows.Forms.Button();
            this.imagePicturebox = new System.Windows.Forms.PictureBox();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).BeginInit();
            this.imageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.Location = new System.Drawing.Point(174, 60);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(85, 23);
            this.LoadImageBtn.TabIndex = 0;
            this.LoadImageBtn.Text = "Load Image";
            this.LoadImageBtn.UseVisualStyleBackColor = true;
            this.LoadImageBtn.Click += new System.EventHandler(this.LoadImageBtn_Click);
            // 
            // flipHorizontalBtn
            // 
            this.flipHorizontalBtn.Location = new System.Drawing.Point(174, 89);
            this.flipHorizontalBtn.Name = "flipHorizontalBtn";
            this.flipHorizontalBtn.Size = new System.Drawing.Size(85, 23);
            this.flipHorizontalBtn.TabIndex = 1;
            this.flipHorizontalBtn.Text = "flip Horizontal";
            this.flipHorizontalBtn.UseVisualStyleBackColor = true;
            this.flipHorizontalBtn.Click += new System.EventHandler(this.flipHorizontalBtn_Click);
            // 
            // flipVerticalBtn
            // 
            this.flipVerticalBtn.Location = new System.Drawing.Point(174, 118);
            this.flipVerticalBtn.Name = "flipVerticalBtn";
            this.flipVerticalBtn.Size = new System.Drawing.Size(85, 23);
            this.flipVerticalBtn.TabIndex = 2;
            this.flipVerticalBtn.Text = "flip Vertical";
            this.flipVerticalBtn.UseVisualStyleBackColor = true;
            this.flipVerticalBtn.Click += new System.EventHandler(this.flipVerticalBtn_Click);
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(174, 147);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(85, 23);
            this.rotateBtn.TabIndex = 3;
            this.rotateBtn.Text = "rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 362);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(174, 244);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(85, 76);
            this.colorPicker.TabIndex = 5;
            this.colorPicker.TabStop = false;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // previousImageBtn
            // 
            this.previousImageBtn.Location = new System.Drawing.Point(69, 476);
            this.previousImageBtn.Name = "previousImageBtn";
            this.previousImageBtn.Size = new System.Drawing.Size(75, 23);
            this.previousImageBtn.TabIndex = 6;
            this.previousImageBtn.Text = "previous";
            this.previousImageBtn.UseVisualStyleBackColor = true;
            this.previousImageBtn.Click += new System.EventHandler(this.previousImageBtn_Click);
            // 
            // nextImsgeBtn
            // 
            this.nextImsgeBtn.Location = new System.Drawing.Point(438, 476);
            this.nextImsgeBtn.Name = "nextImsgeBtn";
            this.nextImsgeBtn.Size = new System.Drawing.Size(75, 23);
            this.nextImsgeBtn.TabIndex = 7;
            this.nextImsgeBtn.Text = "next";
            this.nextImsgeBtn.UseVisualStyleBackColor = true;
            this.nextImsgeBtn.Click += new System.EventHandler(this.nextImsgeBtn_Click);
            // 
            // imagePicturebox
            // 
            this.imagePicturebox.Location = new System.Drawing.Point(69, 21);
            this.imagePicturebox.Name = "imagePicturebox";
            this.imagePicturebox.Size = new System.Drawing.Size(444, 340);
            this.imagePicturebox.TabIndex = 8;
            this.imagePicturebox.TabStop = false;
            this.imagePicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePicturebox_MouseDown);
            this.imagePicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePicturebox_MouseMove);
            this.imagePicturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagePicturebox_MouseUp);
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.imagePicturebox);
            this.imageGroupBox.Controls.Add(this.nextImsgeBtn);
            this.imageGroupBox.Controls.Add(this.previousImageBtn);
            this.imageGroupBox.Location = new System.Drawing.Point(298, 24);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(592, 515);
            this.imageGroupBox.TabIndex = 9;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "groupBox1";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(207, 176);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "pen color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.flipVerticalBtn);
            this.Controls.Add(this.flipHorizontalBtn);
            this.Controls.Add(this.LoadImageBtn);
            this.Controls.Add(this.imageGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).EndInit();
            this.imageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageBtn;
        private System.Windows.Forms.Button flipHorizontalBtn;
        private System.Windows.Forms.Button flipVerticalBtn;
        private System.Windows.Forms.Button rotateBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.ColorDialog cD;
        private System.Windows.Forms.Button previousImageBtn;
        private System.Windows.Forms.Button nextImsgeBtn;
        private System.Windows.Forms.PictureBox imagePicturebox;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
    }
}

