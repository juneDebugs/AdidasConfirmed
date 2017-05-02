using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace AdidasConfirmed
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void NewTest()
		{
			app.Tap("edit_text");
			app.Tap("Sweden");
			app.Tap("continue_button");

			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.SwipeRightToLeft();

			app.Tap("continue_button");
			app.Tap("enable_button");

			app.Tap("ENABLE NOTIFICATIONS");
		}

	}
}
