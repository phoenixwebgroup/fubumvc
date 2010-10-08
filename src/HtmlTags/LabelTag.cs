namespace HtmlTags
{
	using System;
	using Constants;

	public class LabelTag : HtmlTag
	{
		public LabelTag()
			: base(HtmlTagConstants.Label)
		{
		}

		public LabelTag(Action<HtmlTag> configure)
			: base(HtmlTagConstants.Label, configure)
		{
		}

		public LabelTag For(string id)
		{
			Attr(HtmlAttributeConstants.For, id);
			return this;
		}
	}
}