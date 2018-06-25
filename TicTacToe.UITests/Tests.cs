using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TicTacToe.UITests
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
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}

		[Test]
		public void PlayGame()
		{
			app.Screenshot("First screen.");

			app.Tap("Square_0");

			app.Screenshot("Play 1.");

			app.Tap("Square_3");

			app.Screenshot("Play 2.");

			app.Tap("Square_4");

			app.Screenshot("Play 3.");

			app.Tap("Square_7");

			app.Screenshot("Play 4.");

			app.Tap("Square_8");

			app.Screenshot("Win dialog up.");
		}
    }
}
