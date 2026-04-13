const int MinValue = 1;
const int MaxValue = 100;

Random random = new Random();
int secretNumber = random.Next(MinValue, MaxValue);
int guess = 0;
int attemptCount = 0;

Console.WriteLine($"Welcome to the number guessing game! I have picked a number between {MinValue} and {MaxValue}.");

while (guess != secretNumber) {
    Console.Write("Enter your guess: ");

    if (!int.TryParse(Console.ReadLine(), out guess)) {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }

    attemptCount++;

    if (guess < MinValue || guess > MaxValue) {
        Console.WriteLine($"Please enter a number between {MinValue} and {MaxValue}.");
    } else if (guess < secretNumber) {
        Console.WriteLine("The secret number is higher.");
    } else if (guess > secretNumber) {
        Console.WriteLine("The secret number is lower.");
    } else {
        Console.WriteLine($"Congratulations! You guessed it in {attemptCount} attempts.");
    }
}