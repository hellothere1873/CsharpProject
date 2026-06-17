namespace ErgasiaExaminouAnargyrosLeakos
{
    partial class SearchProductByID
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.switchmodebutton = new System.Windows.Forms.Button();
            this.chooseProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneralStockButton = new System.Windows.Forms.Button();
            this.EntireStockButton = new System.Windows.Forms.Button();
            this.DetailedStorage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID or Name: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current mode selected: Product Search";
            // 
            // switchmodebutton
            // 
            this.switchmodebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchmodebutton.Location = new System.Drawing.Point(481, 21);
            this.switchmodebutton.Name = "switchmodebutton";
            this.switchmodebutton.Size = new System.Drawing.Size(100, 25);
            this.switchmodebutton.TabIndex = 7;
            this.switchmodebutton.Text = "Switch mode";
            this.switchmodebutton.UseVisualStyleBackColor = true;
            this.switchmodebutton.Click += new System.EventHandler(this.SwitchModeButton_Click);
            // 
            // chooseProductButton
            // 
            this.chooseProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseProductButton.Location = new System.Drawing.Point(54, 165);
            this.chooseProductButton.Name = "chooseProductButton";
            this.chooseProductButton.Size = new System.Drawing.Size(174, 26);
            this.chooseProductButton.TabIndex = 8;
            this.chooseProductButton.Text = "Choose Product";
            this.chooseProductButton.UseVisualStyleBackColor = true;
            this.chooseProductButton.Click += new System.EventHandler(this.ChooseProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID WILL APPEAR HERE";
            // 
            // GeneralStockButton
            // 
            this.GeneralStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralStockButton.Location = new System.Drawing.Point(121, 300);
            this.GeneralStockButton.Name = "GeneralStockButton";
            this.GeneralStockButton.Size = new System.Drawing.Size(174, 52);
            this.GeneralStockButton.TabIndex = 10;
            this.GeneralStockButton.Text = "General Stock of chosen product";
            this.GeneralStockButton.UseVisualStyleBackColor = true;
            this.GeneralStockButton.Click += new System.EventHandler(this.GeneralStockButton_Click);
            // 
            // EntireStockButton
            // 
            this.EntireStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntireStockButton.Location = new System.Drawing.Point(301, 300);
            this.EntireStockButton.Name = "EntireStockButton";
            this.EntireStockButton.Size = new System.Drawing.Size(174, 52);
            this.EntireStockButton.TabIndex = 11;
            this.EntireStockButton.Text = "Entirety of stock of chosen product seperated by warehouses/locations";
            this.EntireStockButton.UseVisualStyleBackColor = true;
            this.EntireStockButton.Click += new System.EventHandler(this.EntireStockButton_Click);
            // 
            // DetailedStorage
            // 
            this.DetailedStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailedStorage.Location = new System.Drawing.Point(481, 300);
            this.DetailedStorage.Name = "DetailedStorage";
            this.DetailedStorage.Size = new System.Drawing.Size(174, 52);
            this.DetailedStorage.TabIndex = 12;
            this.DetailedStorage.Text = "Stock of chosen product in each location with specific location storage details";
            this.DetailedStorage.UseVisualStyleBackColor = true;
            this.DetailedStorage.Click += new System.EventHandler(this.DetailedStorage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose what to do with selected product";
            // 
            // SearchProductByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseProductButton);
            this.Controls.Add(this.switchmodebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeneralStockButton);
            this.Controls.Add(this.EntireStockButton);
            this.Controls.Add(this.DetailedStorage);
            this.Name = "SearchProductByID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchProductByID";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button switchmodebutton;
        private System.Windows.Forms.Button chooseProductButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GeneralStockButton;
        private System.Windows.Forms.Button EntireStockButton;
        private System.Windows.Forms.Button DetailedStorage;
        private System.Windows.Forms.Label label4;
    }
}

