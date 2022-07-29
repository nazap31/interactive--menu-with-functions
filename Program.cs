Console.WriteLine("\n\nMenu interactivo!");
menuCicle();

void menuCicle()
{
    Console.WriteLine("\nBienvenido al programa de operaciones matematicas de dos numeros!");


    Console.WriteLine("\nElija cual operacion matematica desea hacer");


    Console.Write("(1) Suma de dos numeros");
    Console.Write(" (2) Resta de dos numeros");
    Console.Write("  (3) Multiplicacion de dos numeros");
    Console.Write("   (4) Division de dos numeros");
    Console.Write("\n\n(5) Salir");



    Console.WriteLine("\n\nPorfavor escriba el numero de la opcion que desea:");

    int opcion;
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        sumarNumeros();

    }

    else if (opcion == 2)
    {

        restarNumeros();


    }
    else if (opcion == 3)
    {
        multiplicarNumeros();

    }
    else if (opcion == 4)
    {
        dividirNumeros();

    }
    else if (opcion == 5)
    {
        Console.WriteLine("\nDesea salir al menu principal? (1) SI (2) NO");

        int salirMenu;
        salirMenu = int.Parse(Console.ReadLine());
        if (salirMenu == 1)
        {
            menuCicle();
        }
        else if (salirMenu == 2)
        {
            Console.WriteLine("\nHa elegido salir del programa...");
        }

        else
        {
           Console.WriteLine("\nPorfavor ingrese una opcion valida :( ");
        }
    }

    else
    {
        Console.WriteLine("\nPorfavor ingrese una opcion valida :( ");
    }
    
}



void sumarNumeros()
{
    Console.WriteLine("\n Ingrese los numeros con los cuales va a trabajar...");
    Console.WriteLine("\n Ingrese el primer numero: ");
    int firstNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\n Ingrese el segundo numero : ");
    int secondNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\nHa elegido la suma...");
    Console.WriteLine("\nLa suma de los  numeros ingresados es :  ");
    Console.Write(firstNumber + secondNumber);
}
void restarNumeros()
{
    Console.WriteLine("\n Ingrese los numeros con los cuales va a trabajar...");
    Console.WriteLine("\n Ingrese el primer numero: ");
    int firstNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\n Ingrese el segundo numero : ");
    int secondNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\nHa elegido la resta...");
    Console.WriteLine("\nLa resta de los  numeros ingresados es :  ");
    Console.Write(firstNumber - secondNumber);
}

void multiplicarNumeros()
{
    Console.WriteLine("\n Ingrese los numeros con los cuales va a trabajar...");
    Console.WriteLine("\n Ingrese el primer numero: ");
    int firstNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\n Ingrese el segundo numero : ");
    int secondNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\nHa elegido la multiplicacion...");
    Console.WriteLine("\nLa multiplicacion de los numeros ingresados es :  ");
    Console.Write(firstNumber * secondNumber);

}

void dividirNumeros()
{
    Console.WriteLine("\n Ingrese los numeros con los cuales va a trabajar...");
    Console.WriteLine("\n Ingrese el primer numero: ");
    int firstNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\n Ingrese el segundo numero : ");
    int secondNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("\nHa elegido la division...");
    Console.WriteLine("\nLa division de los numeros ingresados es : ");
    Console.Write(firstNumber / secondNumber);
}
Console.WriteLine("\n\nPrograma finalizado!\n\n ");