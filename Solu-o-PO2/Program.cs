using System;
using Atividade_PO2;



bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("Adicione o metro para conversão:");
        int metro = int.Parse(Console.ReadLine());


        MeToMi conversao = new MeToMi();

        Console.WriteLine(conversao.ConverterMetroParaMilimetro(metro));

        prossiga = false;

    }
    catch (FormatException e)
    {
        Console.WriteLine("Informe apenas numeros");
    }
    catch (DivideByZeroException e) { }

} while (prossiga);