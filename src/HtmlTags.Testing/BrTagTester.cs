namespace HtmlTags.Testing
{
	using NUnit.Framework;

	[TestFixture]
	public class BrTagTester
	{
		[Test]
		public void ToString_BrTag_IncludesEndingTag()
		{
			var tag = new BrTag();

			tag.ToString().ShouldEqual("<br></br>");
		}
	}
}