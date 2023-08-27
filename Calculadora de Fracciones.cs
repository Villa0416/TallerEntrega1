int opcion;
            string ultimaOperacion = "";

            do
            {
                Console.WriteLine("\n--- CALCULADORA BÁSICA ---");
                Console.WriteLine("1. Realizar Operación");
                Console.WriteLine("2. Ver Última Operación");
                Console.WriteLine("3. Salir");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese una opción válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        // Realizar operación
                        Console.WriteLine("Ingrese primer número:");
                        double num1;
                          if (!double.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("Número no válido.");
                            continue;
                        }
                        Console.WriteLine("Ingrese segundo número:");
                        double num2;
                            if (!double.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Número no válido.");
                            continue;
                        }
                        Console.WriteLine("Ingrese tercer número:");
                        double num3;
                          if (!double.TryParse(Console.ReadLine(), out num3))
                        {
                            Console.WriteLine("Número no válido.");
                            continue;
                        }
                        Console.WriteLine("Ingrese cuarto número:");
                        double num4;

                      
                       
                         if (!double.TryParse(Console.ReadLine(), out num4))
                        {
                            Console.WriteLine("Número no válido.");
                            continue;
                        }
                        Console.WriteLine("Ingrese operador (+ o - o % o x):");
                        string operador = Console.ReadLine();

                    

                        double resultado1 = 0;
                        double resultado2 = 0;
                        double resultado3 = 0;
                        double resta1 = 0;
                        double total = 0;

                        switch (operador)
                        {
                            case "+":
                                Console.WriteLine("   ");
                                Console.WriteLine("OPERACIÓN");
                                Console.WriteLine("   ");
                                Console.WriteLine(num1);
                                Console.WriteLine("--");
                                Console.WriteLine(num2);
                                Console.WriteLine("   ");
                                Console.WriteLine(" + ");
                                Console.WriteLine("   ");
                                Console.WriteLine(num3);
                                Console.WriteLine("--");
                                Console.WriteLine(num4);
                                Console.WriteLine("   ");
                              

                                resultado1 = num1 * num4;
                                resultado2 = num3 * num2;
                                resultado3 = num2 * num4;
                                resta1= resultado1 + resultado2;
                                total= (resta1/ resultado3);
                                break;
                            case "-":
                                Console.WriteLine("   ");
                                Console.WriteLine("OPERACIÓN");
                                Console.WriteLine("   ");
                                Console.WriteLine(num1);
                                Console.WriteLine("--");
                                Console.WriteLine(num2);
                                Console.WriteLine("   ");
                                Console.WriteLine(" - ");
                                Console.WriteLine("   ");
                                Console.WriteLine(num3);
                                Console.WriteLine("--");
                                Console.WriteLine(num4);
                                Console.WriteLine("   ");
                              

                                resultado1 = num1 * num4;
                                resultado2 = num3 * num2;
                                resultado3 = num2 * num4;
                                resta1= resultado1 - resultado2;
                                total= (resta1/ resultado3);
                                
                                break;
                            case "x":
                              Console.WriteLine("   ");
                                Console.WriteLine("OPERACIÓN");
                                Console.WriteLine("   ");
                                Console.WriteLine(num1);
                                Console.WriteLine("--");
                                Console.WriteLine(num2);
                                Console.WriteLine("   ");
                                Console.WriteLine(" x ");
                                Console.WriteLine("   ");
                                Console.WriteLine(num3);
                                Console.WriteLine("--");
                                Console.WriteLine(num4);
                                Console.WriteLine("   ");
                              

                                resultado1 = num1 * num4;
                                resultado2 = num3 * num2;
                                total= (resultado1 / resultado2);
                                
                                break;
                            case "%":
                                Console.WriteLine("   ");
                                Console.WriteLine("OPERACIÓN");
                                Console.WriteLine("   ");
                                Console.WriteLine(num1);
                                Console.WriteLine("--");
                                Console.WriteLine(num2);
                                Console.WriteLine("   ");
                                Console.WriteLine(" %");
                                Console.WriteLine("   ");
                                Console.WriteLine(num3);
                                Console.WriteLine("--");
                                Console.WriteLine(num4);
                                Console.WriteLine("   ");
                              

                                resultado1 = num1 / num2;
                                resultado2 = num3 / num4;
                                total= (resultado1 / resultado2);
                                break;
                            default:
                                Console.WriteLine("Operador no válido.");
                                continue; // Salta al próximo ciclo sin guardar la operación.
                        }

                        Console.WriteLine("Resultado primer procedimiento: " + resultado1);
                        Console.WriteLine("Resultado segundo procedimiento: " + resultado2);
                        Console.WriteLine("TOTAL " + total);
                        
                        ultimaOperacion = $"{num1}/{num2} {operador} {num3}/{num4} = {total}";
                        break;

                    case 2:
                        
                        if (!string.IsNullOrEmpty(ultimaOperacion))
                        {
                            Console.WriteLine("Última Operación: " + ultimaOperacion);
                        }
                        else
                        {
                            Console.WriteLine("No hay operaciones realizadas aún.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Adiós!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 3);