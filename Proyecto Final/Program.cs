using System;


class Proyecto
{
    static void Main()
    {
    

        Console.WriteLine("Bienvenido al programa de Multiventas ");

        List<string> listaProductos = new List<string>();
        List<double> listaPrecios = new List<double>();

        int opcllantas;
        do
        {

            Console.WriteLine("=============MENU------------");
            Console.WriteLine("Seleccione la categoría que le gustaría comprar:(");
            Console.WriteLine("1. LLantas para Carro");
            Console.WriteLine("2. Jetstereo");
            Console.WriteLine("3. MotoMundo");
            Console.WriteLine("4. Marca para Zapatos");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese su opción: ");
            opcllantas = int.Parse(Console.ReadLine());

            switch (opcllantas)
            {
                case 1:

                    int opc;
                    do
                    {
                        Console.WriteLine(" Ventas: LLantas");
                        Console.WriteLine("1. LLantas Michelin - 1.300.00 Lps ");
                        Console.WriteLine("2. LLantas Continental - 1.500.00 Lps ");
                        Console.WriteLine("3. LLantas Goodyear - 1.800.00 Lps ");
                        Console.WriteLine("4. LLantas Pirelli - 1.900.00 Lps ");
                        Console.WriteLine("5. LLantas Bridgestone - 2.000.00 Lps ");
                        Console.WriteLine("6. LLantas Yokohama - 2.100.00 Lps ");
                        Console.WriteLine("7. LLantas Hankook - 2.200.00 Lps ");
                        Console.WriteLine("8. LLantas Falken - 2.400.00 Lps ");
                        Console.WriteLine("9. LLantas Toyo - 1.500.00 Lps ");
                        Console.WriteLine("10.LLantas BF Goodrich - 2.500.00 Lps ");
                        Console.WriteLine("11.Volver Atras");
                        Console.Write("Seleccione la LLanta que desee Comprar:");
                        opcllantas = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcllantas)
                        {
                            case 1:
                                precio = 1300;
                                impuesto = 0.8;
                                break;
                            case 2:
                                precio = 1500;
                                impuesto = 0.7;
                                break;
                            case 3:
                                precio = 1800;
                                impuesto = 0.6;
                                break;
                            case 4:
                                precio = 1900;
                                impuesto = 0.5;
                                break;
                            case 5:
                                precio = 2000;
                                impuesto = 0.9;
                                break;
                            case 6:
                                precio = 2100;
                                impuesto = 0.10;
                                break;
                            case 7:
                                precio = 2200;
                                impuesto = 0.11;
                                break;
                            case 8:
                                precio = 2400;
                                impuesto = 0.12;
                                break;
                            case 9:
                                precio = 1500;
                                impuesto = 0.13;
                                break;
                            case 10:
                                precio = 2500;
                                impuesto = 0.14;
                                break;

                                Console.WriteLine("Volviendo al menú principal..");
                                break;
                            default:
                                Console.WriteLine("Opción no Concretada. Por favor, intente de nuevo Mas tarde.");
                                continue;
                        }

                        if (opcllantas >= 1 && opcllantas <= 10)
                        {
                            Console.Write("Ingrese la cantidad de LLantas que desea llevar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("Lo sentimos la cantidad que desea no tenemos disponible");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(opcllantas == 1 ? "Michelin" : opcllantas == 2 ? "Continental" : opcllantas == 3 ? "Goodyear" : opcllantas == 4 ? "Pirelli" : opcllantas == 5 ? "Bridgestone" : opcllantas == 6 ? "Yokohama" : opcllantas == 7 ? "Hankook" : opcllantas == 8 ? "Falken" : opcllantas == 8 ? "Falken" : "Toyo")} x{cantidad}"); 
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lempiras");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lempiras");


                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcllantas != 11);
                    break;


                
                case 2:

                    int Jetsterio;
                    do
                    {
                        Console.WriteLine("Ventas: Jetsterio");
                        Console.WriteLine("1. Televisores - 25.000 Lps ");
                        Console.WriteLine("2. Computadoras - 15.000 Lps ");
                        Console.WriteLine("3. Tablets - 21.000 Lps ");
                        Console.WriteLine("4. Refrigeradoras - 47.000 Lps ");
                        Console.WriteLine("5. Play station - 32.000 Lps ");
                        Console.WriteLine("6. Estufas - 40.000 Lps ");
                        Console.WriteLine("7. Aire Acondicionado - 60.000 Lps ");
                        Console.WriteLine("8. Regresar al menú principal");
                        Console.Write("Seleccione un producto:");
                        Jetsterio = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (Jetsterio)
                        {
                            case 1:
                                precio = 25000;
                                impuesto = 0.15;
                                break;
                            case 2:
                                precio = 15000;
                                impuesto = 0.20;
                                break;
                            case 3:
                                precio = 21000;
                                impuesto = 0.18;
                                break;
                            case 4:
                                precio = 47000;
                                impuesto = 0.16;
                                break;
                            case 5:
                                precio = 32000;
                                impuesto = 0.13;
                                break;
                            case 6:
                                precio = 40000;
                                impuesto = 0.10;
                                break;
                            case 7:
                                precio = 60000;
                                impuesto = 0.22;
                                break;

                                Console.WriteLine("Volviendo al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no Concretada. Por favor, intente de nuevo Mas tarde.");
                                continue;
                        }

                        if (Jetsterio >= 1 && Jetsterio <= 7)
                        {
                            Console.Write("Ingrese la cantidad de cosas de Jetsterio que desee comprar (máximo 30): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 30)
                            {
                                Console.WriteLine("Lo sentimos la cantidad que desea no tenemos disponible");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(Jetsterio == 1 ? "Televisores" : Jetsterio == 2 ? "Computadoras" : Jetsterio == 3 ? "Tablets" : Jetsterio == 4 ? "Refrigeradoras" : Jetsterio == 5 ? "Play station" : Jetsterio == 6 ? "Estufas" : Jetsterio == 7 ? "Aire Acondicionado" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lempiras");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lempiras");

                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Jetsterio != 8);
                    break;


                case 3:

                    int Motomundo;
                    do
                    {
                        Console.WriteLine("Ventas: Motomundo");
                        Console.WriteLine("1. Trabajo - 47.990 Lps ");
                        Console.WriteLine("2. Niños - 110.990 Lps ");
                        Console.WriteLine("3. Todo Terreno - 136.990 Lps ");
                        Console.WriteLine("4. Deportivas - 83.990 Lps ");
                        Console.WriteLine("5. Automaticas - 38.990 Lps ");
                        Console.WriteLine("6. Regresar al menú principal");
                        Console.Write("Seleccione un producto:");
                        Motomundo = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (Motomundo)
                        {
                            case 1:
                                precio = 47990;
                                impuesto = 0.7;
                                break;
                            case 2:
                                precio = 110990;
                                impuesto = 0.11;
                                break;
                            case 3:
                                precio = 136990;
                                impuesto = 0.10;
                                break;
                            case 4:
                                precio = 83990;
                                impuesto = 0.13;
                                break;
                            case 5:
                                precio = 38990;
                                impuesto = 0.18;
                                break;

                                Console.WriteLine("Volviendo al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no Concretada. Por favor, intente de nuevo Mas tarde.");
                                continue;
                        }

                        if (Motomundo >= 1 && Motomundo <= 5)
                        {
                            Console.Write("Ingrese la cantidad de Cosas que desee comprar (máximo 15): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 15)
                            {
                                Console.WriteLine("Lo sentimos la cantidad que desea no tenemos disponible");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(Motomundo== 1 ? "Trabajo" : Motomundo == 2 ? "Niños" : Motomundo == 3 ? "Todo Terreno" : Motomundo == 4 ? "Deportivas" : Motomundo == 5 ? "Automaticas" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lempiras");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lempiras");

                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Motomundo != 6);
                    break;


                case 4:

                    int Marcazapatos;
                    do
                    {
                        Console.WriteLine("Ventas: Marcazapatos");
                        Console.WriteLine("1. Jordan - 3.349 Lps ");
                        Console.WriteLine("2. Timberland - 543 Lps ");
                        Console.WriteLine("3. Adidas - 1700 Lps  ");
                        Console.WriteLine("4. Nike - 2200 Lps ");
                        Console.WriteLine("5. Puma - 2300 Lps ");
                        Console.WriteLine("6. Red Wing - 1500 Lps ");
                        Console.WriteLine("7. Botas - 700 Lps ");
                        Console.WriteLine("8. Regresar al menú principal");
                        Console.Write("Seleccione un producto:");
                        Marcazapatos = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (Marcazapatos)
                        {
                            case 1:
                                precio = 3349;
                                impuesto = 0.06;
                                break;
                            case 2:
                                precio = 543;
                                impuesto = 0.12;
                                break;
                            case 3:
                                precio = 1700;
                                impuesto = 0.18;
                                break;
                            case 4:
                                precio = 2200;
                                impuesto = 0.11;
                                break;
                            case 5:
                                precio = 2300;
                                impuesto = 0.14;
                                break;
                            case 6:
                                precio = 1500;
                                impuesto = 0.10;
                                break;
                            case 7:
                                precio = 700;
                                impuesto = 0.7;
                                break;

                                Console.WriteLine("Volviendo al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no Concretada. Por favor, intente de nuevo Mas tarde.");
                                continue;
                        }

                        if (Marcazapatos >= 1 && Marcazapatos <= 7)
                        {
                            Console.Write("Ingrese la cantidad de Marca de Zapatos que desee comprar (máximo 50): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 50)
                            {
                                Console.WriteLine("Lo sentimos la cantidad que desea no tenemos disponible");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(Marcazapatos == 1 ? "Jordan" : Marcazapatos == 2 ? "Timberland" : Marcazapatos == 3 ? "Adidas" : Marcazapatos == 4 ? "Nike" : Marcazapatos == 5 ? "Puma" : Marcazapatos == 6 ? "Red wing" : Marcazapatos == 7 ? "Botas" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lempiras");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lempiras");

                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Marcazapatos != 8);
                    break;

                case 5:

                    Console.WriteLine("Generando factura final...");
                    MostrarFacturaFinal(listaProductos, listaPrecios);
                    break;

                default:

                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }

        } while (opcllantas != 3);
    }


    static double CalcularDescuento(int cantidad)
    {
        if (cantidad >= 50)
        {
            return 0.15;
        }
        else if (cantidad >= 20)
        {
            return 0.10;
        }
        else if (cantidad >= 10)
        {
            return 0.05;
        }
        else
        {
            return 0;
        }
    }


    static void MostrarFacturaFinal(List<string> listaProductos, List<double> listaPrecios)
    {
        Console.WriteLine("\n---------- FACTURA FINAL ----------");
        double total = 0;

        for (int i = 0; i < listaProductos.Count; i++)
        {
            Console.WriteLine($"{listaProductos[i]} - {listaPrecios[i]:F2}  Lempiras");
            total += listaPrecios[i];
        }

        Console.WriteLine($"----------------------------------");
        Console.WriteLine($"TOTAL A PAGAR: {total:F2}  Lempiras");
        Console.WriteLine("¡Gracias por su compra!");
    }
}
