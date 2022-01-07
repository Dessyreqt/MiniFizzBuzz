foreach (var x in Range(1, 100)) { WriteLine($"{(x % 3 == 0 ? "Fizz" : "")}{(x % 5 == 0 ? "Buzz" : "")}{(x % 3 != 0 && x % 5 != 0 ? x : "")}"); }
