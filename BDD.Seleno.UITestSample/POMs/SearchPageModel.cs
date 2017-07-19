using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace BDD.Seleno.UITestSample.POMs
{
    public class SearchPageModel : Page
    {
        public SearchResultsPageModel PerformSearch(string searchPhrase)
        {
            var searchBox = Find.Element(By.Id("SearchViewModel_q"));
            searchBox.SendKeys(searchPhrase);
            var searchButton = Find.Element(By.Id("search-button"));
            return Navigate.To<SearchResultsPageModel>(By.Id("search-button"));
        }
    }
}
