using System;
using System.Collections.Generic;

public class CustomerService {
    private List<Customer> _queue = new List<Customer>();
    private int _maxSize;

    public static void Run() {
        // Test Cases
        Console.WriteLine("=================");
        Console.WriteLine("Test 1");
        Console.WriteLine("=================");
        var cs = new CustomerService(3);
        Console.WriteLine(cs);

        Console.WriteLine("=================");
        Console.WriteLine("Test 2");
        Console.WriteLine("=================");
        cs.ServeCustomer(); // should say queue empty

        Console.WriteLine("=================");
        Console.WriteLine("Test 3");
        Console.WriteLine("=================");
        cs.DebugAdd("Alice", "111", "Computer not working");
        cs.DebugAdd("Bob", "222", "Forgot password");
        cs.DebugAdd("Charlie", "333", "Printer jam");
        cs.DebugAdd("David", "444", "Network issue"); // should show queue full
        Console.WriteLine(cs);

        Console.WriteLine("=================");
        Console.WriteLine("Test 4");
        Console.WriteLine("=================");
        cs.ServeCustomer();
        Console.WriteLine(cs);
    }

    public CustomerService(int maxSize) {
        _maxSize = maxSize;
    }

    public void AddNewCustomer() {

        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Customer ID: ");
        string id = Console.ReadLine();

        Console.Write("Problem: ");
        string problem = Console.ReadLine();

        var customer = new Customer(name, id, problem);
        _queue.Add(customer);
    }

    private void ServeCustomer() {

        if (_queue.Count == 0) {
            Console.WriteLine("No customers in queue.");
            return;
        }

        var customer = _queue[0];
        _queue.RemoveAt(0);

        Console.WriteLine(customer);
    }

    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }

    public void DebugAdd(string name, string id, string problem)
    {
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        var customer = new Customer(name, id, problem);
        _queue.Add(customer);
    }
}

public class Customer {
    private string _name;
    private string _id;
    private string _problem;

    public Customer(string name, string id, string problem) {
        _name = name;
        _id = id;
        _problem = problem;
    }

    public override string ToString() {
        return $"{_name} ({_id}) : {_problem}";
    }
}