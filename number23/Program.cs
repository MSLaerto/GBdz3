int InputNumber(){
    Console.Write("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a ;    
}
void CubesOfNumber(int a){
    if (a < 1 ){
        Console.WriteLine("Число меньше 1 , кубов нет");    
    }else{
        for (int i = 1 ; i <= a ; i++){
            Console.Write(i*i*i);
            if (Convert.ToBoolean(i-a)){
                Console.Write(",");
            } 
        }   
    }  
}
Console.WriteLine("Введите 3 координаты первого, а затем второго числа : ") ;
CubesOfNumber(InputNumber());