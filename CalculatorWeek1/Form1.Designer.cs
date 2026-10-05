namespace CalculatorWeek1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.MaskedTextBox();
            this.num3 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.RadioButton();
            this.Subtraction = new System.Windows.Forms.RadioButton();
            this.Multiplication = new System.Windows.Forms.RadioButton();
            this.Division = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(202, 102);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 26);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(202, 175);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 26);
            this.num2.TabIndex = 1;
            this.num2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.num2_MaskInputRejected);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(202, 262);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 26);
            this.num3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "number 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "result";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calculateBtn.Location = new System.Drawing.Point(333, 329);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(155, 39);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(542, 105);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(43, 24);
            this.Addition.TabIndex = 7;
            this.Addition.TabStop = true;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.CheckedChanged += new System.EventHandler(this.Addition_CheckedChanged);
            // 
            // Subtraction
            // 
            this.Subtraction.AutoSize = true;
            this.Subtraction.Location = new System.Drawing.Point(540, 155);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(39, 24);
            this.Subtraction.TabIndex = 8;
            this.Subtraction.TabStop = true;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Multiplication
            // 
            this.Multiplication.AutoSize = true;
            this.Multiplication.Location = new System.Drawing.Point(542, 206);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(40, 24);
            this.Multiplication.TabIndex = 9;
            this.Multiplication.TabStop = true;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.CheckedChanged += new System.EventHandler(this.Multiplication_CheckedChanged);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(542, 251);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(38, 24);
            this.Division.TabIndex = 10;
            this.Division.TabStop = true;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.CheckedChanged += new System.EventHandler(this.Division_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Operator";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.MaskedTextBox num2;
        private System.Windows.Forms.MaskedTextBox num3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.RadioButton Subtraction;
        private System.Windows.Forms.RadioButton Multiplication;
        private System.Windows.Forms.RadioButton Division;
        private System.Windows.Forms.Label label4;
    }
}

