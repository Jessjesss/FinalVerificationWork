string[] str = new string[4] {"hey", "2984", "world", "12"};
string[] str2 = new string[str.Length]; 


void Counter(string[] str, string[] str2)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            str2[count] = str[i];
            count++;
        }
    }
}

void PrintArray(string[] str2)
{
    for (int i = 0; i < str2.Length; i++)
    {
        Console.Write($"{str2[i]} ");
    }
}