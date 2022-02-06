Feature: Restaurant
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


	@mytag
Scenario: Create Order
	Given the number of starter is 4
	And the number of mains is 4
	And the number of drinks is 4
	When no of people arrived is 4
	Then the calculatedBill should be 59.4

	@mytag
Scenario: Create Order before 19:00
	Given the number of starter is 1
	And the number of mains is 2
	And the number of drinks is 2
	When no of people arrived is 2
	Then the calculatedBillbeforeSeven should be 23.65
	
	@mytag
Scenario: Update Order 
	Given the number of starter is 1
	And the number of mains is 2
	And the number of drinks is 2
	When no of people arrived is 2
	Then the calculatedBillbeforeSeven should be 23.65
	And the number of mains after update is 2
	And the number of drinks after update is 2
	Then the updatedBill should be 46.2
	
	@mytag
Scenario: Cancel Order 
	Given the number of starter is 4
	And the number of mains is 4
	And the number of drinks is 4
	When no of people arrived is 4
	Then the calculatedBill should be 59.4
	And the number of starter cancelled is 1
	And the number of mains cancelled is 1
	And the number of drinks cancelled is 1
	Then the finalBill should be 44.55
