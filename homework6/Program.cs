// See https://aka.ms/new-console-template for more information

#region task1
var val1 = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[val1];
for (int i = 0; i < val1; i++)
{
    arr[i] = i + 1;
}

int[] oddarr = new int[(val1 - 1 / 2) + 1];
int oddpointer = 0;
int evenpointer = 0;
int[] evenarr = new int[val1 / 2];
for (int j = 0; j < val1; j++)
{
    if (arr[j] % 2 == 0) evenarr[evenpointer++] = arr[j];
    else oddarr[oddpointer++] = arr[j];
}
#endregion

#region task2
var val2 = Convert.ToInt32(Console.ReadLine());
int[] arr2 = new int[val2];
string val3 = Console.ReadLine();
string[] val3Arr = val3.Split(" ");
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = Convert.ToInt32(val3Arr[i]);
}
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < arr2.Length; i++)
{
    if (!dict.ContainsKey(arr2[i])) dict.Add(arr2[i],1);
    else dict[arr2[i]]++;
}

foreach (int k in dict.Keys)
{
    Console.WriteLine($"{k} appears {dict[k]} times, sum is " + k*dict[k] + "\n");
}
#endregion

#region task3
int[] arr4 = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
var val4 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= val4; i++)
{
    Console.WriteLine(arr4[arr4.Length-i]);
}
#endregion
