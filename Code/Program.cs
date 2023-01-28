//string[] array = { "hello", "2", "world", ":-)" ,"3"};

Console.WriteLine("Введите элемента массива через запятую");//ввод массива с клавиатуры
string entry = Console.ReadLine() ?? "";
string[] array = entry.Split(",");

int size = 0; //определение размера нового массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        size++;
    }
}

string[] newArray = new string[size]; //определение нового массива

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
Console.Write("[");
Console.Write(string.Join(",", newArray));
Console.Write("]");