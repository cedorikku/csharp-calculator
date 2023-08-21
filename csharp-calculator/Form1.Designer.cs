namespace csharp_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBinaryToDecimal = new System.Windows.Forms.Button();
            this.btnDecimalToBinary = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtIndicator = new System.Windows.Forms.TextBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 79);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(409, 72);
            this.txtInput.TabIndex = 4;
            this.txtInput.TabStop = false;
            this.txtInput.Text = "0";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(9, 389);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 52);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.num_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(9, 331);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 52);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.num_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(9, 273);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 52);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.num_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalPoint.Location = new System.Drawing.Point(92, 389);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(80, 52);
            this.btnDecimalPoint.TabIndex = 21;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.num_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(92, 331);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 52);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.num_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(92, 273);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 52);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.num_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(175, 389);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(80, 52);
            this.btnExecute.TabIndex = 10;
            this.btnExecute.Text = "=";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(175, 331);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 52);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.num_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(175, 273);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 52);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.num_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Window;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(9, 215);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 52);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.num_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(92, 215);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 52);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.num_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(175, 215);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 52);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.num_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(258, 215);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 52);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(258, 273);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 52);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(258, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(258, 389);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(80, 52);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(175, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 52);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBinaryToDecimal
            // 
            this.btnBinaryToDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryToDecimal.Location = new System.Drawing.Point(341, 215);
            this.btnBinaryToDecimal.Name = "btnBinaryToDecimal";
            this.btnBinaryToDecimal.Size = new System.Drawing.Size(80, 110);
            this.btnBinaryToDecimal.TabIndex = 4;
            this.btnBinaryToDecimal.Text = "Binary to Decimal";
            this.btnBinaryToDecimal.UseVisualStyleBackColor = true;
            this.btnBinaryToDecimal.Click += new System.EventHandler(this.btnBinaryToDecimal_Click);
            // 
            // btnDecimalToBinary
            // 
            this.btnDecimalToBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalToBinary.Location = new System.Drawing.Point(341, 331);
            this.btnDecimalToBinary.Name = "btnDecimalToBinary";
            this.btnDecimalToBinary.Size = new System.Drawing.Size(80, 110);
            this.btnDecimalToBinary.TabIndex = 5;
            this.btnDecimalToBinary.Text = "Decimal to Binary";
            this.btnDecimalToBinary.UseVisualStyleBackColor = true;
            this.btnDecimalToBinary.Click += new System.EventHandler(this.btnDecimalToBinary_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(92, 157);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(80, 52);
            this.btnClearEntry.TabIndex = 1;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandard.Location = new System.Drawing.Point(341, 157);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(80, 52);
            this.btnStandard.TabIndex = 4;
            this.btnStandard.Text = "Standard";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(12, 14);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(123, 30);
            this.lblMode.TabIndex = 22;
            this.lblMode.Text = "modename";
            // 
            // txtIndicator
            // 
            this.txtIndicator.BackColor = System.Drawing.Color.White;
            this.txtIndicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIndicator.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIndicator.Enabled = false;
            this.txtIndicator.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndicator.Location = new System.Drawing.Point(12, 47);
            this.txtIndicator.Name = "txtIndicator";
            this.txtIndicator.ReadOnly = true;
            this.txtIndicator.Size = new System.Drawing.Size(409, 26);
            this.txtIndicator.TabIndex = 23;
            this.txtIndicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(258, 157);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(80, 52);
            this.btnBackspace.TabIndex = 3;
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(432, 449);
            this.Controls.Add(this.txtIndicator);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnDecimalToBinary);
            this.Controls.Add(this.btnBinaryToDecimal);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBinaryToDecimal;
        private System.Windows.Forms.Button btnDecimalToBinary;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtIndicator;
        private System.Windows.Forms.Button btnBackspace;
    }
}

