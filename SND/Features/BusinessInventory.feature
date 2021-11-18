Feature: BusinessInventory
	Achieve BusinessInventory

@mytag @regression
#standart to standard
Scenario: I Achieve Business Inventory with standart box
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Business Inventory button
	And I click next button
	And I click plus button 3 times
	And I click estimate size button
	And I verify if recommended plan is displayed
	And I click find storage button in Business Inventory
	Then I Validate if storage is displayed

@regression
Scenario: Business Inventory with own box
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Business Inventory button
	And I select My own box
	And I input Width Height Depth parameters in my own box
         | Width | Height | Depth |
         |   99  |   87   |   78  |
	And I click next button
	And I click plus button 2 times
	And I click estimate size button
	And I verify if recommended plan is displayed
	And I click find storage button in Business Inventory
	Then I Validate if storage is displayed

@regression
Scenario: Business Inventory back button functionality
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Business Inventory button
	And I click next button
	And I click plus button 2 times
	And I click go back button
	And I click next button
	And I verify if quantity of boxes is saved
	And I click estimate size button
	And I click go back button
	And I click go back button
	And I select My own box
	And I click next button
	And I verify if quantity of boxes is saved
	And I click estimate size button
	And I click go back button
	And I click go back button
	Then I verify if i am on What kind of box do you need? step


	#//*[@type='number']