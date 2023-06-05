// See https://aka.ms/new-console-template for more information


using DataProgramming;

Console.WriteLine("============= Number 1 =============");
var five = 5;
var five_point_zero = 5.0;
var five_greater_than_one = 5 > 1;
var five_with_quotes = '5';
var five_multiplied_by_two = 5 * 2;
var five_with_qoute_multiplied_by_two = '5' * 2;
var five_with_qoute_multiplied_by_two_with_qoute = '5' + '2';
var five_devided_by_two = 5 / 2;
var reminder = 5 % 2;
int[] list_on_number = { 5, 2, 1 };
var five_euquals_to_three = 5 == 3;
var pi = Math.PI;

//https://stackoverflow.com/questions/11634079/how-can-i-get-the-data-type-of-a-variable-in-c

Console.WriteLine(five.GetType());
Console.WriteLine(five_point_zero.GetType());
Console.WriteLine(five_greater_than_one.GetType());
Console.WriteLine(five_with_quotes.GetType());
Console.WriteLine(five_multiplied_by_two.GetType());
Console.WriteLine(five_with_qoute_multiplied_by_two.GetType());
Console.WriteLine(five_with_qoute_multiplied_by_two_with_qoute.GetType());
Console.WriteLine(five_devided_by_two.GetType());
Console.WriteLine(reminder.GetType());
Console.WriteLine(list_on_number.GetType());
Console.WriteLine(five_euquals_to_three.GetType());
Console.WriteLine(pi.GetType());

Console.WriteLine();
Console.WriteLine("============= Number 2 =============");
var len_of_word = "Supercalifragilisticexpialidocious";
Console.WriteLine(len_of_word.Length);

//https://www.tutorialkart.com/c-sharp-tutorial/how-to-check-if-string-contains-specified-substring-in-csharp/
string subStr = "ice";
bool contains = len_of_word.Contains(subStr);
Console.WriteLine(contains);

//https://stackoverflow.com/questions/29899790/get-the-longest-string-from-listclass-using-linq-c-sharp
string[] strings = { "Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn" };
string longest_string = strings.Max();
Console.WriteLine("The longest string is: " + longest_string);

Console.WriteLine();

//https://stackoverflow.com/questions/13979966/get-first-element-from-a-dictionary
Dictionary<string, string> composers = new Dictionary<string, string>()
{
    {"Berlioz", "Hector Berlioz"},
    {"Borodin", "Alexander Borodin"},
    {"Brian", "Havergal Brian"},
    {"Bartok", "Bela Bartok"},
    {"Bellini", "Vincenzo Bellini"},
    {"Buxtehude", "Dietrich Buxtehude"},
    {"Bernstein", "Leonard Bernstein"}
};

var sortedComposers = composers.OrderBy(x => x.Key);
var firstComposer = sortedComposers.First();
var lastComposer = sortedComposers.Last();

Console.WriteLine($"First composer: {firstComposer.Key}");
Console.WriteLine($"Last composer: {lastComposer.Key}");



Console.WriteLine();
Console.WriteLine("============= Number 3 =============");
//https://stackoverflow.com/questions/10947885/calculation-the-area-of-a-triangle
AreaOfTriangle areaOfTriangle = new AreaOfTriangle();
var triangleArea = areaOfTriangle.TriangleArea(2, 2, 2);
Console.WriteLine(triangleArea);


Console.WriteLine();
Console.WriteLine("============= Number 4 =============");

Console.Write("Input the number of elements to be stored in the array: ");
int n = Convert.ToInt32(Console.ReadLine());
EvenAndOldArray evenAndOld = new EvenAndOldArray();
var arrayNum = evenAndOld.EvenOldArrayNumber(n);
Console.WriteLine(arrayNum);
