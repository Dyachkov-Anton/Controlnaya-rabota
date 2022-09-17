void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

string[] InputArray1 =  {"hello", "2", "world", ":-)"};
int count1 = CountString(InputArray1);
string[] OutputArray1 =  FillOutputArray(InputArray1,count1);

string[] InputArray2 =  {"1234", "1567", "-2", "computer science"};
int count2 = CountString(InputArray2);
string[] OutputArray2 =  FillOutputArray(InputArray2,count2);

string[] InputArray3 =  {"Russia", "Denmark", "Kazan"};
int count3 = CountString(InputArray3);
string[] OutputArray3 =  FillOutputArray(InputArray3,count3);

int CountString(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] FillOutputArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }    

PrintArray(InputArray1);
PrintArray(OutputArray1);

PrintArray(InputArray2);
PrintArray(OutputArray2);

PrintArray(InputArray3);
PrintArray(OutputArray3);