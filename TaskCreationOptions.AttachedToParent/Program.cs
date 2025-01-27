using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task parentTask = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Tarea padre iniciada: Preparación completa del plato.");

            // Tarea hija 1: Cortar las verduras
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea hija1 iniciada: Cortando las verduras.");
                Task.Delay(500).Wait();  
                Console.WriteLine("Tarea hija1 completada: Verduras cortadas.");
            }, TaskCreationOptions.AttachedToParent);

            // Tarea hija 2: Cocinar la pasta
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea hija2 iniciada: Cocinando la pasta.");
                Task.Delay(700).Wait();  
                Console.WriteLine("Tarea hija2 completada: Pasta cocida.");
            }, TaskCreationOptions.AttachedToParent);

            // Tarea hija 3: Preparar la salsa
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea hija3 iniciada: Preparando la salsa.");
                Task.Delay(600).Wait();  
                Console.WriteLine("Tarea hija3 completada: Salsa preparada.");
            }, TaskCreationOptions.AttachedToParent);

        });

        await parentTask;

        Console.WriteLine("Tarea padre completada: Plato preparado.");
    }
}
