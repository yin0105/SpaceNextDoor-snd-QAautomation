Feature: UserSelectOptions
	Checking if user can select all sizes,  features and options 

@mytag @regression
Scenario: User selects all sizes and features in Singapore storages
	Given I navigate on "https://stag.spacenextdoor.com/search?location=Singapore&city_id=1" 
	And I select all sizes one by one
	Then I mark all features & amanities

	@regression
Scenario: Select Move in and move out
On search page user selects move in and move out dates

	Given I navigate on "https://stag.spacenextdoor.com/search?location=Singapore&city_id=1" 
	And I select "Move_Out" date on search page
	And I select "Move_In" date on search page
	Then I verify if URL changed accordingly
