namespace lab4
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
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbMathF1 = new System.Windows.Forms.RadioButton();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.lblParam2 = new System.Windows.Forms.Label();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.txtParam3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(12, 12);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(96, 21);
            this.rbTriangle.TabIndex = 0;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbMathF1
            // 
            this.rbMathF1.AutoSize = true;
            this.rbMathF1.Location = new System.Drawing.Point(12, 39);
            this.rbMathF1.Name = "rbMathF1";
            this.rbMathF1.Size = new System.Drawing.Size(101, 21);
            this.rbMathF1.TabIndex = 1;
            this.rbMathF1.TabStop = true;
            this.rbMathF1.Text = "MathF_1";
            this.rbMathF1.UseVisualStyleBackColor = true;
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(119, 12);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(36, 17);
            this.lblParam1.TabIndex = 2;
            this.lblParam1.Text = "a/p:";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Location = new System.Drawing.Point(119, 39);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(21, 17);
            this.lblParam2.TabIndex = 3;
            this.lblParam2.Text = "b:";
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Location = new System.Drawing.Point(119, 66);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(21, 17);
            this.lblParam3.TabIndex = 4;
            this.lblParam3.Text = "c:";
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(161, 9);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(100, 22);
this.txtParam1.TabIndex = 5;
//
// txtParam2
//
this.txtParam2.Location = new System.Drawing.Point(161, 36);
this.txtParam2.Name = "txtParam2";
this.txtParam2.Size = new System.Drawing.Size(100, 22);
this.txtParam2.TabIndex = 6;
//
// txtParam3
//
this.txtParam3.Location = new System.Drawing.Point(161, 63);
this.txtParam3.Name = "txtParam3";
this.txtParam3.Size = new System.Drawing.Size(100, 22);
this.txtParam3.TabIndex = 7;
//
// btnCalculate
//
this.btnCalculate.Location = new System.Drawing.Point(12, 91);
this.btnCalculate.Name = "btnCalculate";
this.btnCalculate.Size = new System.Drawing.Size(249, 23);
this.btnCalculate.TabIndex = 8;
this.btnCalculate.Text = "Calculate";
this.btnCalculate.UseVisualStyleBackColor = true;
this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
//
// lblResult
//
this.lblResult.AutoSize = true;
this.lblResult.Location = new System.Drawing.Point(12, 126);
this.lblResult.Name = "lblResult";
this.lblResult.Size = new System.Drawing.Size(56, 17);
this.lblResult.TabIndex = 9;
this.lblResult.Text = "Result:";
//
// txtResult
//
this.txtResult.Location = new System.Drawing.Point(74, 123);
this.txtResult.Name = "txtResult";
this.txtResult.ReadOnly = true;
this.txtResult.Size = new System.Drawing.Size(187, 22);
this.txtResult.TabIndex = 10;
//
// Form1
//
this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(273, 160);
this.Controls.Add(this.txtResult);
this.Controls.Add(this.lblResult);
this.Controls.Add(this.btnCalculate);
this.Controls.Add(this.txtParam3);
this.Controls.Add(this.txtParam2);
this.Controls.Add(this.txtParam1);
this.Controls.Add(this.lblParam3);
this.Controls.Add(this.lblParam2);
this.Controls.Add(this.lblParam1);
this.Controls.Add(this.rbMathF1);
this.Controls.Add(this.rbTriangle);
this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
this.MaximizeBox = false;
this.Name = "Form1";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Text = "Expression Calculator";
this.ResumeLayout(false);
this.PerformLayout();
}

        #endregion
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbMathF1;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.Label lblParam3;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.TextBox txtParam3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}