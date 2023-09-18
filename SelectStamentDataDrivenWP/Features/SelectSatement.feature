Feature: SelectSatement

A short summary of the feature

@tag1
Scenario: [Select Statement]
	Given I naviagte to the website "https://demo.automationtesting.in/Register.html"
	And I enter my firstname "Ajibola"
	And I enter last name "Akindele"
	And I enter my address "1 chorley st., Salord, UK"
	And I enter my email address "ajibola50@yahoo.com"
	And I enter my phone number "447450678956"
	And I choose my gender
	And I choose my hobbies
	And I select my language
	And I select my skills 
	And I select my country
	#And I select my secondcountry 
	And I select DOB
	And I select MOB
	And I select YOB
	And I enter my password "Securepassword"
	And I enter my confirm password "Securepassword"
	When I click submit
	#When I click on refresh
	#Then I should be able to register successfully 

