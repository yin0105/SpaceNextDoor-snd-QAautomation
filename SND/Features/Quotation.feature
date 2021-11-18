Feature: Quotation
	Get a quotation flows

@mytag @regression
Scenario: Get a quote via details page
	Given I navigate on "https://stag.spacenextdoor.com/en-US/details/121?location=Singapore&city_id=1"
	And I click Get a quote button 
	And I select "XS" size estimator
	And I click What's fit in this size
	And I use sliders on displayed popup
	And I click select button
	And I click next button in quotation
	And I use calendar sliders
	And I click next button in quotation
	And I input Full name 
	And I Input Email
	And I Input phone number "65123456"
	And I click Get a quote  last button 
	And I should be redirected to back to home page 
	When I click back to homepage button
	Then I should be redirected to main homepage