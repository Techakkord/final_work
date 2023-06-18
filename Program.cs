string[] arrStr1 = {"Hello", "2", "world", ":-)"};
string[] arrStr2 = {"1234", "1567", "-2", "computer science"};
string[] arrStr3 = {"Russia", "Denmark", "Kazan"};

string[] newStrArr1 = getStrArr(arrStr1, 3);

string[] getStrArr(string[] originArr, int targetStrLength){
    
    int strCount = 0;
    string[] tempArr = new string[originArr.Length];
    
    for(int i = 0; i < originArr.Length; i++)
    {
        if(originArr[i].Length <= targetStrLength){
            ++strCount;
            tempArr[strCount-1] = originArr[i];
        }
    }

    string[] newArr = new string[strCount];
    for (int i = 0; i < strCount; i++)
    {
        newArr[i] = tempArr[i];
    }
    return newArr;
    
}