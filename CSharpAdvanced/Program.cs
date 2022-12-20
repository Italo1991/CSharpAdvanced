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

var test7 = new IList_IEnumerable_ICollection();
test7.Call();

var test8 = new CSharpAdvanced.IQueryable();
test8.Call();

var test9 = new First_Single_FirstOrDefault_SingleOrDefault();
test9.Call();

var test10 = new Array_ArrayList();
test10.Call();

var test11 = new Stack_Queue();
test11.Call();

Console.ReadLine();