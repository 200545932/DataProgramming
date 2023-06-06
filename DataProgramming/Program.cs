// See https://aka.ms/new-console-template for more information


using DataProgramming;

Console.WriteLine("============= Number 1 =============");
//https://stackoverflow.com/questions/11634079/how-can-i-get-the-data-type-of-a-variable-in-c
VariableTypes variable = new VariableTypes();
 variable.VariableType();

Console.WriteLine();
Console.WriteLine("============= Number 2 =============");
// Question 2b https://www.tutorialkart.com/c-sharp-tutorial/how-to-check-if-string-contains-specified-substring-in-csharp/
// Quextion 2c https://stackoverflow.com/questions/29899790/get-the-longest-string-from-listclass-using-linq-c-sharp
// Qustion 2d https://stackoverflow.com/questions/13979966/get-first-element-from-a-dictionary
StringLegth variablestring = new StringLegth();
variablestring.QuestionTwo();

Console.WriteLine();
Console.WriteLine("============= Number 3 =============");
//https://stackoverflow.com/questions/10947885/calculation-the-area-of-a-triangle
AreaOfTriangle areaOfTriangle = new AreaOfTriangle();
var triangleArea = areaOfTriangle.TriangleArea(2, 2, 2);
Console.WriteLine(triangleArea);


Console.WriteLine();
Console.WriteLine("============= Number 4 =============");
//https://stackoverflow.com/questions/61190113/separating-even-and-odd-numbers-in-different-arrays
Console.Write("Input the number of elements to be stored in the array: ");
int n = Convert.ToInt32(Console.ReadLine());
EvenAndOldArray evenAndOld = new EvenAndOldArray();
var arrayNum = evenAndOld.EvenOldArrayNumber(n);
Console.WriteLine(arrayNum);

Console.WriteLine();
Console.WriteLine("============= Number 5 =============");
//https://stackoverflow.com/questions/54433824/is-a-data-point-within-a-rectangle
RectangleCoordinate coordinate = new RectangleCoordinate();
var insideNum = coordinate.inside(1,1,0,0,2,3);
Console.WriteLine(insideNum);
Console.WriteLine();
   if(coordinate.inside(1, 1, 0.3, 0.5, 1.1, 0.7) && coordinate.inside(1, 1, 0.5, 0.2, 1.1, 2))
   {
        Console.WriteLine("The point (1,1) lies in both rectangles.");
   }
   else
   {
        Console.WriteLine("The point (1,1) does not lie in both rectangles.");
   }

