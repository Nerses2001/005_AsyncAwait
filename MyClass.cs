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
            Console.WriteLine("\n Result {0}", await task);
        }
    }
}
