using System;

namespace Cajero_automatico_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero Palmer = new Cajero();
            Boolean sesion = true;
            //valor en unidades de 1$RD de los billetes
            /*este campo sirve para reflejar mejor cuantas unidades de 1$ se lleva el usuario 
            en base a la cantidad de billetes enteros dispensados*/
            Palmer.Contenedor1000 *= 1000;
            Palmer.Contenedor500 *= 500;
            Palmer.Contenedor200 *= 200;
            Palmer.Contenedor100 *= 100;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*<<<<<<<<< Bienvenid@ a la red de cajeros palmer >>>>>>>>>>>>*");
                Console.WriteLine("*------------------------------------------------------------*");
                Console.WriteLine("*|> 1.Transaccion con otro valor       2.transaccion rapida |*");
                Console.WriteLine("*|> 3.balance del cajero               4.salir              |*");
                Console.WriteLine("*|                                                          |*");
                Console.WriteLine("*|                                                          |*");
                Console.WriteLine("*|                                                          |*");
                Console.WriteLine("*|                                                          |*");
                Console.WriteLine("**************************************************************");
                Console.ForegroundColor = ConsoleColor.White;
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int transaccion;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("digite el monto de su transaccion");
                        transaccion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        int residuo1 = transaccion % 100;
                        int validez = residuo1;
                        if (validez == 0 && transaccion >= 100)
                        {
                            Palmer.Pagar(transaccion);                    
                        }
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ingrese un monto valido");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("******************************************");
                        Console.WriteLine("*<<<<<<<<< Elija una transaccion >>>>>>>>*");
                        Console.WriteLine("*----------------------------------------*");
                        Console.WriteLine("*|> 1. 100$RD               2. 500$RD   |*");
                        Console.WriteLine("*|> 3. 200$RD               4. 1,000$RD |*");
                        Console.WriteLine("*|                                      |*");
                        Console.WriteLine("*|                                      |*");
                        Console.WriteLine("******************************************");
                        Console.ForegroundColor = ConsoleColor.White;
                        transaccion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (transaccion) 
                        {
                            case 1:
                                Palmer.Pagar(100);
                                break;

                            case 2:
                                Palmer.Pagar(500);
                                break;

                            case 3:
                                Palmer.Pagar(200);
                                break;

                            case 4:
                                Palmer.Pagar(1000);
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("esta es una opcion de administrador");
                        Console.WriteLine("escriba la clave");
                        string code = Console.ReadLine();
                        Palmer.balance(code);
                        break;
                    case 4:
                        sesion = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("gracias por utilizar nuestros servicios");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (sesion == true);
        }
        //CAJERO AUTOMATICO POR AXCELL ESPINAL® 9-2-2021(AxlRoseRD) made in DOMINICAN REPUBLIC
    }
}

