Feature: Account
	Account details flow 

@regression @account @debitCard
Scenario: Edit debit card
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I log in with hardcoded "87777777" and "222222"
	And I navigate to "https://stag.spacenextdoor.com/customer/account"
	And I click edit on payment details debit card field
	And I input the "correct" debit card credentials
	When I click save button
	Then The success message  should be "You have modified your payment method successfully!" displayed


@regression @account @debitCard
Scenario: Edit debit card with invalid parameters
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I log in with hardcoded "87777777" and "222222"
	And I navigate to "https://stag.spacenextdoor.com/customer/account"
	And I click edit on payment details debit card field
	And I input the "incorrect" debit card credentials
	When I click save button
	Then The error message  should be "Your card number is invalid." displayed
	When I input the incorrect expiratioal "20" year
	And I click save button
	Then The error message  should be "Your card's expiration year is in the past." displayed
	And I Input the incorrect expiratioal "07" month
	When I click save button
	Then The error message  should be "Your card's expiration date is in the past." displayed
	And I input only card number without mm/yy cvc
	When I click save button
	Then The error message  should be "Your card's expiration date is incomplete." displayed
	And I dont input CVV code
	When I click save button
	Then The error message  should be "Your card's security code is incomplete." displayed
	

	@regression @account @fullname
	Scenario: Edit full name cancel
	#Given I navigate on "https://stag.spacenextdoor.com" main page
	Given I navigate on "https://dev.spacenextdoor.com/"
	And I log in with hardcoded "67777777" and "111111"
	And I navigate to "https://dev.spacenextdoor.com/customer/account"
	And I save fullname current text
	And I click full name  edit button in accout details
	#ასდასდასდასდ
	When I click cancel button
	Then I validate full name is not changed

	@regression @accoount @fullname
	Scenario: Edit full name save
	#Given I navigate on "https://stag.spacenextdoor.com" main page
	Given I navigate on "https://dev.spacenextdoor.com/"
	And I log in with hardcoded "67777777" and "111111"
	And I navigate to "https://dev.spacenextdoor.com/customer/account"
	And I click full name  edit button in accout details
	#And I save fullname text
	And I clear textfield
	And I input firstname
	And I clear textfield lastname
	And I input lastname
	When I click save button in full and lastname fields
	Then I validate fullname is changed

	@regression @accoount @email
    Scenario:  Edit email
    Given I navigate on "https://dev.spacenextdoor.com/"
	And I log in with hardcoded "67777777" and "111111"
	And I navigate to "https://dev.spacenextdoor.com/customer/account"
	And I click email edit button on accounts page
	And I clear textfield
	And I click email input field
	And I input email
	And I clikc save button in email field
	#When I check email exhists
	Then I validate email is changed
	
	


