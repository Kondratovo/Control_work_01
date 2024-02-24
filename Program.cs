
int chars = 3;
string[] arrayOfWords = GetArrayOfWord();
int size = GetCountOfWords(arrayOfWords,chars);
string[] resultArray = GetResultArray(arrayOfWords, size, chars);

string[] GetArrayOfWord() // Функция получения массива слов
{
    Console.WriteLine("Ведите количество слов:");
    int size = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите слова:");
    string[] arrayOfWords = new string[size];
    for (int i = 0; i < size; i++)
    {
        arrayOfWords[i] = Console.ReadLine()!;
    }
    return arrayOfWords;
}

int GetCountOfWords(string[] arrayOfWords, int chars) //Функция получения количества слов с количеством символов меньше или равно chars
{
    int count = 0;
    for (int i = 0; i < arrayOfWords.GetLength(0); i++)
    {
        if (arrayOfWords[i].Length <= chars)
        {
            count++;
        }
    }
    return count;
}

string[] GetResultArray(string[] arrayOfWords, int size, int chars) //Функция получения массива слов с количеством символов меньше или равно chars
{
    string[] resultArray = new string[size];
    int j = 0;
    for (int i = 0; i < arrayOfWords.GetLength(0); i++)
    {
        if (arrayOfWords[i].Length <= chars)
        {
            resultArray[j] = arrayOfWords[i];
            Console.WriteLine(resultArray[j]);
            j++;
        }
    }
    return resultArray;
}