using System;
using NUnit.Framework;

namespace HWCrossBrowser
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTest : Hooks
    {
     public FirefoxTest() : base(BrowserType.Firefox)
        {

        }

        [Test]
        public void FirefoxEndava()
        {
            Driver.Navigate().GoToUrl("http://www.endava.com/en/");
        }
    }


    [TestFixture]
    [Parallelizable]
    public class ChromeTest : Hooks
    {
        public ChromeTest() : base(BrowserType.Chrome)
        {

        }

        [Test]
        public void ChromeEndava()
        {
            Driver.Navigate().GoToUrl("http://www.endava.com/en/");
        }
    }


    [TestFixture]
    [Parallelizable]
    public class IETest : Hooks
    {
        public IETest() : base(BrowserType.IE)
        {

        }

        [Test]
        public void IEEndava()
        {
            Driver.Navigate().GoToUrl("http://www.endava.com/en/");
        }
    }
}
