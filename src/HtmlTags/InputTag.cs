namespace HtmlTags
{
	using System;
	using Constants;

	public class InputTag : HtmlTag
	{
		public InputTag() : base(HtmlTagConstants.Input)
		{
		}

		public InputTag(Action<HtmlTag> configure) : base(HtmlTagConstants.Input, configure)
		{
		}

		protected InputTag Type(string type)
		{
			Attr(HtmlAttributeConstants.Type, type);
			return this;
		}

		public InputTag Value(string value)
		{
			Attr(HtmlAttributeConstants.Value, value);
			return this;
		}
	}
}