namespace Calculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearCurrent = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.lblAction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnNumPad6 = new System.Windows.Forms.Button();
            this.btnNumPad9 = new System.Windows.Forms.Button();
            this.btnNumPad5 = new System.Windows.Forms.Button();
            this.btnNumPad8 = new System.Windows.Forms.Button();
            this.btnNumPad4 = new System.Windows.Forms.Button();
            this.btnNumPad7 = new System.Windows.Forms.Button();
            this.btnNumPad3 = new System.Windows.Forms.Button();
            this.btnNumPad2 = new System.Windows.Forms.Button();
            this.btnNumPad1 = new System.Windows.Forms.Button();
            this.btnNumPad0 = new System.Windows.Forms.Button();
            this.btnDecimalMark = new System.Windows.Forms.Button();
            this.btnDeleteLastDigit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(168, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(91, 35);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(110, 20);
            this.textBoxNum1.TabIndex = 1;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNum1.Click += new System.EventHandler(this.textBoxNum1_Click);
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
            this.textBoxNum1.Enter += new System.EventHandler(this.textBoxNum1_Enter);
            this.textBoxNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(91, 81);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(110, 20);
            this.textBoxNum2.TabIndex = 2;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNum2.TextChanged += new System.EventHandler(this.textBoxNum2_TextChanged);
            this.textBoxNum2.Enter += new System.EventHandler(this.textBoxNum2_Enter);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(227, 81);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(110, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOperation.Location = new System.Drawing.Point(187, 58);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(0, 20);
            this.lblOperation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubstract.Location = new System.Drawing.Point(168, 170);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(34, 34);
            this.btnSubstract.TabIndex = 6;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(208, 130);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(34, 34);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(208, 170);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(34, 34);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPercent.Location = new System.Drawing.Point(168, 210);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(34, 34);
            this.btnPercent.TabIndex = 9;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqrt.Location = new System.Drawing.Point(208, 210);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(34, 34);
            this.btnSqrt.TabIndex = 10;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(287, 130);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(34, 114);
            this.btnResult.TabIndex = 11;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(168, 248);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(74, 34);
            this.btnClearAll.TabIndex = 12;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearCurrent
            // 
            this.btnClearCurrent.Location = new System.Drawing.Point(248, 248);
            this.btnClearCurrent.Name = "btnClearCurrent";
            this.btnClearCurrent.Size = new System.Drawing.Size(34, 34);
            this.btnClearCurrent.TabIndex = 14;
            this.btnClearCurrent.Text = "CE";
            this.btnClearCurrent.UseVisualStyleBackColor = true;
            this.btnClearCurrent.Click += new System.EventHandler(this.btnClearCurrent_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(248, 210);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(34, 34);
            this.btnReciprocal.TabIndex = 16;
            this.btnReciprocal.Text = "R";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Location = new System.Drawing.Point(248, 170);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(34, 34);
            this.btnNegate.TabIndex = 15;
            this.btnNegate.Text = "N";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(226, 65);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 13);
            this.lblAction.TabIndex = 17;
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAction.Click += new System.EventHandler(this.lblAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Enter number:";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(91, 19);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(0, 13);
            this.lblNum1.TabIndex = 20;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(91, 65);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(0, 13);
            this.lblNum2.TabIndex = 21;
            // 
            // btnNumPad6
            // 
            this.btnNumPad6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad6.Location = new System.Drawing.Point(108, 170);
            this.btnNumPad6.Name = "btnNumPad6";
            this.btnNumPad6.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad6.TabIndex = 27;
            this.btnNumPad6.Text = "6";
            this.btnNumPad6.UseVisualStyleBackColor = true;
            this.btnNumPad6.Click += new System.EventHandler(this.btnNumPad6_Click);
            // 
            // btnNumPad9
            // 
            this.btnNumPad9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad9.Location = new System.Drawing.Point(108, 130);
            this.btnNumPad9.Name = "btnNumPad9";
            this.btnNumPad9.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad9.TabIndex = 26;
            this.btnNumPad9.Text = "9";
            this.btnNumPad9.UseVisualStyleBackColor = true;
            this.btnNumPad9.Click += new System.EventHandler(this.btnNumPad9_Click);
            // 
            // btnNumPad5
            // 
            this.btnNumPad5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad5.Location = new System.Drawing.Point(68, 170);
            this.btnNumPad5.Name = "btnNumPad5";
            this.btnNumPad5.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad5.TabIndex = 25;
            this.btnNumPad5.Text = "5";
            this.btnNumPad5.UseVisualStyleBackColor = true;
            this.btnNumPad5.Click += new System.EventHandler(this.btnNumPad5_Click);
            // 
            // btnNumPad8
            // 
            this.btnNumPad8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad8.Location = new System.Drawing.Point(69, 130);
            this.btnNumPad8.Name = "btnNumPad8";
            this.btnNumPad8.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad8.TabIndex = 24;
            this.btnNumPad8.Text = "8";
            this.btnNumPad8.UseVisualStyleBackColor = true;
            this.btnNumPad8.Click += new System.EventHandler(this.btnNumPad8_Click);
            // 
            // btnNumPad4
            // 
            this.btnNumPad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad4.Location = new System.Drawing.Point(28, 170);
            this.btnNumPad4.Name = "btnNumPad4";
            this.btnNumPad4.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad4.TabIndex = 23;
            this.btnNumPad4.Text = "4";
            this.btnNumPad4.UseVisualStyleBackColor = true;
            this.btnNumPad4.Click += new System.EventHandler(this.btnNumPad4_Click);
            // 
            // btnNumPad7
            // 
            this.btnNumPad7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad7.Location = new System.Drawing.Point(28, 130);
            this.btnNumPad7.Name = "btnNumPad7";
            this.btnNumPad7.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad7.TabIndex = 22;
            this.btnNumPad7.Text = "7";
            this.btnNumPad7.UseVisualStyleBackColor = true;
            this.btnNumPad7.Click += new System.EventHandler(this.btnNumPad7_Click);
            // 
            // btnNumPad3
            // 
            this.btnNumPad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad3.Location = new System.Drawing.Point(108, 210);
            this.btnNumPad3.Name = "btnNumPad3";
            this.btnNumPad3.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad3.TabIndex = 30;
            this.btnNumPad3.Text = "3";
            this.btnNumPad3.UseVisualStyleBackColor = true;
            this.btnNumPad3.Click += new System.EventHandler(this.btnNumPad3_Click);
            // 
            // btnNumPad2
            // 
            this.btnNumPad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad2.Location = new System.Drawing.Point(68, 210);
            this.btnNumPad2.Name = "btnNumPad2";
            this.btnNumPad2.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad2.TabIndex = 29;
            this.btnNumPad2.Text = "2";
            this.btnNumPad2.UseVisualStyleBackColor = true;
            this.btnNumPad2.Click += new System.EventHandler(this.btnNumPad2_Click);
            // 
            // btnNumPad1
            // 
            this.btnNumPad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad1.Location = new System.Drawing.Point(28, 210);
            this.btnNumPad1.Name = "btnNumPad1";
            this.btnNumPad1.Size = new System.Drawing.Size(34, 34);
            this.btnNumPad1.TabIndex = 28;
            this.btnNumPad1.Text = "1";
            this.btnNumPad1.UseVisualStyleBackColor = true;
            this.btnNumPad1.Click += new System.EventHandler(this.btnNumPad1_Click);
            // 
            // btnNumPad0
            // 
            this.btnNumPad0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNumPad0.Location = new System.Drawing.Point(28, 248);
            this.btnNumPad0.Name = "btnNumPad0";
            this.btnNumPad0.Size = new System.Drawing.Size(75, 34);
            this.btnNumPad0.TabIndex = 31;
            this.btnNumPad0.Text = "0";
            this.btnNumPad0.UseVisualStyleBackColor = true;
            this.btnNumPad0.Click += new System.EventHandler(this.btnNumPad0_Click);
            // 
            // btnDecimalMark
            // 
            this.btnDecimalMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecimalMark.Location = new System.Drawing.Point(108, 248);
            this.btnDecimalMark.Name = "btnDecimalMark";
            this.btnDecimalMark.Size = new System.Drawing.Size(34, 34);
            this.btnDecimalMark.TabIndex = 32;
            this.btnDecimalMark.Text = ",";
            this.btnDecimalMark.UseVisualStyleBackColor = true;
            this.btnDecimalMark.Click += new System.EventHandler(this.btnDecimalMark_Click);
            // 
            // btnDeleteLastDigit
            // 
            this.btnDeleteLastDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteLastDigit.Location = new System.Drawing.Point(248, 130);
            this.btnDeleteLastDigit.Name = "btnDeleteLastDigit";
            this.btnDeleteLastDigit.Size = new System.Drawing.Size(34, 34);
            this.btnDeleteLastDigit.TabIndex = 33;
            this.btnDeleteLastDigit.Text = "←";
            this.btnDeleteLastDigit.UseVisualStyleBackColor = true;
            this.btnDeleteLastDigit.Click += new System.EventHandler(this.btnDeleteLastDigit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 314);
            this.Controls.Add(this.btnDeleteLastDigit);
            this.Controls.Add(this.btnDecimalMark);
            this.Controls.Add(this.btnNumPad0);
            this.Controls.Add(this.btnNumPad3);
            this.Controls.Add(this.btnNumPad2);
            this.Controls.Add(this.btnNumPad1);
            this.Controls.Add(this.btnNumPad6);
            this.Controls.Add(this.btnNumPad9);
            this.Controls.Add(this.btnNumPad5);
            this.Controls.Add(this.btnNumPad8);
            this.Controls.Add(this.btnNumPad4);
            this.Controls.Add(this.btnNumPad7);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnClearCurrent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearCurrent;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnNumPad6;
        private System.Windows.Forms.Button btnNumPad9;
        private System.Windows.Forms.Button btnNumPad5;
        private System.Windows.Forms.Button btnNumPad8;
        private System.Windows.Forms.Button btnNumPad4;
        private System.Windows.Forms.Button btnNumPad7;
        private System.Windows.Forms.Button btnNumPad3;
        private System.Windows.Forms.Button btnNumPad2;
        private System.Windows.Forms.Button btnNumPad1;
        private System.Windows.Forms.Button btnNumPad0;
        private System.Windows.Forms.Button btnDecimalMark;
        private System.Windows.Forms.Button btnDeleteLastDigit;
    }
}

