
Console.WriteLine("Программа для вычисления расстояния между точками в 3D пространстве");

int Prompt(string message){
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

Console.WriteLine("Введите координаты точек");
int x1,x2,y1,y2,z1,z2;
x1 = Prompt("Введите координаты x1 ");
y1 = Prompt("Введите координаты y1 ");
z1 = Prompt("Введите координаты z1 ");
x2 = Prompt("Введите координаты x2 ");
y2 = Prompt("Введите координаты y2 ");
z2 = Prompt("Введите координаты z2 ");
int []r1 = new int[3]{x1, y1, z1};
int []r2 = new int[3]{x2, y2, z2};

double d = Convert.ToDouble(Math.Sqrt(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));


Console.WriteLine(d);