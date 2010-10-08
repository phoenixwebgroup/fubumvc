using System.Net.Mime;

namespace FubuMVC.Core.Runtime
{
    public class MimeType
    {
        public static readonly MimeType Html = new MimeType(MediaTypeNames.Text.Html);
        public static readonly MimeType Json = new MimeType("application/json");
        public static readonly MimeType Text = new MimeType(MediaTypeNames.Text.Plain);
		public static readonly MimeType Javascript = new MimeType("text/javascript");
		public static readonly MimeType Css = new MimeType("text/css");
		public static readonly MimeType Png = new MimeType("image/png");
		public static readonly MimeType Gif = new MimeType(MediaTypeNames.Image.Gif);
		public static readonly MimeType Jpeg = new MimeType(MediaTypeNames.Image.Jpeg);
		public static readonly MimeType Tiff = new MimeType(MediaTypeNames.Image.Tiff);
		
        private readonly string _mimeType;

        private MimeType(string mimeType)
        {
            _mimeType = mimeType;
        }

        public override string ToString()
        {
            return _mimeType;
        }
    }
}