namespace dars_10.Extensions;

public static class ExtensionsString
{
    public static int GetCountOfCat(this string str)
    {
        int count = 0;
        for (int i = 1; i < str.Length - 1; i++)
        {
            if (str[i - 1] == 'c' && str[i] == 'a' && str[i + 1] == 't')
            {
                count++;
            }
        }
        return count;
    }
}
