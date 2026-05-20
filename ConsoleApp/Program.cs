using Newtonsoft.Json;
using SharedStorage;
using System;

namespace ConsoleApp
{
   class Program
   {
      static void Main()
      {
         Console.Error.WriteLine("Запущен калькулятор. Ждем запросов в формате JSON...");
         Console.Error.WriteLine("Отправьте команду exit, чтобы завершить работу");

         while (true)
         {
            string line = Console.ReadLine();
            if (line == null || line.Trim().ToLower() == "exit")
            {
               break;
            }

            try
            {
               CalculationRequest request = JsonConvert.DeserializeObject<CalculationRequest>(line);
               CalculationResponse response = Calculate(request);
               Console.WriteLine(JsonConvert.SerializeObject(response));
            }
            catch (Exception ex)
            {
               CalculationResponse errorResponse = new CalculationResponse { Error = ex.Message };
               Console.WriteLine(JsonConvert.SerializeObject(errorResponse));
            }
         }
      }

      static CalculationResponse Calculate(CalculationRequest request)
      {
         if (request == null || request.Numbers == null || request.Numbers.Length == 0)
         {
            return new CalculationResponse { Error = "Некорректные входные данные" };
         }

         double result = 0;
         if (request.Operation.ToLower() == "sum")
         {
            for (int i = 0; i < request.Numbers.Length; i++)
            {
               double n = request.Numbers[i];
               result += n;
            }
         }
         else if (request.Operation.ToLower() == "multiply")
         {
            result = 1;
            for (int i = 0; i < request.Numbers.Length; i++)
            {
               double n = request.Numbers[i];
               result *= n;
            }
         }
         else if (request.Operation.ToLower() == "average")
         {
            for (int i = 0; i < request.Numbers.Length; i++)
            {
               double n = request.Numbers[i];
               result += n;
            }

            result /= request.Numbers.Length;
         }
         else
         {
            return new CalculationResponse { Error = string.Format("Неизвестная операция: {0}", request.Operation) };
         }

         return new CalculationResponse { Result = result };
      }
   }
}