Feature: ListingPlace
	List your space & choose property

@regression @ListPlace @test
Scenario: Add commercial property 
Given I navigate on "https://stag.spacenextdoor.com" main page
And I log in with hardcoded "87777777" and "222222"
And I select switch to host
And I select "Commercial" in property dropdown
And I select what floor is the space on "7"
And I mark are you listing SND as part of a company? "registered business"
And I click next button in hosting
And I Select "Singapore" in Country/Region dropdown
And I Select "Singapore" in City dropdown
And I select "Geylang" in District dropdown
And I search and select "Geylang, Singapore" in street field
And I input "3" in Flat field
And I input "123777" in Postcode field
And I click next button in hosting
And I click next button in hosting
And I mark all options in features page 
And I click next button in hosting
And I upload photo of storage
And I click next button in hosting
And I input "Penthouse" of my storage
And I click next button in hosting
And I input "description" in describe your place field
And I click next button in hosting
And I input following parameters
	| Width | Depth | Height |
	| 5     | 10    | 2      |
And I verify if Total Area "50" is calculated correctly
And I input Units of the size "5"
And I input Monthly price "1002"
And I mark some options this unit has
And I click next button in hosting
And I click publish button
When I get redirected to listings page
Then I should see "Penthouse" in  Your listings
#
@regression @ListPlace @test
Scenario: Add industrial property as sole owner
Given I navigate on "https://stag.spacenextdoor.com" main page
And I log in with hardcoded "87777777" and "222222"
And I select switch to host
And I select "Industrial" in property dropdown
And I select what floor is the space on "11"
And I mark are you listing SND as part of a company? "individual or sole owner"
And I click next button in hosting
And I Select "Singapore" in Country/Region dropdown
And I Select "Singapore" in City dropdown
And I select "Changi" in District dropdown
And I search and select "Singapore" in street field
And I input "5" in Flat field
And I input "777115" in Postcode field
And I click next button in hosting
And I click next button in hosting
And I mark all options in features page
And I click next button in hosting
And I upload photo of storage
And I click next button in hosting
And I input "Penthouse2" of my storage
And I click next button in hosting
And I input "description" in describe your place field
And I click next button in hosting
And I input following parameters
	| Width | Depth | Height |
	| 3     | 10    | 2      |
And I verify if Total Area "30" is calculated correctly
And I input Units of the size "8"
And I input Monthly price "187"
And I mark some options this unit has
And I click next button in hosting
And I click publish button
When I get redirected to listings page
Then I should see "Penthouse2" in  Your listings
#

@Regression @ListPlace
Scenario: Add residental property as registered business
Given I navigate on "https://stag.spacenextdoor.com" main page
And I log in with hardcoded "87777777" and "222222"
And I select switch to host
And I select "Residental" in property dropdown
And I select what floor is the space on "15"
And I mark are you listing SND as part of a company? "registered business"
And I click next button in hosting
And I Select "Singapore" in Country/Region dropdown
And I Select "Singapore" in City dropdown
And I select "Clementi" in District dropdown
And I search and select "Singapore" in street field
And I input "11" in Flat field
And I input "999999" in Postcode field
And I click next button in hosting
And I click next button in hosting
And I mark all options in features page
And I click next button in hosting
And I upload photo of storage
And I click next button in hosting
And I input "TestStorage11" of my storage
And I click next button in hosting
And I input "description11" in describe your place field
And I click next button in hosting
And I input following parameters
	| Width | Depth | Height |
	| 3     | 10    | 2      |
And I verify if Total Area "30" is calculated correctly
And I input Units of the size "8"
And I input Monthly price "250"
#lets mark all options later
And I mark some options this unit has
And I click next button in hosting
And I click publish button
When I get redirected to listings page
Then I should see "TestStorage11" in  Your listings

