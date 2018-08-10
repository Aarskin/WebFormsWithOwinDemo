using System;
using System.Threading;

namespace OwinWebFormSample
{
	public static class Container
	{
		public static AsyncLocal<Guid> AsyncIdentifier { get; set; }
	}
}