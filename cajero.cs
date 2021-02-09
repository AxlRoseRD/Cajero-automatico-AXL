using System;

public class Cajero
{
    #region contenedor
    //contenedores de billetes
    public int Contenedor1000 = 40;   //cantidad de unidades de billetes de 1,000$
    public int Contenedor500 = 60;   //cantidad de unidades de billetes de 500$
    public int Contenedor200 = 100; //cantidad de unidades de billetes de 200$
    public int Contenedor100 = 100;//cantidad de unidades de billetes de 100$  
    #endregion

     public int Pagar(int ValorTransaccion)
    {
        int pago = 0;
        if (ValorTransaccion <= 10000)
        {
            if (ValorTransaccion >= 1000 && Contenedor1000 > 0)
            {
                pago = ValorTransaccion / 1000;
                ValorTransaccion = ValorTransaccion - (pago * 1000);
                Console.WriteLine("*se han dispensado {0} billete(s) de mil*"
                ,pago, Console.ForegroundColor = ConsoleColor.Green);
                Contenedor1000 -= pago;
                Contenedor1000 = (Contenedor1000 * 1000) - (pago * 1000);
                Console.ForegroundColor = ConsoleColor.White;
            } 
            if (ValorTransaccion >= 500 && Contenedor500 > 0)
            {
                pago = ValorTransaccion / 500;
                ValorTransaccion = ValorTransaccion - (pago * 500);
                Console.WriteLine("*se han dispensado {0} billete(s) de quinientos*"
                , pago, Console.ForegroundColor = ConsoleColor.Green);
                Contenedor500 -= pago;
                Contenedor500 = (Contenedor500 * 500) - (pago * 500);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (ValorTransaccion >= 200 && Contenedor200 > 0)
            {
                pago = ValorTransaccion / 200;
                ValorTransaccion = ValorTransaccion - (pago * 200);
                Console.WriteLine("*se han dispensado {0} billete(s) de docientos*"
                , pago, Console.ForegroundColor = ConsoleColor.Green);
                Contenedor200 -= pago;
                Contenedor200 = (Contenedor200 * 200) - (pago * 200);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (ValorTransaccion >= 100 && Contenedor100 > 0)
            {
                pago = ValorTransaccion / 100;
                ValorTransaccion = ValorTransaccion - (pago * 100);
                Console.WriteLine("*se han dispensado {0} billete(s) de Cien*"
                , pago, Console.ForegroundColor = ConsoleColor.Green);
                Contenedor100 -= pago;
                Contenedor100 = (Contenedor100 * 100) - (pago * 100);
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        else if (ValorTransaccion > 10000)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("monto invalido *NO PUEDE DISPENSAR CANTIDADES SUPERIORES A 10,000*");
            Console.ForegroundColor = ConsoleColor.White;
        }
        return pago;
        
    }
    public void balance(String password)
    {
        if (password == "Palmer1234")
        {
            if (Contenedor1000 >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("quedan: {0} papeletas de MIl pesos", Contenedor1000);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor1000 > 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("quedan: {0} papeletas de MIl pesos", Contenedor1000);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor1000 <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("quedan: {0} papeletas de MIl pesos", Contenedor1000);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        if (password == "Palmer1234")
        {
            if (Contenedor500 >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("quedan: {0} papeletas de quinientos pesos", Contenedor500);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor1000 >=49)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("quedan: {0} papeletas de quinientos pesos", Contenedor500);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor1000 <= 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("quedan: {0} papeletas de quinientos pesos", Contenedor500);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        if (password == "Palmer1234")
        {
            if (Contenedor200 >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("quedan: {0} papeletas de docientos pesos", Contenedor200);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor200 <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("quedan: {0} papeletas de docientos pesos", Contenedor200);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor200 >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("quedan: {0} papeletas de docientos pesos", Contenedor200);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        if (password == "Palmer1234")
        {
            if (Contenedor100 >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("quedan: {0} papeletas de Cien pesos", Contenedor100);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor100 <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("quedan: {0} papeletas de Cien pesos", Contenedor100);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Contenedor100 >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("quedan: {0} papeletas de Cien pesos", Contenedor100);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    //CAJERO AUTOMATICO POR AXCELL ESPINAL®9-2-2021(AxlRoseRD) made in DOMINICAN REPUBLIC
}
