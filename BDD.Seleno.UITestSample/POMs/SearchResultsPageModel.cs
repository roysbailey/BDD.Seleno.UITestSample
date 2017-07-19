using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace BDD.Seleno.UITestSample.POMs
{
    public class SearchResultsPageModel : Page
    {
        internal bool HasProfileOnPage(string profileTitle)
        {
            var profileLink = Find.Element(By.LinkText("Job profiles"));
            return null != profileLink;
        }
    }
}
