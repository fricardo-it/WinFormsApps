namespace WinFormsFinalProject
{
    partial class TempConv
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTextFrom = new System.Windows.Forms.Label();
            this.lbTextTo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbValueTo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(192, 30);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "from C to F";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 62);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "from F to C";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // lbTextFrom
            // 
            this.lbTextFrom.AutoSize = true;
            this.lbTextFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextFrom.Location = new System.Drawing.Point(111, 153);
            this.lbTextFrom.Name = "lbTextFrom";
            this.lbTextFrom.Size = new System.Drawing.Size(22, 20);
            this.lbTextFrom.TabIndex = 5;
            this.lbTextFrom.Text = "C";
            // 
            // lbTextTo
            // 
            this.lbTextTo.AutoSize = true;
            this.lbTextTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTo.Location = new System.Drawing.Point(345, 153);
            this.lbTextTo.Name = "lbTextTo";
            this.lbTextTo.Size = new System.Drawing.Size(20, 20);
            this.lbTextTo.TabIndex = 6;
            this.lbTextTo.Text = "F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // lbMessage
            // 
            this.lbMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMessage.Location = new System.Drawing.Point(31, 218);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(423, 91);
            this.lbMessage.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(31, 332);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(102, 37);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(192, 332);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(102, 37);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "&Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(352, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbValueTo
            // 
            this.lbValueTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbValueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueTo.Location = new System.Drawing.Point(262, 119);
            this.lbValueTo.Name = "lbValueTo";
            this.lbValueTo.Size = new System.Drawing.Size(192, 30);
            this.lbValueTo.TabIndex = 3;
            this.lbValueTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TempConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbValueTo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTextTo);
            this.Controls.Add(this.lbTextFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TempConv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTextFrom;
        private System.Windows.Forms.Label lbTextTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbValueTo;
        private System.Windows.Forms.TextBox textBox1;
    }
}