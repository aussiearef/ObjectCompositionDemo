using System;

namespace ObjectComposition.Classes;

internal class Employee : IDisposable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public BankAccount Account { get; set; }

    public void Dispose()
    {
        Account?.Dispose();
    }
}