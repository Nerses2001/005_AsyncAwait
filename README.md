# 005_AsyncAwait
## Asynchronous Programming with C#

This repository contains a simple example of asynchronous operation in C# using `async/await`.

## Code Example

```csharp
namespace _005_AsyncAwait
{
    internal class MyClass
    {
        int Operation()
        {
            Console.WriteLine("Operation in Thread Id = {0}", Environment.CurrentManagedThreadId);

            return 2 + 2;
        }

        public async void OperationAsync()
        {
            Task<int> task = Task<int>.Factory.StartNew(Operation);
            Console.WriteLine("\nResult {0}", await task);
        }
    }
}

using _005_AsyncAwait;

MyClass myClass = new();

myClass.OperationAsync();

Console.WriteLine("General Thread finish the work ThreadId = {0}", Environment.CurrentManagedThreadId);
Console.ReadLine();
```
In the provided code, `MyClass` contains the `Operation` method that performs some operation and returns a result. `OperationAsync` uses `async/await` to execute `Operation` asynchronously.

To initiate an asynchronous operation, `Task<int>.Factory.StartNew` is used to run `Operation` on a separate thread and return the result as a `Task<int>` object.

## Description

- `Operation`: A method that performs an operation (in this case, adding 2 and 2).
- `OperationAsync`: An asynchronous method that asynchronously runs `Operation` and prints the result.
