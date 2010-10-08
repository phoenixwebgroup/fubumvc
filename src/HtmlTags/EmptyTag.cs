namespace HtmlTags
{
	using Constants;

	public class EmptyTag : HtmlTag
	{
		public EmptyTag()
			: base(HtmlTagConstants.Span)
		{
			Style(HtmlStyleConstants.Display, "hidden");
		}
	}
}