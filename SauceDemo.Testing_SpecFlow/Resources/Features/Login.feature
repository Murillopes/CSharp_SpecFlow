﻿@Regression
Feature: Login

@Positive
Scenario: Login Successful
	Given I navigate to the Login page
	And Type my <username> and my <password>	
	When I click on the login button
	Then I should navigate to the Home page
	Given I add 2 products from the products page
	When I click on the cart button
	Then I should see the 2 products added to the cart
Examples: 
| username      | password     |
| standard_user | secret_sauce |

@Negative
Scenario: Login Unsuccessful
	Given I navigate to the Login page
	And Type my <username> and my <password>	
	When I click on the login button
	Then I should navigate to the Home page
Examples: 
| username | password |
| murillo  | senha    |
| laryssa  | alves    |

