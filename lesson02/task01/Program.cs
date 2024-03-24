int[] arr = new int[5];
arr[0] = 8;
arr[1] = 2;
arr[2] = 6;
arr[3] = 1;
arr[4] = 3;

int[] arr2 = new int[5] { 3, 4, 1, 2, 5 };
int[] arr3 = { 8, 4, 3, 2, 6 };

//How to print a full array like an object through commas?
Console.WriteLine(string.Join(",", arr));
Console.WriteLine(string.Join(", ", arr2));
Console.WriteLine(string.Join(", ", arr3));