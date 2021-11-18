Feature: Login
	Login functionality 

#@mytag
#Scenario: Log in with valid parameters 
#	Given I am on the Login page
#	When I Enter the valid "sndproject@yahoo.com" Email 
#	And I Mark IAgree checkbox
#	And I Click Login Button
#	And I Check and copy Email verification code
#	And I Input Email verification code into login form
#	And I Click Verify
#	Then The user shoud be logged in and home page shoud be displayed



@regression @smoke @login
Scenario: Signt out confirmation popup
Checking if sign out confirmation popup is displayed after sign out

Given I navigate on "https://stag.spacenextdoor.com" main page
And I log in with hardcoded "87777777" and "222222"
And I sign out
And The popup is displayed with "Are you sure you want to Sign Out?"
And I click "Yes" on popup
Then I am signed out


Scenario: Login with invalid parameters
Checking if error messages displayed correctly 

Given I navigate on "https://stag.spacenextdoor.com" main page
And I navigate on "https://stag.spacenextdoor.com/login"
And I click login button
And I validate if error message "Please enter your email" is displayed 
And I navigate to phone number login
And I click login button
Then I validate if error message "Please enter your phone number" is displayed 