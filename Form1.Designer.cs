namespace DrugWarz
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
            this.button = new System.Windows.Forms.Button();
            this.drugPriceListBox = new System.Windows.Forms.ListBox();
            this.amountToBuyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.amountToBuybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(13, 13);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Turn";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // drugPriceListBox
            // 
            this.drugPriceListBox.FormattingEnabled = true;
            this.drugPriceListBox.Location = new System.Drawing.Point(110, 13);
            this.drugPriceListBox.Name = "drugPriceListBox";
            this.drugPriceListBox.Size = new System.Drawing.Size(264, 95);
            this.drugPriceListBox.TabIndex = 1;
            // 
            // amountToBuyBox
            // 
            this.amountToBuyBox.Location = new System.Drawing.Point(110, 159);
            this.amountToBuyBox.Name = "amountToBuyBox";
            this.amountToBuyBox.Size = new System.Drawing.Size(100, 20);
            this.amountToBuyBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount To Buy";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 103);
            this.textBox2.TabIndex = 4;
            // 
            // amountToBuybutton
            // 
            this.amountToBuybutton.Location = new System.Drawing.Point(13, 159);
            this.amountToBuybutton.Name = "amountToBuybutton";
            this.amountToBuybutton.Size = new System.Drawing.Size(75, 23);
            this.amountToBuybutton.TabIndex = 5;
            this.amountToBuybutton.Text = "Buy";
            this.amountToBuybutton.UseVisualStyleBackColor = true;
            this.amountToBuybutton.Click += new System.EventHandler(this.amountToBuybutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 319);
            this.Controls.Add(this.amountToBuybutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountToBuyBox);
            this.Controls.Add(this.drugPriceListBox);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox drugPriceListBox;
        private System.Windows.Forms.TextBox amountToBuyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button amountToBuybutton;
    }
}

