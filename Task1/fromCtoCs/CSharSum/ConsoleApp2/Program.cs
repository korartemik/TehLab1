using System.Runtime.InteropServices;

class Program
{
    [DllImport(@"C:\Users\Артём\source\repos\Dll3\x64\Debug\Dll3.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_sum(int a, int b);

    static void Main(string[] args)
    {
        Console.WriteLine(get_sum(15, 7));
    }
}