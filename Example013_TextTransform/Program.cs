string text = "Scarabey";
string Replace (string text, char oldValue, char newValue)
{
string result = string.Empty;
int length = text.Length;
for (int i = 0; i<length; i++)
    {
        if (text [i] == oldValue) result=result + $"{newValue}";
        else result= result + $"{text[i]}";
    }
return result;
}
string newText = Replace (text,'c', 'a');
Console.WriteLine (newText);
