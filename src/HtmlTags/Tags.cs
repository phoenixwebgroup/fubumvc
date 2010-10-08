namespace HtmlTags
{
	using Constants;

	public class Tags
	{
		public static SelectTag Select
		{
			get
			{
				return new SelectTag();
			}
		}

		public static HtmlTag CssLink(string path)
		{
			return new HtmlTag(HtmlTagConstants.Link)
				.Attr(HtmlAttributeConstants.Type, MimeTypeConstants.Css)
				.Attr(HtmlAttributeConstants.Rel, "stylesheet")
				.Attr(HtmlAttributeConstants.Href, path);
		}

		public static HtmlTag ScriptInclude(string path)
		{
			return new HtmlTag(HtmlTagConstants.Script)
				.Attr(HtmlAttributeConstants.Type, MimeTypeConstants.Javascript)
				.Attr(HtmlAttributeConstants.Src, path);
		}

		public static FormTag Form
		{
			get { return new FormTag(); }
		}

		public static HtmlTag UnorderedList
		{
			get { return new HtmlTag(HtmlTagConstants.Ul); }
		}

		public static NoTag NoTag
		{
			get { return new NoTag(); }
		}

		public static BrTag Br
		{
			get { return new BrTag(); }
		}

		public static InputButtonTag InputButton
		{
			get { return new InputButtonTag(); }
		}

		public static TextboxTag TextBox
		{
			get { return new TextboxTag(); }
		}

		public static HtmlTag Div
		{
			get { return new HtmlTag(HtmlTagConstants.Div); }
		}

		public static HtmlTag Span
		{
			get { return new HtmlTag(HtmlTagConstants.Span); }
		}

		public static LabelTag Label
		{
			get { return new LabelTag(); }
		}

		public static LinkTag Link
		{
			get { return new LinkTag(); }
		}

		public static SubmitButtonTag SubmitButton
		{
			get { return new SubmitButtonTag(); }
		}

		public static InputTag Input
		{
			get { return new InputTag(); }
		}

		public static HiddenTag Hidden
		{
			get { return new HiddenTag(); }
		}

		public static ListItemTag ListItem
		{
			get { return new ListItemTag(); }
		}

		public static HtmlTag SpanText(string text)
		{
			return Span.Text(text);
		}

		public static CheckboxTag Checkbox(bool isSelected)
		{
			return new CheckboxTag(isSelected);
		}

		public static ScriptTag Script(string javascript)
		{
			return new ScriptTag(javascript);
		}

		public static TableTag Table
		{
			get { return new TableTag(); }
		}

		public static ImageTag Image
		{
			get { return new ImageTag(); }
		}

		public static HtmlTag Cell
		{
			get { return new HtmlTag(HtmlTagConstants.Td); }
		}

		public static HtmlTag HeaderCell
		{
			get { return new HtmlTag(HtmlTagConstants.Th); }
		}

		public static BaseTag Base
		{
			get { return new BaseTag(); }
		}

		public static HtmlTag Empty
		{
			get { return new EmptyTag(); }
		}

		public static HtmlTag HtmlTag(params HtmlTag[] bodyTags)
		{
			var body = new HtmlTag(HtmlTagConstants.Body);
			body.ReplaceChildren(bodyTags);
			return new HtmlTag(HtmlTagConstants.Html).Child(body);
		}

		public static HtmlTag HeadingTag(int size)
		{
			return new HtmlTag("h" + size);
		}
	}
}