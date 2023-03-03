namespace Cash_Register
{
    partial class cashRegister
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
            this.shopName = new System.Windows.Forms.Label();
            this.savannahInput = new System.Windows.Forms.TextBox();
            this.derekInput = new System.Windows.Forms.TextBox();
            this.danielInput = new System.Windows.Forms.TextBox();
            this.savannahLabel = new System.Windows.Forms.Label();
            this.derekLabel = new System.Windows.Forms.Label();
            this.danielLabel = new System.Windows.Forms.Label();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.TextBox();
            this.totalOwed = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.reciept = new System.Windows.Forms.Button();
            this.receiptPrinter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shopName
            // 
            this.shopName.BackColor = System.Drawing.Color.Red;
            this.shopName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopName.ForeColor = System.Drawing.Color.White;
            this.shopName.Location = new System.Drawing.Point(0, 0);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(457, 47);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "Ingrid Gropps Child Shop";
            this.shopName.Click += new System.EventHandler(this.label1_Click);
            // 
            // savannahInput
            // 
            this.savannahInput.Location = new System.Drawing.Point(96, 53);
            this.savannahInput.Name = "savannahInput";
            this.savannahInput.Size = new System.Drawing.Size(74, 20);
            this.savannahInput.TabIndex = 1;
            this.savannahInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // derekInput
            // 
            this.derekInput.Location = new System.Drawing.Point(96, 79);
            this.derekInput.Name = "derekInput";
            this.derekInput.Size = new System.Drawing.Size(74, 20);
            this.derekInput.TabIndex = 2;
            // 
            // danielInput
            // 
            this.danielInput.Location = new System.Drawing.Point(96, 105);
            this.danielInput.Name = "danielInput";
            this.danielInput.Size = new System.Drawing.Size(74, 20);
            this.danielInput.TabIndex = 3;
            // 
            // savannahLabel
            // 
            this.savannahLabel.AutoSize = true;
            this.savannahLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savannahLabel.Location = new System.Drawing.Point(12, 54);
            this.savannahLabel.Name = "savannahLabel";
            this.savannahLabel.Size = new System.Drawing.Size(78, 16);
            this.savannahLabel.TabIndex = 4;
            this.savannahLabel.Text = "Savannahs:";
            // 
            // derekLabel
            // 
            this.derekLabel.AutoSize = true;
            this.derekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derekLabel.Location = new System.Drawing.Point(36, 79);
            this.derekLabel.Name = "derekLabel";
            this.derekLabel.Size = new System.Drawing.Size(54, 16);
            this.derekLabel.TabIndex = 5;
            this.derekLabel.Text = "Dereks:";
            this.derekLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // danielLabel
            // 
            this.danielLabel.AutoSize = true;
            this.danielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danielLabel.Location = new System.Drawing.Point(34, 105);
            this.danielLabel.Name = "danielLabel";
            this.danielLabel.Size = new System.Drawing.Size(56, 16);
            this.danielLabel.TabIndex = 6;
            this.danielLabel.Text = "Daniels:";
            this.danielLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // calculateTotal
            // 
            this.calculateTotal.BackColor = System.Drawing.Color.Gray;
            this.calculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotal.ForeColor = System.Drawing.Color.White;
            this.calculateTotal.Location = new System.Drawing.Point(15, 131);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(155, 23);
            this.calculateTotal.TabIndex = 7;
            this.calculateTotal.Text = "Calculate Totals";
            this.calculateTotal.UseVisualStyleBackColor = false;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(31, 157);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(59, 16);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(57, 177);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(33, 16);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(49, 201);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 16);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Silver;
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtotalOutput.Location = new System.Drawing.Point(96, 160);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(74, 13);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.TextChanged += new System.EventHandler(this.subtotalAmount_TextChanged);
            // 
            // totalOwed
            // 
            this.totalOwed.BackColor = System.Drawing.Color.Silver;
            this.totalOwed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalOwed.Location = new System.Drawing.Point(96, 204);
            this.totalOwed.Name = "totalOwed";
            this.totalOwed.Size = new System.Drawing.Size(74, 13);
            this.totalOwed.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Silver;
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taxOutput.Location = new System.Drawing.Point(96, 180);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(74, 13);
            this.taxOutput.TabIndex = 13;
            // 
            // reciept
            // 
            this.reciept.BackColor = System.Drawing.Color.Gray;
            this.reciept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciept.ForeColor = System.Drawing.Color.White;
            this.reciept.Location = new System.Drawing.Point(15, 234);
            this.reciept.Name = "reciept";
            this.reciept.Size = new System.Drawing.Size(155, 23);
            this.reciept.TabIndex = 21;
            this.reciept.Text = "Print Receipt";
            this.reciept.UseVisualStyleBackColor = false;
            this.reciept.Click += new System.EventHandler(this.reciept_Click);
            // 
            // receiptPrinter
            // 
            this.receiptPrinter.BackColor = System.Drawing.Color.Silver;
            this.receiptPrinter.Location = new System.Drawing.Point(189, 54);
            this.receiptPrinter.Name = "receiptPrinter";
            this.receiptPrinter.Size = new System.Drawing.Size(247, 191);
            this.receiptPrinter.TabIndex = 22;
            this.receiptPrinter.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(448, 334);
            this.Controls.Add(this.receiptPrinter);
            this.Controls.Add(this.reciept);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOwed);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.danielLabel);
            this.Controls.Add(this.derekLabel);
            this.Controls.Add(this.savannahLabel);
            this.Controls.Add(this.danielInput);
            this.Controls.Add(this.derekInput);
            this.Controls.Add(this.savannahInput);
            this.Controls.Add(this.shopName);
            this.Name = "cashRegister";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.TextBox savannahInput;
        private System.Windows.Forms.TextBox derekInput;
        private System.Windows.Forms.TextBox danielInput;
        private System.Windows.Forms.Label savannahLabel;
        private System.Windows.Forms.Label derekLabel;
        private System.Windows.Forms.Label danielLabel;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox subtotalOutput;
        private System.Windows.Forms.TextBox totalOwed;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.Button reciept;
        private System.Windows.Forms.Label receiptPrinter;
    }
}

