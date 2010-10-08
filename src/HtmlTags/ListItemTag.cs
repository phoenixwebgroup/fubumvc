namespace HtmlTags
{
	using System;
	using Constants;

	public class ListItemTag : HtmlTag
	{
		public ListItemTag()
			: base(HtmlTagConstants.Li)
		{
		}

		public ListItemTag(Action<HtmlTag> configure)
			: base(HtmlTagConstants.Li, configure)
		{
		}

		public ListItemTag Selected()
		{
			AddClass(HtmlAttributeConstants.Selected);
			return this;
		}
	}
}