using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;


namespace HWCrossBrowser
{ 
   public enum BrowserType
{
    Chrome,
    Firefox,
    IE
}

    [TestFixture]
    public class Hooks : Base
    {
    private BrowserType _browserType;

         public Hooks(BrowserType browser)
        {
            // Driver= new FirefoxDriver();
            _browserType = browser;
        }

        [SetUp]
        public void InicializeTest()
        {
            ChooseBrowser(_browserType);
        }
        public void ChooseBrowser(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowserType.Firefox)
                Driver = new FirefoxDriver();
            else if (browserType == BrowserType.IE)
                Driver = new InternetExplorerDriver();
        }
    }
}
