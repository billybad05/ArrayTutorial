// See https://aka.ms/new-console-template for more information

int[] scores = new int[3];

Console.Write("Enter 1st Score: ");
string answer1 = Console.ReadLine();
scores[0] = Convert.ToInt32(answer1);

Console.Write("Enter 2nd Score: ");
answer1 = Console.ReadLine();
scores[1] = Convert.ToInt32(answer1);

Console.Write("Enter 3rd Score: ");
answer1 = Console.ReadLine();
scores[2] = Convert.ToInt32(answer1);

int total = scores[0] + scores[1] + scores[2];
Console.WriteLine($"The total of scores {scores[0]}, {scores[1]} and {scores[2]} is {total}");


Console.Write("Guess a number from 1 to 10: ");
string answer = Console.ReadLine();
int myNumber = Convert.ToInt32(answer);
Console.WriteLine($"The Number is {myNumber}");

Console.Write("Enter a string and press Enter: ");
string? response = Console.ReadLine();
Console.WriteLine($"You typed {response}");

// Bpwling Scores
int[] Games = { 145, 264, 244 };
int seriesScore = Games[0] + Games[1] + Games[2];
Console.WriteLine(seriesScore);

// an array of names
string[] Names = { "Billy", "James", "Josh", "Sam", "Karl", "Jack", "Ian", "Caleb" };
Console.WriteLine($"{Names[0]}, {Names[1]}, {Names[2]}, {Names[3]}, {Names[4]}, {Names[5]}, {Names[6]}, {Names[7]}");

// an array in ints
int?[] scores2 = new int?[] { 95, 97, 100, 93, 100 };
Console.WriteLine($"{scores2[0],8:N1}, {scores2[1],5}, {scores2[2],5}, {scores2[3],5}, {scores2[4],5}");

int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 7;
Console.WriteLine($"{scores[0],8:N1}, {scores[1],5}, {scores[2],5}, {scores[3],5}, {scores[4],5}");
