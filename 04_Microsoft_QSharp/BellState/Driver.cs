/*
    File name: Driver.qs
    Source: https://docs.microsoft.com/en-us/quantum/quantum-writeaquantumprogram?view=qsharp-preview&tabs=tabid-vscode
    Written and Edited by: Anton Karazeev <a.karazeev@rqc.ru>

    This file is part of Quantum Computing Seminars project (https://github.com/RQC-QApp/Seminars)
 */

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            /*
                Объявление переменной `sim`, отвечающей за квантовый симулятор.
                После выхода из блока `using` память, выделенная под `sim`, освобождается.
             */
            using (var sim = new QuantumSimulator())
            {
                /*
                    Объявление массива из двух элементов типа `Result`:
                    `Zero` и `One`.
                 */
                Result[] initials = new Result[] { Result.Zero, Result.One };

                /*
                    Для каждого элемента массива `initials` провести 1000
                    экспериментов программы `BellTest`.
                 */
                foreach (Result initial in initials)
                {
                    /*
                        `BellTest` представляет собой класс, у которого есть
                        метод `Run` - для запуска эксперимента на симуляторе `sim`.

                        Следующими аргументами передаются параметры для самой
                        операции `BellTest` из Q#-файла `Bell.qs` - число
                        экспериментов и начальное состояние нулевого кубита.
                     */
                    var res = BellTest.Run(sim, 1000, initial).Result;

                    /*
                        Переменная `res` - это кортеж (tuple) из:
                        * числа измерений, в которых был получен ноль (|0>),
                        * числа измерений, в которых была получена единица (|1>),
                        * числа измерений, в которых состояния нулевого и первого кубитов совпадают.
                     */
                    var (numZeros, numOnes, agree) = res;

                    /*
                        Вывод на экран.
                    */
                    System.Console.WriteLine(
                        $"Init: {initial,-4} 0s={numZeros,-4} 1s={numOnes,-4} agree={agree,-4}"
                    );
                }
            }

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}