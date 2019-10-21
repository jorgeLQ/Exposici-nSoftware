namespace Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.resp = new System.Windows.Forms.Label();
            this.btnresta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 294);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(179, 121);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(103, 17);
            this.num1.TabIndex = 3;
            this.num1.Text = "Primer Número";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(179, 203);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(119, 17);
            this.num2.TabIndex = 4;
            this.num2.Text = "Segundo Número";
            // 
            // resp
            // 
            this.resp.AutoSize = true;
            this.resp.Location = new System.Drawing.Point(179, 297);
            this.resp.Name = "resp";
            this.resp.Size = new System.Drawing.Size(91, 17);
            this.resp.TabIndex = 5;
            this.resp.Text = "RESPUESTA";
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(348, 392);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "RESTA";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.resp);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "RESTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label resp;
        private System.Windows.Forms.Button btnresta;
    }
}

