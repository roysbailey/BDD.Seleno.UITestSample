using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace BDD.Seleno.UITestSample.POMs
{
    public class HomePageModel : Page
    {
        internal SearchPageModel NavigateToSearchPage()
        {
            return Navigate.To<SearchPageModel>(By.LinkText("Job profiles"));
        }
    }
}
