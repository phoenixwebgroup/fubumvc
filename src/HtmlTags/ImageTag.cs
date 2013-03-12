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

		/// <summary>
		/// Gets an image tag with Base64 encoding.
		/// </summary>
		/// <param name="mimetype">MIME Type of the image. If the supplied value does not have a slash ("/"), then the mimetype will be prepended with "image/" in the returned tag</param>
		/// <param name="source">Contents of the image</param>
		/// <returns>Returns an image tag with the image contents encoded in Base64</returns>
		public ImageTag Src(string mimetype, byte[] source)
		{
			var base64 = Convert.ToBase64String(source, Base64FormattingOptions.None);
			var imagePrefix = mimetype.Contains("/") ? string.Empty : "image/";
			Attr(HtmlAttributeConstants.Src,string.Format("data:{0}{1};base64,{2}", imagePrefix, mimetype.ToLower(), HttpUtility.UrlEncode(base64, Encoding.Default)));
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