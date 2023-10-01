using _005_AsyncAwait;

MyClass myClass = new();

myClass.OperationAsync();

Console.WriteLine("General Thread finish the work ThreadId = {0}", Environment.CurrentManagedThreadId);
Console.ReadLine();
