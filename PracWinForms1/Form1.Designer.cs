namespace PracWinForms1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.ArrayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SumButton.Location = new System.Drawing.Point(62, 135);
            this.SumButton.Margin = new System.Windows.Forms.Padding(2);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(188, 76);
            this.SumButton.TabIndex = 0;
            this.SumButton.Text = "Сумма";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductButton.Location = new System.Drawing.Point(62, 242);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(188, 76);
            this.ProductButton.TabIndex = 1;
            this.ProductButton.Text = "Произведение";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // MinButton
            // 
            this.MinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinButton.Location = new System.Drawing.Point(62, 450);
            this.MinButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(188, 76);
            this.MinButton.TabIndex = 2;
            this.MinButton.Text = "Минимум";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxButton.Location = new System.Drawing.Point(62, 348);
            this.MaxButton.Margin = new System.Windows.Forms.Padding(2);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(188, 76);
            this.MaxButton.TabIndex = 2;
            this.MaxButton.Text = "Максимум";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // SumTextBox
            // 
            this.SumTextBox.AllowDrop = true;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(393, 161);
            this.SumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(180, 29);
            this.SumTextBox.TabIndex = 3;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.AllowDrop = true;
            this.ProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductTextBox.Location = new System.Drawing.Point(393, 267);
            this.ProductTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(180, 29);
            this.ProductTextBox.TabIndex = 4;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.AllowDrop = true;
            this.MaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTextBox.Location = new System.Drawing.Point(393, 373);
            this.MaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(180, 29);
            this.MaxTextBox.TabIndex = 5;
            // 
            // MinTextBox
            // 
            this.MinTextBox.AllowDrop = true;
            this.MinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTextBox.Location = new System.Drawing.Point(393, 475);
            this.MinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(180, 29);
            this.MinTextBox.TabIndex = 6;
            // 
            // ArrayTextBox
            // 
            this.ArrayTextBox.AllowDrop = true;
            this.ArrayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayTextBox.Location = new System.Drawing.Point(92, 83);
            this.ArrayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ArrayTextBox.Name = "ArrayTextBox";
            this.ArrayTextBox.Size = new System.Drawing.Size(468, 29);
            this.ArrayTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = " Введите массив чисел через запятую:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(636, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrayTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.SumButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox ArrayTextBox;
        private System.Windows.Forms.Label label1;
    }
}

