
{
	Console.WriteLine("Acierta al numero especial");
	int num;
    num = Convert.ToInt16(Console.ReadLine());
    int suma;
    int operacion;
	if(num % 5 == 0){
        Console.WriteLine("El número: " + num + " es divisble por 5");
        Console.WriteLine("La suma de sus digitos es mayor o igual a 10");
        suma= num + num;
        Console.WriteLine(num + "+" + num + "=" + suma);
	}else{
		Console.WriteLine("El número: " + num + " NO es divisble por 5");
	}
}