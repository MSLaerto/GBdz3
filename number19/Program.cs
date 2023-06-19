int InputNumber(){
    Console.Write("Введите пятизначное число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <=9999 || a>=100000){
        Console.Write("Число должно быть пятизначным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
int Reverse(int a){
    int b = 0 ;
    while (a>0){
        b = b*10+a%10;
        a = a/10;
    }
    return b;
}
void PolindromChecker(int a , int b ){
    if (a==b){
        Console.Write("Полиндром");
    }else{
        Console.Write("Не полиндром");
    } 
}
int a = InputNumber();
PolindromChecker(a , Reverse(a));