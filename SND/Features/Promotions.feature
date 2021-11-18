Feature: Promotions
	Promotions marking and error messages

@regression 
Scenario Outline: Apply wrong promotion
	Validate error messages for negative conditions

	Given I navigate on "<SiteStorageLink>"
	And I click "First" storage unit
	And I click book now button
	And I select "1year" public promo
	And I select "Move_Out" date in calendar
	And I validate if error message "The promotion cannot be applied to this booking because it does not meeting the minimum criteria" displayed
	And I select "6month" public promo
	And I validate if error message "The promotion cannot be applied to this booking because it does not meeting the minimum criteria" displayed
	And I select "3month" public promo
	And I validate if error message "The promotion cannot be applied to this booking because it does not meeting the minimum criteria" displayed
	And I select "No, I don't need promotion" public promo
	And I Input "incorrect" promo code
	When I click promo apply button 
	Then I validate if error message "Promo code isn't valid or expired" displayed




	#When the two numbers are added
	#Then the result should be 120

	Examples: 
	| SiteStorageLink                                                                                        | 
	| https://stag.spacenextdoor.com/details/120?location=Singapore&city_id=1&total_results=48&space_id=null |  
	| https://stag.spacenextdoor.com/details/123?location=Singapore&city_id=1&total_results=48&space_id=null | 
	                                                                                                   
	