Feature: UserFlowsUnregistered
	Checking the website functionality for unregistered users

@mytag @UnregisteredUser @regression
Scenario: Book a space with unregistered user
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I search "Singapore" and select it in main search field
	And I Choose "XS" size estimator 
	And I click "First" View All button
	And I click "First" storage unit
	And I click book now button
	And I input following parameters into your details
	| Fullname  | Email          | Phonenumber |
	| lukatest1 | lukatest@g.com | 65123456    |
	And I click reserve unit button
    And I click continue button 
	And I select "Second" insurance plan
	And I click continue button
	And I input card number parameters into payment method
	| CardNumber          | MMYY | CVV |
	| 4242 4242 4242 4242 | 7 22 | 123 |
	When I click pay button
	Then The booking confirmation page should be displayed
	
@mytag @UnregisteredUser @regression
Scenario: Book a space via Home Renovations
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I click Home Renovations button
	And I select some options about storage 
	#And I select another option via search field //this step is bugged and we plan to comment search functionality
	And I click find storage button
	And I Choose "S" size estimator 
	And I click "Second" View All button
	And I click "Second" storage unit
	And I click book now button
	And I input following parameters into your details
	| Fullname  | Email          | Phonenumber |
	| lukatest2 | lukatest@g.com | 65123456    |
	#recheck last added 2 line
	And I click reserve unit button
	And I click continue button 
	And I select "Second" insurance plan
	And I click continue button
	And I input card number parameters into payment method
	| CardNumber          | MMYY | CVV |
	| 4242 4242 4242 4242 | 9 22 | 123 |
	When I click pay button
	Then The booking confirmation page should be displayed



	@mytag @UnregisteredUser @regression
	Scenario:  Self storage license agreement popup
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I search "Singapore" and select it in main search field
	And I Choose "XS" size estimator
	And I click "First" View All button
	And I click "First" storage unit
	And I click book now button
	And I input following parameters into your details
	| Fullname  | Email           | Phonenumber |
	| lukatest1  | lukatest@g.com | 65123456    |
	And I click reserve unit button
	And I click continue button 
	And I select "Second" insurance plan
	And I click continue button
	And I should see the hyperlink Self storage license agreement .
	And I click  Self storage license agreement  hyperlink
	When the popup should be displayed
	Then I click X button to disable