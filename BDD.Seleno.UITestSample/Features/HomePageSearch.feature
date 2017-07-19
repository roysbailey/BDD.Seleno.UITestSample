@AcceptanceTests
Feature: HomePageSearch

Feature: Home Page Search
	In order to see approprate job profiles
	As a Citizen
	I want to be able to search for job profiles from the home page

Scenario: HomePageSearch - Find plumber when search plumber
	Given I am on the home page
	When I click the search profiles link
	And I search for "plumber"
	Then the application should see the "Plumber" profile in the search resutls


Scenario: HomePageSearch - Find Primary school teacher when search Primary school teacher
	Given I am on the home page
	When I click the search profiles link
	And I search for "Primary school teacher"
	Then the application should see the "Primary school teacher" profile in the search resutls