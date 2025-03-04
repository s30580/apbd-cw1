// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1 pozdrawiam");
Console.WriteLine("Modyfikacja 2 pozdrawiam");
Console.WriteLine("Modyfikacja 3 pozdrawiam");


static double Function1(int[] arr)
{
    double ret = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        ret += arr[i];
    }
    ret /= arr.Length;
    return ret;
}
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine(Function1(arr));