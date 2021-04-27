# Calculator Read Me

This calculator was created using Windows Presentation foundation in Visual Studio, using C# as the programming language for the logic in the code behind.

The basic layout of the calculator is seen below with room for further additions to be made as the design and functionality is continually revised and improved.

![Layout](C:\Users\micha\Desktop\Work\Sparta\CalcImages\Layout.png)

This Calculator features the ability to create and store two separate integer numbers and then carry out the operations "Add", "Subtract", "Multiply" and "Divide".

```c#
private static int _num1 = 0;
private static int _num2 = 0;
private static int _num3 = 0;
private static string _operation = "";
private static string _sumFinished = "";

These are the initialized variables at the start of the code behind. _num1 & _num2 are the main numbers used by the calculator method. _operation is assigned when one selects the desired operation. _num3 is assigned after the equals button is push incase one wishes to roll over their value. _sumFinished resets the label to blank when a new number is selected so as not to cause confusion.

_num1 & _num2 are selected by treating the sender to the program as a button and taking the content from said button and parsing it into a string. If either of the numbers are zero it sets the number equal to the content of the sender. If the either of the numbers already have an integer in place it instead concatenates on the number pressed onto the string. The generation can be seen in the code below.

```c#
string addNumber1 = (sender as Button).Content.ToString();
if (_num1 == 0)
{
    _num1 = Int32.Parse(addNumber1);
}
else
{
    string num1 = _num1.ToString();
    num1 = num1 + addNumber1;
    _num1 = Int32.Parse(num1);
}
LabelOutput.Content = _num1;
```

Here one can see that if one was to press the number 1 whilst _num1 was 0 it would initialize _num1 to 1 and then output it to the label. If one was to then press the number 1 again it would recognize that there was already an integer value as part of _num1 and so would concatenate on the second 1 to the existing 1 to create 11.

Once the operator is selected the length of the _operation variable becomes > 0 and as such the program knows to begin assigning the numbers pressed after operation selection to the second number.

```c#
if (_operation.Length != 0)
```

The maximum number possible is restricted by the maximum possible number assigned to an integer value in C#, that being 2,174,483,647 with the minimum number following the same rules down to -2,147,483,648. The creator needs to input an overflow exception into the code as currently if these values are exceeded by an operation it results in a rollover.

The creator did however manage to input the divides by zero exception into the code so that when one attempts to call equals on the division operator whilst _num2 is zero. It instead prints "Error, cannot divide by zero" to the screen instead of the code crashing as seen in the image below.

![DividesbyZero](C:\Users\micha\Desktop\Work\Sparta\CalcImages\DividesbyZero.png)

The red cancel button simply resets all of the initial variables to zero and clears the label of any assigned values.

When one clicks on an operator all that happens is that it assigns the respective symbol to the string _operation. The actual calculator method is not called until the equals button is pressed the method being called by an if statement that analyzes _operation for the symbol called.

```c#
 _sumFinished = "Yes";
if (_operation.Contains("+"))
{
    if (_num1 == 0)
    {
        var answerAdd = Calculator.Add(_num3, _num2);
        LabelOutput.Content = answerAdd;
        _num3 = answerAdd;
    }
    else
    {
        var answerAdd = Calculator.Add(_num1, _num2);
        LabelOutput.Content = answerAdd;
        _num3 = answerAdd;
    }
```

Here one can see the example of the Add method called when one selects the equals button after pressing the addition operator. The first stage is to set the _sumFinished operator to "Yes", so that the label will be clear when new numbers are selected. It then checks if _num1 is 0, this is so that if one wishes to use the number they just calculated for a rolled over operation they can. It then calls the addition method for the two numbers before printing it to the screen and setting the roll over variable to the answer just created.



















