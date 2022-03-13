
Console.WriteLine("Программа принимает число N, затем выводит кубы чисел от 1 до N");
int N, i, j;

i = 1;
j = 0;
Console.WriteLine("Введите N");

N = Convert.ToInt32(Console.ReadLine());

for(i=1; i<N+1; i++){
    j = i;
       Console.WriteLine("Куб числа " + j + " равен "+ j*j*j);
}     
        