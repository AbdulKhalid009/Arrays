
int x;
int y;
int z;

values(out x, out y, out z);



int[] array = {x, y, z };


foreach (int numbers in array)
{
    Console.WriteLine(numbers);
}

static void values(out int a,out  int b, out int c)
{
    Console.WriteLine("what number do you want in your array");
     a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("what number do you want in your array");
     b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("what number do you want in your array");
     c = Convert.ToInt32(Console.ReadLine());

   
   
}
