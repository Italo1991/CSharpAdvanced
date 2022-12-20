using CSharpAdvanced;

var test1 = new Override_New();
test1.Call();

var test2 = new Overload();
test2.Call();

var test3 = new AbstractClass_Interface();
test3.Call();

var test4 = new Boxing_Unboxing();
test4.Call();

var test5 = new GarbageCollection();
test5.Call();

var test6 = new TryCatchFinally();
test6.Call();

Console.ReadLine();