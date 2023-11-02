open System

let rec factorial n =
    if n <= 1 then 1
    else n * factorial (n - 1)

// Prompt the user for input
Console.Write("Enter a number: ")
let input = Console.ReadLine()

// Parse input and calculate factorial
try
    let n = Int32.Parse(input)
    
    if n < 0 then
        Console.WriteLine("Factorial is not defined for negative numbers.")
    else
        let result = factorial n
        Console.WriteLine($"Factorial of {n} is {result}")
with
| :? System.FormatException ->
    Console.WriteLine("Invalid input. Please enter a valid integer.")
