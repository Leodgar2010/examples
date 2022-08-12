Console.WriteLine ("Вычисление четверти, в которой находится точка");
Console.WriteLine ("Введите координату X:");
var xString = Console.ReadLine ();
int x= int.Parse (xString!);
if (x==0) 
{
    Console.WriteLine ("Невозможно вычислить четверть для точки, лежащей на оси");
    return;
}
Console.WriteLine ("Введите координату y:");
var yString = Console.ReadLine ();
int y= int.Parse (yString!);
if (y== 0) 
{
    Console.WriteLine ("Невозможно вычислить четверть для точки, лежащей на оси");
    return;
}    
int result = 0;
if (x>0 && y>0)
    result = 1;
else if (x<0 && y>0)
    result = 2;
else if (x<0 && y<0)
    result = 3;
else if (x>0 && y<0)
    result = 2;
if (result!=0)

    Console.WriteLine ("Номер четверти в которой находится точка: "+result);
else
    Console.WriteLine ("Невозможно вычислить четверть для точки, лежащей на оси");