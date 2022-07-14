
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lblsecond = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.Divide = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(22, 23);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(127, 20);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первое число";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.Location = new System.Drawing.Point(22, 87);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(126, 20);
            this.lblsecond.TabIndex = 1;
            this.lblsecond.Text = "Второе число";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(154, 23);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(154, 87);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(100, 20);
            this.txtsecond.TabIndex = 3;
            this.txtsecond.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtsecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtsecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // increment
            // 
            this.increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(22, 127);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(75, 58);
            this.increment.TabIndex = 4;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.Btn_click);
            // 
            // Decrement
            // 
            this.Decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.Location = new System.Drawing.Point(103, 127);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(75, 58);
            this.Decrement.TabIndex = 5;
            this.Decrement.Text = "-";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.Btn_click);
            // 
            // Increase
            // 
            this.Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase.Location = new System.Drawing.Point(184, 127);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(75, 58);
            this.Increase.TabIndex = 6;
            this.Increase.Text = "*";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.Btn_click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.Black;
            this.lblresult.Location = new System.Drawing.Point(21, 202);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(133, 25);
            this.lblresult.TabIndex = 9;
            this.lblresult.Text = "Результат :";
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(265, 127);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 58);
            this.Divide.TabIndex = 10;
            this.Divide.Text = ":";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Btn_click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(151, 202);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(27, 29);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(378, 463);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form3";
            this.Text = "Калькулятор";
            this.Click += new System.EventHandler(this.Btn_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label txtResult;
    }
}