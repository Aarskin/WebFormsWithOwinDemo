using Microsoft.Owin;
using Owin;
using OwinWebFormSample;
using System;
using System.Threading;

[assembly: OwinStartup(typeof(Startup))]

namespace OwinWebFormSample
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.Use((context, next) =>
			{
				AsyncLocal<Guid> identifier = new AsyncLocal<Guid>();
				identifier.Value = Guid.NewGuid();
				Container.AsyncIdentifier = identifier;

				return next.Invoke();
			});
		}
	}
}