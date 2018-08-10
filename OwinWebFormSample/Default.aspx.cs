using System;
using System.Web.UI;

namespace OwinWebFormSample
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Container.AsyncIdentifier.Value == Guid.Empty)
			{
				throw new Exception("Where is my ID");
			}
		}
	}
}