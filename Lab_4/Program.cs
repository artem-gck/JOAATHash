using Lab_4;

const string Hello = "Program for hash data in files .txt files by JOAAT";
const string Hash = "Hash is ";

Console.WriteLine(Hello);

while (true)
{
    Console.WriteLine($"{Hash}{Convert.ToString(await AlgorithmsMethods.JOAATHash(), 16)}");

    Console.WriteLine();
}