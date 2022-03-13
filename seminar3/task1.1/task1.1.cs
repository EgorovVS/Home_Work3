Console.WriteLine("Программа для определения палиндромов. Введите число");

string num = Convert.ToString(Console.ReadLine());
char[]chr = num.ToCharArray();
char[]chr1 = num.ToCharArray();

Array.Reverse(chr1);

Console.WriteLine(chr1);
int ans = 0;
for(int i =0; i<chr.Length; i++){
for(int j = chr.Length-1;j>0; j--){    
if(chr1[i]==chr[j]){
    ans = 1;
}   else{
    ans = 0;
}
}
}
   if(ans == 1){
    Console.WriteLine("Число - палиндром");
}   else{
    Console.WriteLine("Число - не палиндром");
}
