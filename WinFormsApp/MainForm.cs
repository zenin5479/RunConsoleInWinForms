using System;
using System.Windows.Forms;
using SharedStorage;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         ComboBoxOperation.SelectedIndex = 0;
      }

      private void ButtonCalculate_Click(object sender, EventArgs e)
      {
         LabelResult.Text = "";
         LabelError.Text = "";

         string[] parts = TextBoxNumbers.Text.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
         double[] numbers;
         try
         {
            numbers = Array.ConvertAll(parts, double.Parse);
         }
         catch
         {
            LabelError.Text = @"Ошибка: введите числа через пробел или запятую";
            return;
         }

         CalculationRequest request = new CalculationRequest
         {
            Numbers = numbers,
            Operation = ComboBoxOperation.SelectedItem.ToString()
         };

         try
         {
            using (StreamSharedStorage storage = new StreamSharedStorage("ConsoleApp.exe"))
            {
               CalculationResponse response = storage.SendRequest(request);

               if (!string.IsNullOrEmpty(response.Error))
               {
                  LabelError.Text = @"Ошибка: " + response.Error;
               }
               else
               {
                  LabelResult.Text = @"Результат: " + response.Result;
               }
            }
         }
         catch (Exception ex)
         {
            LabelError.Text = @"Ошибка запуска/обмена: " + ex.Message;
         }
      }
   }
}