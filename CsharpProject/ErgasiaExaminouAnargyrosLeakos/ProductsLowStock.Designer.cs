namespace ErgasiaExaminouAnargyrosLeakos
{
    partial class ProductsLowStock
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
            this.switchmodebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowProductsInLowStockButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // switchmodebutton
            // 
            this.switchmodebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchmodebutton.Location = new System.Drawing.Point(550, 21);
            this.switchmodebutton.Name = "switchmodebutton";
            this.switchmodebutton.Size = new System.Drawing.Size(100, 25);
            this.switchmodebutton.TabIndex = 13;
            this.switchmodebutton.Text = "Switch mode";
            this.switchmodebutton.UseVisualStyleBackColor = true;
            this.switchmodebutton.Click += new System.EventHandler(this.SwitchModeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current mode selected: Products in Low stock";
            // 
            // ShowProductsInLowStockButton
            // 
            this.ShowProductsInLowStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProductsInLowStockButton.Location = new System.Drawing.Point(300, 174);
            this.ShowProductsInLowStockButton.Name = "ShowProductsInLowStockButton";
            this.ShowProductsInLowStockButton.Size = new System.Drawing.Size(174, 52);
            this.ShowProductsInLowStockButton.TabIndex = 10;
            this.ShowProductsInLowStockButton.Text = "Show";
            this.ShowProductsInLowStockButton.UseVisualStyleBackColor = true;
            this.ShowProductsInLowStockButton.Click += new System.EventHandler(this.ShowProductsInLowStockButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 197);
            this.dataGridView1.TabIndex = 8;
            // 
            // ProductsLowStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.switchmodebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowProductsInLowStockButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsLowStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsLowStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button switchmodebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowProductsInLowStockButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}