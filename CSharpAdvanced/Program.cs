using CSharpAdvanced;

var test1 = new Override_New();
test1.Call();

var test2 = new Overload();
test2.Call();

var test3 = new AbstractClass_Interface();
test3.Call();

var test4 = new Boxing_Unboxing();
test4.Call();

Console.ReadLine();