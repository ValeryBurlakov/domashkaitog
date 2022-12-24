Console.WriteLine("Здравствуйте. Будем выводить элементы длина которых меньше 4 символов");
Console.WriteLine("введите элементы массива через пробел: ");

string? unit = Console.ReadLine();
string[] elements = unit!.Split(" ");

Console.WriteLine("элементы, где меньше 4 символов:");
int count = 0;
for (int i = 0; i < elements.Length; i++)
{
    if (elements[i].Length <= 3)
    {
        count++;
    }
}

string[] result = new string[count];
int t = 0;

for (int i = 0; i < elements.Length; i++)
{
    if (elements[i].Length <= 3)
    {
        result[t] = elements[i];
        t++;
    }
}

Console.WriteLine("[" + string.Join(", ", result) + "]");