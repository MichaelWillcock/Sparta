Feature: CalculatorFeature
	Simple calculator that takes two numbers

@mytag
Scenario: Add
	Given I have a calculator
	And I enter 5 and 2 into the calculator
	When I press add
	Then the result should be 7

@mytag
Scenario: Subtract
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press subtract
	Then the result should be <result>
	Examples: 
	| input1 | input2 | result |
	| 1      | 1      | 0      |
	| 0      | 1      | -1     |
	| 1000   | 1      | 999    |


@mytag
Scenario: Multiply
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press muliply
	Then the result should be <result>
	Examples: 
	| input1 | input2 | result |
	| 1      | 1      | 1      |
	| 2      | 3      | 6      |

@mytag
Scenario: Divide
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press divide
	Then the result should be <result>
	Examples: 
	| input1 | input2 | result |
	| 1      | 1      | 1      |
	| 6      | 2      | 3      |

@mytag
Scenario: Divide By Zero
	Given I have a calculator
	And I enter <input1> and 0 into the calculator
	Then a DivideByZero Exception should be thrown with the exception message "Cannot Divide By Zero" when I press divide
	Examples:
	| input1 | 
	| 1      | 
	| 6      | 

#Divide by zero

@mytag
Scenario: SumOfNumbersDivisibleBy2
	Given I have a calculator
	And I enter the numbers below to a list
	| nums |
	| 1    |
	| 2    |
	| 3    |
	| 4    |
	| 5    |
	When I iterate through the list to add all the even numbers
	Then the result should be 6
