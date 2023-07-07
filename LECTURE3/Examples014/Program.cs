﻿// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с"
Console.Clear();
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


//string s = "qwerty"
//            012345
// s[3] // "r"


string RepLace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newtext = RepLace(text, ' ', '_');
System.Console.WriteLine(newtext);
System.Console.WriteLine();
newtext = RepLace(newtext, 'к', 'К');
System.Console.WriteLine(newtext);
System.Console.WriteLine();
newtext = RepLace(newtext, 'С', 'с');
System.Console.WriteLine(newtext);