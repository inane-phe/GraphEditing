using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Bitmap> imageList = new List<Bitmap>(); //圖片存在這裡
        private List<Bitmap> originalImageList = new List<Bitmap>();//備份圖片
        private int currentImageIndex = 0;

        private Size defaultImagePicturebox; //記住預設的大小
        private float minScaleFator = 0.1f;
        private float maxScaleFator = 2.0f;
        //畫圖
        private bool isDrawing = false;
        private Point previousPoint;

        private Pen currentPen = new Pen(Color.Black, 2); //初始為黑

        Point originalCenter;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 600;

            colorPicker.BackColor = Color.Black;

            defaultImagePicturebox = imagePicturebox.Size;

            imageGroupBox.MouseWheel += new MouseEventHandler(PictureBox1_MouseWheel);

            originalCenter = new Point(imageGroupBox.Width / 2, imageGroupBox.Height / 2);


        }
        private Bitmap ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(resizedImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, width, height);
            
            return resizedImage;
        }
        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            float scaleFactor = 1.1f;
            float newWidth =    imagePicturebox.Width;
            float newHeight =   imagePicturebox.Height;
            if(e.Delta >0 && newWidth <= originalImageList[currentImageIndex].Width * maxScaleFator && newHeight <= originalImageList[currentImageIndex].Height * maxScaleFator)//delta屬於mouseEvent
            {
                imagePicturebox.Width = (int)(imagePicturebox.Width * scaleFactor);
                imagePicturebox.Height = (int)(imagePicturebox.Height * scaleFactor);
            }
            else if (e.Delta < 0 && newWidth >= originalImageList[currentImageIndex].Width * minScaleFator && newHeight >= originalImageList[currentImageIndex].Height * minScaleFator)
            {
                imagePicturebox.Width = (int)(imagePicturebox.Width / scaleFactor);
                imagePicturebox.Height = (int)(imagePicturebox.Height / scaleFactor);
            }

            imagePicturebox.Left = originalCenter.X - imagePicturebox.Width / 2;
            imagePicturebox.Top = originalCenter.Y - imagePicturebox.Height / 2;

            imagePicturebox.Image = ResizeImage(imageList[currentImageIndex], imagePicturebox.Width, imagePicturebox.Height);

            //強制 imagePicturebox 重新繪製以顯示縮放效果
            imagePicturebox.Invalidate();
        }
        private void LoadImageBtn_Click(object sender, EventArgs e)
        {
            //打開文件對話框以選擇多個圖像文件
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "圖像文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Multiselect = true; //允許多選
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(string fileName in openFileDialog.FileNames)
                    {
                        //讀取所選圖像文件添加到圖片清單中
                        Bitmap newImage = new Bitmap(fileName);
                        imageList.Add(newImage);

                        //備份原來的圖片
                        originalImageList.Add(newImage);
                    }
                    
                }
                //顯示第一張圖片
                currentImageIndex = 0;
                ShowCurrentImage();
            }
        }
        private void ShowCurrentImage()
        {
            if (imageList.Count > 0 && currentImageIndex >= 0 && currentImageIndex < imageList.Count)
            { 
                float widthRatio = (float)imageList[currentImageIndex].Width / defaultImagePicturebox.Width;
                float heightRatio = (float)imageList[currentImageIndex].Height / defaultImagePicturebox.Height;
                float MaxRatio = Math.Max(widthRatio, heightRatio);

                imagePicturebox.Width = (int)(imageList[currentImageIndex].Width / MaxRatio);
                imagePicturebox.Height = (int)(imageList[currentImageIndex].Width / MaxRatio);

                imagePicturebox.Image = ResizeImage(imageList[currentImageIndex], imagePicturebox.Width, imagePicturebox.Height);

                Point originalCenter = new Point(imageGroupBox.Width / 2, imageGroupBox.Height / 2);
                imagePicturebox.Left = originalCenter.X - imagePicturebox.Width / 2;
                imagePicturebox.Top = originalCenter.Y - imagePicturebox.Height / 2;
            }
        }

        private void previousImageBtn_Click(object sender, EventArgs e)
        {
            //切換到上一張圖片
            currentImageIndex--;
            if (currentImageIndex < 0)
            {
                currentImageIndex = imageList.Count - 1;    //循環顯示
            }
            ShowCurrentImage();
        }

        private void nextImsgeBtn_Click(object sender, EventArgs e)
        {
            //切換到下一張圖片
            currentImageIndex++;
            if (currentImageIndex >= imageList.Count)
            {
                currentImageIndex = 0;                      //循環顯示
            }
            ShowCurrentImage();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //存檔
            if (imagePicturebox.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG圖像|*.jpg";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        imagePicturebox.Image.Save(saveFileDialog.FileName);
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (imagePicturebox.Image != null)
            {
                imagePicturebox.Image = originalImageList[currentImageIndex];
                MessageBox.Show("已還原圖片");
            }
        }

        private void flipHorizontalBtn_Click(object sender, EventArgs e)
        {
            if (imagePicturebox.Image != null)
            {
                imagePicturebox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

                imagePicturebox.Image = imagePicturebox.Image;

                imageList[currentImageIndex] = new Bitmap(imagePicturebox.Image);


            }
        }

        private void flipVerticalBtn_Click(object sender, EventArgs e)
        {
            if (imagePicturebox.Image != null)
            {
                imagePicturebox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);

                imagePicturebox.Image = imagePicturebox.Image;

                imageList[currentImageIndex] = new Bitmap(imagePicturebox.Image);
            }
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            //旋轉
            if (imagePicturebox.Image != null)
            {
                imagePicturebox.Image.RotateFlip(RotateFlipType.Rotate90FlipY);

                imagePicturebox.Image = imagePicturebox.Image;

                //把翻轉過來的圖片覆蓋原本的圖片
                imageList[currentImageIndex] = new Bitmap(imagePicturebox.Image);
            }
            ShowCurrentImage();
        }

        private void imagePicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (imagePicturebox.Image != null)
            {
                isDrawing = true;

                //紀錄滑鼠座標
                previousPoint = e.Location;
            }
        }

        private void imagePicturebox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            
        }

        private void imagePicturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && imagePicturebox.Image != null)
            {
                //創建一個新的Bitmap 將圖片複製過去
                Bitmap bitmap = new Bitmap(imagePicturebox.Image);

                //繪製線條
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawLine(currentPen, previousPoint.X, previousPoint.Y, e.X, e.Y);

                //將新的Bitmap設定為PictureBox的圖片
                imagePicturebox.Image = bitmap;

                //更新原來的圖片
                imageList[currentImageIndex] = bitmap;

                //強制 imagePicturebox 重新繪製以顯示線條
                imagePicturebox.Invalidate();

                //紀錄滑鼠座標
                previousPoint = e.Location;
            }
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            if (cD.ShowDialog() == DialogResult.OK)
            {
                colorPicker.BackColor = cD.Color;
            }  

        }
   
        
    
    
    
    }
    }
