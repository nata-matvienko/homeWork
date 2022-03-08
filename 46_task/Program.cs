// 46. Написать программу масштабирования фигуры

using System.Linq; 
string text = "(3,2) (2,1) (1,3) (4,3)"
                .Replace("(", "") 
                .Replace(")", "")
                ;
Console.WriteLine(text);
var data = text.Split(" ")  
                .Select(item=>item.Split(','))   
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))  
                .Select(point => (point.x*10, point.y*10))  
                .ToArray();  
for (int i=0; i<data.Length; i++)
{
    Console.WriteLine(data[i]); 
}