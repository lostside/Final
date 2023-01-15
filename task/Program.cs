string[] mainArray = new string[5] { "144", "geek", "home", "13", "qwerty"};
string[] newArray = new string[mainArray.Length];

void FillNewArray(string[] mainArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < mainArray.Length; i++)
    {
        if(mainArray[i].Length <= 3)
        {
            newArray[count] = mainArray[i];
            count++;
        }
    }
}