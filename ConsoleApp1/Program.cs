for(var x = 1;x<101;x++) WriteLine($"{(x%3==0 ? "Fizz" : "")}{(x%5==0 ? "Buzz" : "")}{(x%3!=0&&x%5!=0 ? x : "")}");
