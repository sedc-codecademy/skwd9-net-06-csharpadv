# MANY EXERCISES

## 1) Create an abstract class Animal and Dog, Cat and Bird classes inheriting it

#### Animal has
* Name
* Age ( custom getter and setter ) - Can't be set below 0 or over 175
* Color
* Print( abstract method ) - Prints all properties of the Animal

#### Dog has
* Race
* Bark ( method ) - Prints BARK BARK in console

#### Cat has
* IsLazy
* Meow ( method ) - Prints MEOW in console

#### Bird has
* IsWild
* FlySouth ( method ) - Print's in the console that is flying south if IsWild is true or print's that it's a domesticated bird if its false

#### Create Lists of:
* 3 dogs
* 3 cats
* 3 birds

#### Use LINQ to:
* Get all dogs of a particular race
* Get the last lazy cat
* Get the all wild birds that are younger than 3 and are ordered by their name

## 2) Create extension methods:
* GetFirstLetter - Method on String that returns the first letter of a string
* LastLetter - Method on String that returns the last letter of a string
* IsEven - Method on Int that checks if its even and returns bool
* GetNfromList - Generic method that accepts an int and returns the first N ( input ) items from that list

## 3) Create generic methods:
* PrintList - Method that prints any list of items in the console ( strings, bools ints etc. )
* PrintAnimals - Method that prints any list with Animals ( print method ) in the console ( Dog, Cat Bird and any Animal )

## 4) Create a delegate that accepts two strings and returns bool
* Create a method called StringMagic that requires the delegate as parameter and that executes the delegate and prints the 2 strings and the result
* Call the StringMagic method to compare 2 strings length
* Call the StringMagic method to compare if the 2 strings start on the same character
* Call the StringMagic method to compare if the 2 strings end on the same character

## 5) Create a publisher class called Trainer that:
* Has delegate that returns void and accepts one string parameter
* Has method SendMessage - Accepts a message and sends it to all subscribers in the event
* Has method ComposeMessage - Accepts 3 parameters, trainerName, groupNumber, message. This method will Thread.Sleep(3000) and then call a method SendMessage with a string that says: {trainerName} informs G{groupNumber}: {message}
* Create 3 Subscriber classes with one method in each that implements the delegate from the publisher
* First subscriber will write that it got the message through SMS
* Second subscriber will write that it got the message through E-Mail
* Third subscriber will write that it got the message through Facebook
* Create instances of the publisher and 3 subscribers and make the publisher send a message to all 3 of them