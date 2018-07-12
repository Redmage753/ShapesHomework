# ShapesHomework
CSC 260 Objected Oriented Design Homework

Inheritance / Polymorphism
Instructions
Inheritance, Overloading, and Override:

Implement at least three examples of inheritance within the classes you have created for the WebAdvisor program.

Implement at least one distinct example of the following as well with those classes:

-An overloaded function

-A function that uses the override keyword

Operators:

Using the Shapes example from earlier videos/Chapter 1, define the following operators for the Rectangle class, which inherits from the Shape class:

-Less than ( < )

-Less than or equal to ( <= )

-Greater than ( > )

-Greater than or equal to ( >= )

-Equal ( = )

-Not Equal ( != )

-Important note: minimize the duplication of the code needed to define these operators for the Rectangle object

Params keyword and Polymorphism:

-Create a Polygon class that inherits from Shape. This class will handle uncommon shapes that do not fall under common classifications, such as Rectangle, Circle, or Triangle.

-This class will have the fields _numberOfSides and SizeLengths (for example, of type List from System.Collections.Generic.List ), which are defined by a constructor using the params keyword.

-This class will have a Perimeter method defined, which will be overloaded to have a private version and a public static version. The private version should have no parameters and the public version will use the params keyword.

I have included shape-related classes I have been showing in course videos, also if you refer back to Chapter 2 code samples, there is code related to the shapes scenario.
