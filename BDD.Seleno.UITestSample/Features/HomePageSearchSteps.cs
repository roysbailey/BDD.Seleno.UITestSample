using BDD.Seleno.UITestSample.POMs;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace BDD.Seleno.UITestSample.Features
{
    [Binding]
    public class HomePageSearchSteps
    {
        HomePageModel _homePageModel = null;
        SearchPageModel _searchPageModel = null;
        SearchResultsPageModel _searchResultsPageModel = null;


        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            _homePageModel =
                BrowserHost.Instance.NavigateToInitialPage<HomePageModel>(BrowserHost.RootUrl);
        }
        
        [When(@"I click the search profiles link")]
        public void WhenIClickTheSearchProfilesLink()
        {
            _searchPageModel = _homePageModel.NavigateToSearchPage();
        }
        
        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchPhrase)
        {
            _searchResultsPageModel = _searchPageModel.PerformSearch(searchPhrase);
        }

        [Then(@"the application should see the ""(.*)"" profile in the search resutls")]
        public void ThenTheApplicationShouldSeeTheProfileInTheSearchResutls(string profileTitle)
        {
            _searchResultsPageModel.HasProfileOnPage(profileTitle).Should().BeTrue();
        }
    }
}
