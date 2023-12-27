Console.WriteLine("Введите числа, разделяя их запятой (для завершения введите отрицательное число):");
string input = Console.ReadLine();
string[] numbers = input.Split(',');

int[] sequence = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    sequence[i] = int.Parse(numbers[i]);
}

int firstNegativeIndex = Array.IndexOf(sequence, Array.Find(sequence, x => x < 0));

for (int i = 0; i < firstNegativeIndex; i++)
{
    if (sequence[i] >= 3 && sequence[i] <= 13)
    {
        Console.WriteLine(sequence[i]);
    }
}