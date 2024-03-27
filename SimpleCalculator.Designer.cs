namespace WinFormsFinalProject
{
    partial class SimpleCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(266, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(65, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(119, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 43);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(65, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 43);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 43);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 194);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(48, 43);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(65, 194);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(48, 43);
            this.btnPoint.TabIndex = 11;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPointClick);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(176, 47);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(48, 43);
            this.btnSum.TabIndex = 12;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(176, 96);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(48, 43);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(176, 145);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(48, 43);
            this.btnMul.TabIndex = 14;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(176, 194);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(48, 43);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(230, 47);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(48, 190);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 43);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(176, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 43);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(301, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(191, 236);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Historic:";
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.SimpleCalculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SimpleCalculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}