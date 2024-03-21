# DOSS-hands-on9

1."Logger" is for implement below:
Implement a console logger using the singleton design pattern. Your logger should have three levels of reporting,

1. Comment

2. Warning

3. Error

ex. Log(Error, "divide by zero") OR Log(Error, exception.message) will output on the console "Error: divide by zero" or "Error exception occurred some message" and the program will stop. For comments and warnings the program will not stop, however the color of an error message will be red and a warning message will be yellow. Next, re-implement the logger using only static (no singleton). 


2."factory" is for implementation below:

For the given pseudocode:
interface IAnimal
{
    void speak();
}
class Dog : IAnimal
{
    void speak()
    {
        print "woof"
    }
}
class Cat: IAnimal
{
    void speak()
    {
        print "meow"
    }
}
Implement a factory in order to create Dog and Cat Objects. Which factory style did you choose and why?

 
