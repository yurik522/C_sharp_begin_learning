

string text = "(1,2) (3,4) (8,6) (7,8)"
                .Replace("(", "")
                .Replace(")", "");
                
Console.WriteLine(text);                
var data = text.Split(" ")//возьми текст и разбей(Split) с учетом пробелов(" ")
                .Select(item => item.Split(','))//дальше разбей текст с учетом символа-разделителя ','.
                .Select(e =>(int.Parse(e[0]), int.Parse(e[1])))
                              //Item1           //Item2
                .Where(e => e.Item1 % 2 != 0)// сделает выборку координат, которые начинаются на четное число
                .Select(point => (point.Item1*10, point.Item2*10))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     Console.WriteLine(data[i][k]);
    // }
    Console.WriteLine();
}
