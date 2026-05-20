using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SharedStorage
{
   public class StreamSharedStorage : IDisposable
   {
      private readonly Process _process;

      public StreamSharedStorage(string executablePath = "ConsoleAppFour")
      {
         _process = new Process();
         _process.StartInfo.FileName = executablePath;
         // Обязательно для перенаправления
         _process.StartInfo.UseShellExecute = false;
         _process.StartInfo.RedirectStandardInput = true;
         _process.StartInfo.RedirectStandardOutput = true;
         // Не перехватываем ошибки
         _process.StartInfo.RedirectStandardError = false;
         // Показываем окно
         _process.StartInfo.CreateNoWindow = false;
         // Явно обычное окно
         _process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
         _process.Start();
      }

      public CalculationResponse SendRequest(CalculationRequest request)
      {
         if (_process.HasExited)
         {
            throw new InvalidOperationException("Консольное приложение завершилось");
         }

         string requestJson = JsonConvert.SerializeObject(request);
         _process.StandardInput.WriteLine(requestJson);
         _process.StandardInput.Flush();

         string responseLine = _process.StandardOutput.ReadLine();
         if (responseLine == null)
         {
            throw new InvalidOperationException("Не получен ответ от консоли");
         }

         CalculationResponse response = JsonConvert.DeserializeObject<CalculationResponse>(responseLine);
         if (response == null)
         {
            throw new InvalidOperationException("Некорректный JSON ответа");
         }

         return response;
      }

      public void Shutdown()
      {
         if (!_process.HasExited)
         {
            _process.StandardInput.WriteLine("exit");
            _process.StandardInput.Close();
            _process.WaitForExit(3000);
         }
      }

      public void Dispose()
      {
         Shutdown();
         _process.Dispose();
      }
   }
}