using System.IO;
using System.Runtime.CompilerServices;

var lines = File.ReadLines("../../../input.txt");
int sum = 0, l = 0, w = 0, h = 0, lw = 0, wh = 0, hl = 0;
int ribbon = 0;
foreach (var line in lines)
{
    int[] oneline = line.Split('x').Select(int.Parse).ToArray();
    Array.Sort(oneline);
    l = oneline[0];
    w = oneline[1];
    h = oneline[2];

    lw = l * w;
    wh = w * h;
    hl = h * l;

    sum += lw * 2 + wh * 2 + hl * 2 + oneline[0] * oneline[1];

    //part2

    ribbon += oneline[0] * 2 + oneline[1] * 2 + (oneline[0] * oneline[1] * oneline[2]);

}
Console.WriteLine(sum);
Console.WriteLine(ribbon) ;


//1598415