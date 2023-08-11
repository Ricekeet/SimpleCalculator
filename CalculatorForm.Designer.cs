namespace SimpleCalculator
{
    partial class CalculatorForm
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnPeriod = new Button();
            btnEquals = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnClear = new Button();
            tbDisplay = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(17, 257);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Button_Handler;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(123, 257);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Button_Handler;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(229, 257);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Button_Handler;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(17, 363);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Button_Handler;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(123, 363);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Button_Handler;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(229, 363);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Button_Handler;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(17, 469);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Button_Handler;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(123, 469);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Button_Handler;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(229, 469);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Button_Handler;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(123, 575);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 100);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Button_Handler;
            // 
            // btnPeriod
            // 
            btnPeriod.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeriod.Location = new Point(17, 575);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(100, 100);
            btnPeriod.TabIndex = 10;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = true;
            btnPeriod.Click += Button_Handler;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(229, 575);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(246, 100);
            btnEquals.TabIndex = 11;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += Button_Handler;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(375, 151);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 100);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Button_Handler;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.Location = new Point(375, 257);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(100, 100);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += Button_Handler;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(375, 363);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(100, 100);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Button_Handler;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.Location = new Point(375, 469);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(100, 100);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Button_Handler;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(17, 151);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 100);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += Button_Handler;
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDisplay.Location = new Point(12, 12);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(463, 96);
            tbDisplay.TabIndex = 17;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 691);
            Controls.Add(tbDisplay);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btnPeriod);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "CalculatorForm";
            Text = "Calculator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnPeriod;
        private Button btnEquals;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnClear;
        private TextBox tbDisplay;
    }
}