//Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}


string[] CombiningWords(string[] words)
{
    string[] combining = new string[words.Length / 2];
    int j = 0;
    for (int i = 0; i <= words.Length - 2; i = i + 2)
    {
        combining[j] = words[i] + words[i + 1];
        j++;
    }
    return combining;
}

void PrintWords(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        Console.Write(words[i] + " ");
    }
    Console.WriteLine();
}

string[] words = { "Доб", "рый", "ве", "чер", "Па", "вел,", "без ", "ваших", "семи", "наров", "ску", "чно!" };

string[] NewWords = CombiningWords(words);

PrintWords(NewWords);
