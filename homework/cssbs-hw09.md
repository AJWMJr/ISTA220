# C# Homework 9

#### --AJ McCray

1. a customizable type that can have its values set to a limited amount of symbolic names.

2. enum rank { private = 1, PFC, LanceCorporal, Corporal, Sergeant, StaffSergeant, GunnerySergeant, MasterSeargent, FirstSergeant = MasterSergeant, MasterGunnerySergeant, SergeantMajor = MasterGunnerySergeant } the symbols are named values that also have numerical representations. the default is 0,1,2,3, etc.

3. rank AJ = rank.Corporal; rank friend = rank.Sergeant

4. Console.WriteLine((int)AJ); this will yield 3

5. enum rank : [type]

6. a type similar to a class that has its own fields, methods, and constructors

7. you can not assign a default constructor to a struct. any non-default constructor must initialize all of a struct's fields. you can not declare and assign a value to a variable at the same time in a struct.

8. they are both stored on the stack

9.  Fields: MaxValue, MinValue; Methods: CompareTo, Equals, GetHashCode, GetTypeCode, Parse, ToString, TryFormat, TryParse

10. struct DoD {string Army, Navy, Airforce, Marines; }

11. because the default constructor is always generated automatically

12. CIL stands for common intermmediate language and it is responsible for the intermeiate bytecode that c# compiles into in order to be deployed on any machine. The CLR converts the CIL bytecode into a native language for the local machine
