Console.WriteLine("Программа для выявление палиндромов из 5-ти значных чисел");
Console.WriteLine("Введите 5-ти значное число");
int b = int.Parse(Console.ReadLine());
if(b > 99999 && b < -99999 && b<10000 && b> -10000){
    Console.WriteLine("Вы ввели некорректное число");
}
string strb = b.ToString();

if(strb[0]==strb[strb.Length-1]&strb[1]==strb[strb.Length-2]){
    Console.WriteLine("Число - палиндром");
}   else{
    Console.WriteLine("Число - не палиндром");
    } 
