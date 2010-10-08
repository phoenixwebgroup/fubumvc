namespace HtmlTags
{
	using System;
	using System.Text;
	using System.Web;
	using Constants;

	public class ImageTag : HtmlTag
	{
		public ImageTag()
			: base(HtmlTagConstants.Img)
		{
			EncodeInnerText = true;
		}

		public ImageTag Src(string source)
		{
			Attr(HtmlAttributeConstants.Src, source);
			return this;
		}

		public ImageTag Src(string mimetype, byte[] source)
		{
			var base64 = Convert.ToBase64String(source, Base64FormattingOptions.None);
			Attr(HtmlAttributeConstants.Src,
				 string.Format("data:image/{0};base64,{1}", mimetype.ToLower(), HttpUtility.UrlEncode(base64, Encoding.Default)));
			return this;
		}

		public ImageTag Alt(string alt)
		{
			Attr(HtmlAttributeConstants.Alt, alt);
			return this;
		}

		public string Src()
		{
			return Attr(HtmlAttributeConstants.Src);
		}

		public string Alt()
		{
			return HasAttr(HtmlAttributeConstants.Alt) ? Attr(HtmlAttributeConstants.Alt) : "";
		}
	}
}