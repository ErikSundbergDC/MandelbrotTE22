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
            //Skapa ett objekt av vår egen klass ImageCreator. 
            //Använd samma storlek som vår PictureBox, dvs 600x600 pixels.
            ImageCreator imageCreator = new ImageCreator(pictureBox1.Width, pictureBox1.Height);
            //Anropa metoden CreateBmpImage() som skapar en bitmap.
            Bitmap bitmap;

            bitmap = imageCreator.CreateBmpImage();

            //Skapa ett grafikobjekt som är kopplat till vår PictureBox.
            Graphics graphics = pictureBox1.CreateGraphics();
            //Rita ut bitmapen på grafikobjektet så att det syns på skärmen.
            graphics.Clear(Color.Black);
            graphics.DrawImage(bitmap, 0, 0);

        }


        private void buttonDraw_Click(object sender, EventArgs e)
        {
            CreateImage();
        }
    }
}
