Feature: OtherPurposes
	Achieve OtherPurposes

@mytag @regression @estimator
Scenario: Find a space via Other Purposes 
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Other Purposes button
	And I select some options about storage 
	#And I select another option via search field //this step is bugged and we plan to comment search functionality
	And I click find storage button
	Then I Validate if storage is displayed


@regression
Scenario: Select all items for storage via Other Purposes
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Other Purposes button
	Then I check if all items are clickable

@regression
Scenario: Select items then clear it in other purposes
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Other Purposes button
	And I select some options about storage
	And I verify if est.space "145.15 sqft" displayed correctly 
	And I Clear "2" item from top of the list
	And I verify if est.space "91.35 sqft" displayed correctly
	When I click clear all in list of items popup
	Then I verify that a popup is disabled


