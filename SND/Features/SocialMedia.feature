Feature: SocialMedia
	Social media link redirections

@mytag @regression
Scenario: Clicking social media buttons and checking redirection target
	Given I navigate on "https://stag.spacenextdoor.com" main page
	And I scroll down to social media buttons
	When I click instagram button 
	Then I check the redirection link "https://www.instagram.com"
	And I click facebook button
	Then I check the redirection link "https://www.facebook.com" 


#Scenario: Clicking WhatsApp media button and checking redireciton target
#	Given I navigate on "https://stag.spacenextdoor.com" main page
# need to check whatapp heree
	