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
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void NewUserSetupTest()
		{
			Thread.Sleep(4000);
			app.Tap("edit_text");
			app.Screenshot("Let's start by Tapping on the 'Edit Text' Field");
			Thread.Sleep(4000);
			app.Tap("Sweden");
			app.Screenshot("Then we Tapped on 'Sweden'");
			Thread.Sleep(4000);
			app.Tap("continue_button");
			app.Screenshot("Next we Tapped on the 'Continue' Button");
			Thread.Sleep(4000);

			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.Screenshot("1st Swipe Right to Left");
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.Screenshot("2nd Swipe Right to Left");
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.Screenshot("3rd Swipe Right to Left");
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.SwipeRightToLeft();
			Thread.Sleep(4000);
			app.Screenshot("4th Swipe Right to Left");

			app.Tap("continue_button");
			app.Screenshot("Then we Tapped on the 'Continue' Button");
			app.Tap("enable_button");
			app.Screenshot("Next we Tapped on 'Enable Location'");

			app.Tap("ENABLE NOTIFICATIONS");
			app.Screenshot("Then we Tapped 'Enable Notifcations");
		}

	}
}
