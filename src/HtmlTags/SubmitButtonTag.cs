namespace HtmlTags
{
	using Constants;

	public class SubmitButtonTag : InputTag
	{
		public SubmitButtonTag()
		{
			Type(InputTypeConstants.Submit);
		}
	}
}