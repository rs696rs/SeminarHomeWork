// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, 
// начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

void FindVowelLetter(string[] words)
{
    int count = 0;
    string[] vovel = { "a", "e", "i", "o", "u", "y" };
    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < vovel.Length; j++)
        {
            if (words[i][0] == vovel[j][0]) count++;
        }
    Console.WriteLine("Количество слов в массиве, начинающихся на гласную букву: " + count);

}

string[] words = { "qwe", "wer", "ert", "rty", "tyu", "ouy", "ger", "min", "yes" };


FindVowelLetter(words);




