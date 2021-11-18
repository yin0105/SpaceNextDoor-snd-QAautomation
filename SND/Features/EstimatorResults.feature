Feature: EstimatorResults
	Estimator box search results check

@mytag @estimator @production 
Scenario: Estimator search result on SG
	Given I Navigate to "https://spacenextdoor.com/estimator"
	And I select some options about storage
	And I click find storage button
	When I click clear all filters button
	Then I check if any "Bangkok" site appeared on search page
 