char[] chars = { 'a', 'b', 'c', 'd', 'e' };

string strResult(char[] chars)
{
    string strResult = "";
    for (int i = 0; i < chars.Length; i++)
    {
        strResult += chars[i];
    }
    return strResult;
}

string result = strResult(chars);
Console.WriteLine(result);