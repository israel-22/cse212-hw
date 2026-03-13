public static class ComplexStack {
    public static void Run() {

        Console.WriteLine("Test 1");
        Console.WriteLine(DoSomethingComplicated("(a + b)")); // true

        Console.WriteLine("Test 2");
        Console.WriteLine(DoSomethingComplicated("(a + b]")); // false

        Console.WriteLine("Test 3");
        Console.WriteLine(DoSomethingComplicated("((a+b)*c)")); // true

        Console.WriteLine("Test 4");
        Console.WriteLine(DoSomethingComplicated("((a+b)*c")); // false
    }
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}