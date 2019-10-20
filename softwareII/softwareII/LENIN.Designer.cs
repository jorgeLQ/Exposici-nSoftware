namespace softwareII
{
    partial class LENIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LENIN));
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(184, 137);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(175, 25);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Primer Número:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(184, 204);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(200, 25);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "Segundo Número:";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(184, 314);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(125, 25);
            this.lblR.TabIndex = 2;
            this.lblR.Text = "Resultado:";
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(395, 131);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 31);
            this.txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(395, 198);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 31);
            this.txtN2.TabIndex = 4;
            // 
            // txtN3
            // 
            this.txtN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(395, 308);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 31);
            this.txtN3.TabIndex = 5;
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(395, 253);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(113, 34);
            this.btnS.TabIndex = 6;
            this.btnS.Text = "SUMAR";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // LENIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Name = "LENIN";
            this.Text = "LENIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Button btnS;
    }
}

