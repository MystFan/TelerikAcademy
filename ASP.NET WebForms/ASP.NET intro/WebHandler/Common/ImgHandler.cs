namespace WebHandler.Common
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Drawing.Text;
    using System.Web;

    public class ImgHandler : IHttpHandler
    {
        public ImgHandler()
        {
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;

            string text = request.QueryString.Get("text");
            int textWidth = int.Parse(request.QueryString.Get("width"));
            FontFamily fontFamily = new FontFamily("consolas");
            var font = new Font(fontFamily, 24.5f);
            var color = Color.Black;

            string path = HttpContext.Current.Server.MapPath("~/Images/");
            DrawText(text, font, color, textWidth, path + "text.png");

            HttpResponse response = context.Response;
            response.ContentType = "application/octet-stream";
            response.AppendHeader("Content-Disposition", "attachment; filename=text.png");
            response.TransmitFile(HttpContext.Current.Server.MapPath("~/Images/text.png"));
            response.End();
        }

        public static void DrawText(string text, Font font, Color textColor, int maxWidth, string path)
        {
            Image img = new Bitmap(10, 10);
            Graphics drawing = Graphics.FromImage(img);
            SizeF textSize = drawing.MeasureString(text, font, maxWidth);

            StringFormat sf = new StringFormat();
            sf.Trimming = StringTrimming.Word;
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);
            //Adjust for high quality
            drawing.CompositingQuality = CompositingQuality.HighQuality;
            drawing.InterpolationMode = InterpolationMode.HighQualityBilinear;
            drawing.PixelOffsetMode = PixelOffsetMode.HighQuality;
            drawing.SmoothingMode = SmoothingMode.HighQuality;
            drawing.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            //paint the background
            drawing.Clear(Color.Transparent);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, new RectangleF(0, 0, textSize.Width, textSize.Height), sf);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();
            img.Save(path, ImageFormat.Png);
            img.Dispose();
        }
    }
}