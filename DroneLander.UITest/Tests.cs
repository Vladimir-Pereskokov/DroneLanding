using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DroneLander.UITest
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
        public void SignInAndCheckActivity()
        {
            app.Tap(x => x.Text("Start"));
            app.SetSliderValue(x => x.Class("FormsSeekBar"), 1000);
            System.Threading.Thread.Sleep(2000);
            app.Screenshot("Drone Lander in action");
            app.Tap(x => x.Text("Reset"));
        }
    }
}

