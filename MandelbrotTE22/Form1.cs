namespace MandelbrotTE22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateImage()
        {
            //Skapa ett objekt av v�r egen klass ImageCreator. 
            //Anv�nd samma storlek som v�r PictureBox, dvs 600x600 pixels.
            ImageCreator imageCreator = new ImageCreator(pictureBox1.Width, pictureBox1.Height);
            //Anropa metoden CreateBmpImage() som skapar en bitmap.
            Bitmap bitmap;

            bitmap = imageCreator.CreateBmpImage();

            //Skapa ett grafikobjekt som �r kopplat till v�r PictureBox.
            Graphics graphics = pictureBox1.CreateGraphics();
            //Rita ut bitmapen p� grafikobjektet s� att det syns p� sk�rmen.
            graphics.Clear(Color.Black);
            graphics.DrawImage(bitmap, 0, 0);

        }


        private void buttonDraw_Click(object sender, EventArgs e)
        {
            CreateImage();
        }
    }
}
