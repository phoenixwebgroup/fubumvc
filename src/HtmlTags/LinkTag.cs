namespace HtmlTags
{
	using System;
	using Constants;

	public class LinkTag : HtmlTag
	{
		public LinkTag(string text, string url, params string[] classes)
			: base(HtmlTagConstants.A)
		{
			Text(text);
			Attr("href", url);
			classes.Each(x => AddClass(x));
		}

		public LinkTag()
			: base(HtmlTagConstants.A)
		{
		}

		public LinkTag(Action<HtmlTag> configure)
			: base(HtmlTagConstants.A, configure)
		{
		}

		public LinkTag Href(string address)
		{
			Attr(HtmlAttributeConstants.Href, address);
			return this;
		}

		public LinkTag OnClick(string javascript)
		{
			Attr(JavascriptEventConstants.OnClick, javascript);
			return this;
		}
	}
}