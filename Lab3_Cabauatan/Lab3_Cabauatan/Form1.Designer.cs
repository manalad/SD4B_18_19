namespace Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnint = new System.Windows.Forms.Button();
            this.btndouble = new System.Windows.Forms.Button();
            this.btnfloat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfnum = new System.Windows.Forms.TextBox();
            this.txtsnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPUTER CALCULATOR";
            // 
            // btnint
            // 
            this.btnint.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnint.Location = new System.Drawing.Point(12, 63);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(201, 36);
            this.btnint.TabIndex = 3;
            this.btnint.Text = "Integer";
            this.btnint.UseVisualStyleBackColor = true;
            // 
            // btndouble
            // 
            this.btndouble.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.btndouble.Location = new System.Drawing.Point(219, 63);
            this.btndouble.Name = "btndouble";
            this.btndouble.Size = new System.Drawing.Size(201, 36);
            this.btndouble.TabIndex = 4;
            this.btndouble.Text = "Double";
            this.btndouble.UseVisualStyleBackColor = true;
            this.btndouble.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnfloat
            // 
            this.btnfloat.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnfloat.Location = new System.Drawing.Point(426, 63);
            this.btnfloat.Name = "btnfloat";
            this.btnfloat.Size = new System.Drawing.Size(201, 36);
            this.btnfloat.TabIndex = 5;
            this.btnfloat.Text = "Float";
            this.btnfloat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Second Number";
            // 
            // txtfnum
            // 
            this.txtfnum.Location = new System.Drawing.Point(174, 142);
            this.txtfnum.Name = "txtfnum";
            this.txtfnum.Size = new System.Drawing.Size(123, 20);
            this.txtfnum.TabIndex = 8;
            // 
            // txtsnum
            // 
            this.txtsnum.Location = new System.Drawing.Point(504, 145);
            this.txtsnum.Name = "txtsnum";
            this.txtsnum.Size = new System.Drawing.Size(123, 20);
            this.txtsnum.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Compute Sum";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Next Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(219, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Close Form";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 387);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsnum);
            this.Controls.Add(this.txtfnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfloat);
            this.Controls.Add(this.btndouble);
            this.Controls.Add(this.btnint);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnint;
        private System.Windows.Forms.Button btndouble;
        private System.Windows.Forms.Button btnfloat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfnum;
        private System.Windows.Forms.TextBox txtsnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

