Feature: Sliders
	Sliding pictures right and left

@mytag @regression
Scenario: Checking if user is able to slide pictures on spaces
	Given I navigate on "https://stag.spacenextdoor.com" main page 
	And I scroll down to features listings
	When I Click all right sliders  "3" times
	Then I click all left sliders "3" times

	@mytag @regression
Scenario: Using slider on details page
	Cover photo sliding
	Given I navigate on "https://stag.spacenextdoor.com/en-US/details/120?location=Singapore&city_id=1"
	And I Click "storage cover" photo
	And I Click "last" thumbnail to slide
	#And I disable cs support chat widget
	And I Slide right "10" times
	And I Slide left "10" times
	And I Close sliding view popup
	And I Click "storage seconday cover" photo
	And I Close sliding view popup
	And I Click "storage small cover" photo
	And I Slide left "4" times
	And I Slide right "2" times
	And I Click "5th" thumbnail to slide
	And I Close sliding view popup
	Then I Validate if "https://stag.spacenextdoor.com/en-US/details/120?location=Singapore&city_id=1" is unchangable after these actions