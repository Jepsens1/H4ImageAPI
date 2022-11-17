namespace H4ImageAPI
{
    public class ImageToBase64
    {
        public string ToBase64()
        {
            byte[] imageArray = File.ReadAllBytes("images/hogg.jpg");
            return Convert.ToBase64String(imageArray);
        }
    }
}
