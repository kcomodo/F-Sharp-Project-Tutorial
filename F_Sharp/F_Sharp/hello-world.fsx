open System

type Choice = Rock | Paper | Scissors

let randomChoice =
    let random = Random()
    match random.Next(3) with
    | 0 -> Rock
    | 1 -> Paper
    | _ -> Scissors

let determineWinner playerChoice computerChoice =
    match playerChoice, computerChoice with
    | Rock, Scissors | Paper, Rock | Scissors, Paper -> "Player wins!"
    | Rock, Paper | Paper, Scissors | Scissors, Rock -> "Computer wins!"
    | _ -> "It's a tie!"

let playRockPaperScissors () =
    Console.WriteLine("Welcome to Rock, Paper, Scissors!")

    while true do
        Console.WriteLine("Enter your choice (Rock, Paper, Scissors, or quit to exit):")
        let input = Console.ReadLine()

        match input.ToLower() with
        | "rock" ->
            let playerChoice = Rock
            let computerChoice = randomChoice
            Console.WriteLine($"You chose {playerChoice} and the computer chose {computerChoice}.")
            Console.WriteLine(determineWinner playerChoice computerChoice)
        | "paper" ->
            let playerChoice = Paper
            let computerChoice = randomChoice
            Console.WriteLine($"You chose {playerChoice} and the computer chose {computerChoice}.")
            Console.WriteLine(determineWinner playerChoice computerChoice)
        | "scissors" ->
            let playerChoice = Scissors
            let computerChoice = randomChoice
            Console.WriteLine($"You chose {playerChoice} and the computer chose {computerChoice}.")
            Console.WriteLine(determineWinner playerChoice computerChoice)
        | "quit" ->
            Console.WriteLine("Thanks for playing! Goodbye.")
            Environment.Exit(0)
        | _ ->
            Console.WriteLine("Invalid choice. Please choose Rock, Paper, Scissors, or quit.")

// Call the playRockPaperScissors function to start the game
playRockPaperScissors()
