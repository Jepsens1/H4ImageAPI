namespace H4ImageAPI
{
    public class ImageToBase64
    {
        List<string> savedImages = new List<string>();
        public string ToBase64()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int numb = random.Next(1, 4);
            string picture = "";
            switch (numb)
            {
                case 1:
                    picture = "deeeneeeey.png";
                    break;
                case 2:
                    picture = "hogg.png";
                    break;
                case 3:
                    picture = "watford.png";
                    break;
            }
            byte[] imageArray = File.ReadAllBytes($"images/{picture}");
            return Convert.ToBase64String(imageArray);
        }
        public string SaveBase64Image(string base64)
        {
            savedImages.Add(base64);
            return "Saved Image";
        }
    }
}
