# C# Homework 8

#### --AJ McCray

1. a deep copy does not copy any reference data instead copying each of the relevant values. while a shallow copy will copy reference data of any reference types within the class.

2. an address on the heap

3. by using any of the value type keywords such as int, char, float, etc

4. by using a class name in the type field which creates a new instance of that class.

5. yes, with use of a '?' attached to the end of the type.

6. no, because the non-nullable value type expects a normal value type.

7. the stack is used for static memory allocation and is assigned during compiling, where as the heap is used for dynamic memory allocation and is assigned during runtime. Furthermore the stack operates in a last in first out sequential order which is why it is useful to think of the the stack as a stack of boxes. In contrast the heap does not operate in an organized manner and any object in the heap can be accessed at anytime randomly.

8. the System.Object class is the parent class to all classes and therefore all classes are more specialized versions of the object class

9. Ref allows operations preformed on a variable(from outside the method) while within a method will persist outside the method 

10. Out passes arguments to a method as a refference type.

11. Boxing is the concept of an object to take and store the value of a value type, and therefore not reference the stack, while Unboxing is taking a value from an object and assigning it to a value type.

12. checks for possibilty of safe conversion of one type to another before executing