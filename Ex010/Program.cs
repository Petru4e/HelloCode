int [] arr = {122,2,3,6,55,4,8,7,9};
 int n = arr.Length;
 int find = 6;
 int index=0;
 while (index<n)
 {
    if (arr[index]==find)
    {
        System.Console.WriteLine(index);
    }
    index++;
 }