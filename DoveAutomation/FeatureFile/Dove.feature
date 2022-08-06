Feature: Dove
	Automation of Dove Shampoo WebSite

@VerifyShampooText
Scenario: WebSite should search for keyword and should verify the given text
	Given I have navigate to Dove website
	And I have entered Shampoo as search keyword
	When I press the search button
	Then Verify the text "Shampoo"

@VerifyTheRealWomenbText
Scenario: Website should verify The Real Women behind StopTheBeautyTest

     Given Navigate WebSite URL
	 When Click on Discover more
	 Then Verify the text The Real Women behind #StopTheBeautyTest

@VerifyProhibitedUses
Scenario: Website should verify Prohibited Uses in the Terms of Use page
     Given Dove website URL
	 When Click on Terms of use
	 Then Verify Prohibited Uses