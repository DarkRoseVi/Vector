// See https://aka.ms/new-console-template for more information
using Vector;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("x");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("y");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("z");
//double z = Convert.ToDouble(Console.ReadLine());
VectorClass vector = new VectorClass(1,2,3);
vector.Print();


//Console.WriteLine("x2");
//double x2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("y2");
//double y2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("z2");
//double z2 = Convert.ToDouble(Console.ReadLine());
VectorClass vector2 = new VectorClass(4, 5, 6);
vector2.Print();
VectorClass sums = vector.AddVector(vector2);
sums.Print();
VectorClass difference = vector.Subtract(vector2);
difference.Print();
Console.WriteLine($"Length of vector1:{vector.Length:0.00} " ); Console.WriteLine($"Length of sum:{sums.Length: 0.00} " );
Console.WriteLine($"Length of difference: {difference.Length: 0.00}" );



Console.ReadKey();  