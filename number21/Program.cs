double[] InputCords(){
    double[] a = {0 , 0 , 0};
    Console.Write("Введите первую координату : ");
    a[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите вторую координату : ");
    a[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите третью координату : ");
    a[2] = Convert.ToDouble(Console.ReadLine()); 
    return a ;    
}
void distance(double[] a , double[] b ){
    Console.Write("Расстояние между точками : ") ;
    Console.WriteLine( Math.Sqrt(((a[0]-b[0])*(a[0]-b[0]))+((a[1]-b[1])*(a[1]-b[1]))+((a[2]-b[2])*(a[2]-b[2])))) ;
}
Console.WriteLine("Введите 3 координаты первого, а затем второго числа : ") ;
distance(InputCords() , InputCords());