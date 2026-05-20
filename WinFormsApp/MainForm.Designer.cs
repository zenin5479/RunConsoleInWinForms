namespace WinFormsApp
{
   partial class MainForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         LabelActions = new System.Windows.Forms.Label();
         LabelNumbers = new System.Windows.Forms.Label();
         LabelError = new System.Windows.Forms.Label();
         LabelResult = new System.Windows.Forms.Label();
         ComboBoxOperation = new System.Windows.Forms.ComboBox();
         TextBoxNumbers = new System.Windows.Forms.TextBox();
         ButtonCalculate = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // LabelActions
         // 
         LabelActions.AutoSize = true;
         LabelActions.Location = new System.Drawing.Point(12, 44);
         LabelActions.Name = "LabelActions";
         LabelActions.Size = new System.Drawing.Size(58, 15);
         LabelActions.TabIndex = 13;
         LabelActions.Text = "Действия";
         // 
         // LabelNumbers
         // 
         LabelNumbers.AutoSize = true;
         LabelNumbers.Location = new System.Drawing.Point(12, 15);
         LabelNumbers.Name = "LabelNumbers";
         LabelNumbers.Size = new System.Drawing.Size(41, 15);
         LabelNumbers.TabIndex = 12;
         LabelNumbers.Text = "Числа";
         // 
         // LabelError
         // 
         LabelError.AutoSize = true;
         LabelError.Location = new System.Drawing.Point(12, 82);
         LabelError.Name = "LabelError";
         LabelError.Size = new System.Drawing.Size(59, 15);
         LabelError.TabIndex = 11;
         LabelError.Text = "Ошибка: ";
         // 
         // LabelResult
         // 
         LabelResult.AutoSize = true;
         LabelResult.Location = new System.Drawing.Point(12, 67);
         LabelResult.Name = "LabelResult";
         LabelResult.Size = new System.Drawing.Size(66, 15);
         LabelResult.TabIndex = 10;
         LabelResult.Text = "Результат: ";
         // 
         // ComboBoxOperation
         // 
         ComboBoxOperation.FormattingEnabled = true;
         ComboBoxOperation.Items.AddRange(new object[] { "Sum", "Multiply", "Average" });
         ComboBoxOperation.Location = new System.Drawing.Point(76, 41);
         ComboBoxOperation.Name = "ComboBoxOperation";
         ComboBoxOperation.Size = new System.Drawing.Size(146, 23);
         ComboBoxOperation.TabIndex = 9;
         // 
         // TextBoxNumbers
         // 
         TextBoxNumbers.Location = new System.Drawing.Point(59, 12);
         TextBoxNumbers.Name = "TextBoxNumbers";
         TextBoxNumbers.Size = new System.Drawing.Size(163, 23);
         TextBoxNumbers.TabIndex = 8;
         // 
         // ButtonCalculate
         // 
         ButtonCalculate.Location = new System.Drawing.Point(12, 159);
         ButtonCalculate.Name = "ButtonCalculate";
         ButtonCalculate.Size = new System.Drawing.Size(210, 30);
         ButtonCalculate.TabIndex = 7;
         ButtonCalculate.Text = "Вычислить";
         ButtonCalculate.UseVisualStyleBackColor = true;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(234, 201);
         Controls.Add(LabelActions);
         Controls.Add(LabelNumbers);
         Controls.Add(LabelError);
         Controls.Add(LabelResult);
         Controls.Add(ComboBoxOperation);
         Controls.Add(TextBoxNumbers);
         Controls.Add(ButtonCalculate);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Система обмена данными";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label LabelActions;
      private System.Windows.Forms.Label LabelNumbers;
      private System.Windows.Forms.Label LabelError;
      private System.Windows.Forms.Label LabelResult;
      private System.Windows.Forms.ComboBox ComboBoxOperation;
      private System.Windows.Forms.TextBox TextBoxNumbers;
      private System.Windows.Forms.Button ButtonCalculate;
   }
}