namespace FractionCalculator
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnSubtraction = new System.Windows.Forms.RadioButton();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtResultNum = new System.Windows.Forms.TextBox();
            this.lblEqual = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstDen = new System.Windows.Forms.TextBox();
            this.txtSecondDen = new System.Windows.Forms.TextBox();
            this.txtResultDen = new System.Windows.Forms.TextBox();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(36, 53);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(32, 16);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(216, 53);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(54, 16);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(358, 53);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rbtnDivision);
            this.grpOperations.Controls.Add(this.rbtnMultiplication);
            this.grpOperations.Controls.Add(this.rbtnSubtraction);
            this.grpOperations.Controls.Add(this.rbtnAddition);
            this.grpOperations.Location = new System.Drawing.Point(106, 34);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(72, 157);
            this.grpOperations.TabIndex = 1;
            this.grpOperations.TabStop = false;
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(22, 120);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(32, 20);
            this.rbtnDivision.TabIndex = 5;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "/";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Location = new System.Drawing.Point(22, 87);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(33, 20);
            this.rbtnMultiplication.TabIndex = 4;
            this.rbtnMultiplication.TabStop = true;
            this.rbtnMultiplication.Text = "*";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            this.rbtnMultiplication.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbtnSubtraction
            // 
            this.rbtnSubtraction.AutoSize = true;
            this.rbtnSubtraction.Location = new System.Drawing.Point(22, 54);
            this.rbtnSubtraction.Name = "rbtnSubtraction";
            this.rbtnSubtraction.Size = new System.Drawing.Size(32, 20);
            this.rbtnSubtraction.TabIndex = 3;
            this.rbtnSubtraction.TabStop = true;
            this.rbtnSubtraction.Text = "-";
            this.rbtnSubtraction.UseVisualStyleBackColor = true;
            this.rbtnSubtraction.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Location = new System.Drawing.Point(22, 21);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(35, 20);
            this.rbtnAddition.TabIndex = 2;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "+";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            this.rbtnAddition.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(39, 99);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(41, 22);
            this.txtFirstNum.TabIndex = 0;
            this.txtFirstNum.Text = "0";
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(219, 99);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(41, 22);
            this.txtSecondNum.TabIndex = 6;
            this.txtSecondNum.Text = "0";
            // 
            // txtResultNum
            // 
            this.txtResultNum.Location = new System.Drawing.Point(361, 99);
            this.txtResultNum.Name = "txtResultNum";
            this.txtResultNum.ReadOnly = true;
            this.txtResultNum.Size = new System.Drawing.Size(41, 22);
            this.txtResultNum.TabIndex = 8;
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(304, 102);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(14, 16);
            this.lblEqual.TabIndex = 7;
            this.lblEqual.Text = "=";
            this.lblEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(39, 214);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(367, 48);
            this.btnOperation.TabIndex = 10;
            this.btnOperation.Text = "Perform Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "__________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "__________";
            // 
            // txtFirstDen
            // 
            this.txtFirstDen.Location = new System.Drawing.Point(39, 141);
            this.txtFirstDen.Name = "txtFirstDen";
            this.txtFirstDen.Size = new System.Drawing.Size(41, 22);
            this.txtFirstDen.TabIndex = 1;
            this.txtFirstDen.Text = "0";
            // 
            // txtSecondDen
            // 
            this.txtSecondDen.Location = new System.Drawing.Point(219, 141);
            this.txtSecondDen.Name = "txtSecondDen";
            this.txtSecondDen.Size = new System.Drawing.Size(41, 22);
            this.txtSecondDen.TabIndex = 7;
            this.txtSecondDen.Text = "0";
            // 
            // txtResultDen
            // 
            this.txtResultDen.Location = new System.Drawing.Point(361, 141);
            this.txtResultDen.Name = "txtResultDen";
            this.txtResultDen.ReadOnly = true;
            this.txtResultDen.Size = new System.Drawing.Size(41, 22);
            this.txtResultDen.TabIndex = 9;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 274);
            this.Controls.Add(this.txtResultDen);
            this.Controls.Add(this.txtSecondDen);
            this.Controls.Add(this.txtFirstDen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.txtResultNum);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnSubtraction;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtResultNum;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstDen;
        private System.Windows.Forms.TextBox txtSecondDen;
        private System.Windows.Forms.TextBox txtResultDen;
    }
}

