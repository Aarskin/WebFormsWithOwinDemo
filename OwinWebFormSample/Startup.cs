using Microsoft.Owin;
using Owin;
using OwinWebFormSample;

[assembly: OwinStartup(typeof(Startup))]

namespace OwinWebFormSample
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.Use((context, next) =>
			{
				Container.CallId = 5;

				return next.Invoke();
			});
		}
	}
}