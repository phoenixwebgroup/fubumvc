namespace HtmlTags
{
	using Constants;

	public class ScriptTag : HtmlTag
	{
		public ScriptTag(string javascript)
			: base(HtmlTagConstants.Script)
		{
			Attr(HtmlAttributeConstants.Type, MimeTypeConstants.Javascript);
			Text(javascript);
			UnEncoded();
		}
	}
}