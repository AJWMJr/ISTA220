# C# Homework 11

#### --AJ McCray

1. a special type of array that allows a method to take a variable amount of parameters

2. methodName(params type arrgs)

3. methodName(firstItems, secondItems, etc)

4. an array would have to be pre-populated

5. an unlimited amount for a param array

6. yes, but this can be circumvented using the object type

7. optional parameters are still limited in number and type and the method is unaware of which parameters are set by default(the compiler) or are provided by the caller. While param arrays provide for truly variable input to methods and parameter array methods know how many arguments were passed by the caller

8. A method that takes objects as parameters

9. public int[] integerMethod(params int[] paramsList) { int sum = 0; foreach (int i in paramsList){sum += i}}

10. static void obMethod(params object[] paramList) {}