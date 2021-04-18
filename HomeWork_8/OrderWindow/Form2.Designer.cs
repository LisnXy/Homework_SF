
namespace OrderWindow
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Client = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Detials = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_OrderDetial = new System.Windows.Forms.BindingSource(this.components);
            this.label_TotalCost = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button_DelDetial = new System.Windows.Forms.Button();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SingleCost = new System.Windows.Forms.NumericUpDown();
            this.button_AddDetial = new System.Windows.Forms.Button();
            this.label_Detial_TotalCostNumber = new System.Windows.Forms.Label();
            this.textBox_Detial_Name = new System.Windows.Forms.TextBox();
            this.label_Detial_TotalCost = new System.Windows.Forms.Label();
            this.label_Detial_Quantity = new System.Windows.Forms.Label();
            this.label_Detial_SingleCost = new System.Windows.Forms.Label();
            this.label_Detial_Name = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderDetial)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SingleCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(84, 55);
            this.label_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(47, 12);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "订单ID:";
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.Location = new System.Drawing.Point(84, 133);
            this.label_Cost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(47, 12);
            this.label_Cost.TabIndex = 1;
            this.label_Cost.Text = "总金额:";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Location = new System.Drawing.Point(96, 94);
            this.label_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(35, 12);
            this.label_Client.TabIndex = 2;
            this.label_Client.Text = "买家:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(134, 49);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(99, 21);
            this.textBox_ID.TabIndex = 3;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_Client
            // 
            this.textBox_Client.Location = new System.Drawing.Point(134, 89);
            this.textBox_Client.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Client.Name = "textBox_Client";
            this.textBox_Client.Size = new System.Drawing.Size(99, 21);
            this.textBox_Client.TabIndex = 4;
            this.textBox_Client.TextChanged += new System.EventHandler(this.textBox_Client_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView_Detials);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(427, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 430);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView_Detials
            // 
            this.dataGridView_Detials.AutoGenerateColumns = false;
            this.dataGridView_Detials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.singleCostDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridView_Detials.DataSource = this.bindingSource_OrderDetial;
            this.dataGridView_Detials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Detials.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Detials.Name = "dataGridView_Detials";
            this.dataGridView_Detials.RowTemplate.Height = 23;
            this.dataGridView_Detials.Size = new System.Drawing.Size(444, 430);
            this.dataGridView_Detials.TabIndex = 0;
            this.dataGridView_Detials.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_Detials_DataError);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // singleCostDataGridViewTextBoxColumn
            // 
            this.singleCostDataGridViewTextBoxColumn.DataPropertyName = "SingleCost";
            this.singleCostDataGridViewTextBoxColumn.HeaderText = "SingleCost";
            this.singleCostDataGridViewTextBoxColumn.Name = "singleCostDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // bindingSource_OrderDetial
            // 
            this.bindingSource_OrderDetial.DataSource = typeof(OrderManager.OrderDetial);
            // 
            // label_TotalCost
            // 
            this.label_TotalCost.AutoSize = true;
            this.label_TotalCost.Location = new System.Drawing.Point(136, 133);
            this.label_TotalCost.Name = "label_TotalCost";
            this.label_TotalCost.Size = new System.Drawing.Size(0, 12);
            this.label_TotalCost.TabIndex = 6;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button_DelDetial);
            this.groupBox.Controls.Add(this.numericUpDown_Quantity);
            this.groupBox.Controls.Add(this.numericUpDown_SingleCost);
            this.groupBox.Controls.Add(this.button_AddDetial);
            this.groupBox.Controls.Add(this.label_Detial_TotalCostNumber);
            this.groupBox.Controls.Add(this.textBox_Detial_Name);
            this.groupBox.Controls.Add(this.label_Detial_TotalCost);
            this.groupBox.Controls.Add(this.label_Detial_Quantity);
            this.groupBox.Controls.Add(this.label_Detial_SingleCost);
            this.groupBox.Controls.Add(this.label_Detial_Name);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 202);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(427, 228);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "订单明细";
            // 
            // button_DelDetial
            // 
            this.button_DelDetial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_DelDetial.Location = new System.Drawing.Point(285, 177);
            this.button_DelDetial.Name = "button_DelDetial";
            this.button_DelDetial.Size = new System.Drawing.Size(75, 23);
            this.button_DelDetial.TabIndex = 11;
            this.button_DelDetial.Text = "Delete";
            this.button_DelDetial.UseVisualStyleBackColor = false;
            this.button_DelDetial.Click += new System.EventHandler(this.button_DelDetial_Click);
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(130, 99);
            this.numericUpDown_Quantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(103, 21);
            this.numericUpDown_Quantity.TabIndex = 10;
            this.numericUpDown_Quantity.ValueChanged += new System.EventHandler(this.numericUpDown_Quantity_ValueChanged);
            // 
            // numericUpDown_SingleCost
            // 
            this.numericUpDown_SingleCost.DecimalPlaces = 2;
            this.numericUpDown_SingleCost.Location = new System.Drawing.Point(131, 64);
            this.numericUpDown_SingleCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_SingleCost.Name = "numericUpDown_SingleCost";
            this.numericUpDown_SingleCost.Size = new System.Drawing.Size(102, 21);
            this.numericUpDown_SingleCost.TabIndex = 9;
            this.numericUpDown_SingleCost.ValueChanged += new System.EventHandler(this.numericUpDown_SingleCost_ValueChanged);
            // 
            // button_AddDetial
            // 
            this.button_AddDetial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddDetial.Location = new System.Drawing.Point(285, 138);
            this.button_AddDetial.Name = "button_AddDetial";
            this.button_AddDetial.Size = new System.Drawing.Size(75, 23);
            this.button_AddDetial.TabIndex = 8;
            this.button_AddDetial.Text = "Add";
            this.button_AddDetial.UseVisualStyleBackColor = false;
            this.button_AddDetial.Click += new System.EventHandler(this.button_AddDetial_Click);
            // 
            // label_Detial_TotalCostNumber
            // 
            this.label_Detial_TotalCostNumber.AutoSize = true;
            this.label_Detial_TotalCostNumber.Location = new System.Drawing.Point(131, 138);
            this.label_Detial_TotalCostNumber.Name = "label_Detial_TotalCostNumber";
            this.label_Detial_TotalCostNumber.Size = new System.Drawing.Size(11, 12);
            this.label_Detial_TotalCostNumber.TabIndex = 7;
            this.label_Detial_TotalCostNumber.Text = "0";
            // 
            // textBox_Detial_Name
            // 
            this.textBox_Detial_Name.Location = new System.Drawing.Point(131, 27);
            this.textBox_Detial_Name.Name = "textBox_Detial_Name";
            this.textBox_Detial_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Detial_Name.TabIndex = 4;
            // 
            // label_Detial_TotalCost
            // 
            this.label_Detial_TotalCost.AutoSize = true;
            this.label_Detial_TotalCost.Location = new System.Drawing.Point(60, 138);
            this.label_Detial_TotalCost.Name = "label_Detial_TotalCost";
            this.label_Detial_TotalCost.Size = new System.Drawing.Size(65, 12);
            this.label_Detial_TotalCost.TabIndex = 3;
            this.label_Detial_TotalCost.Text = "TotalCost:";
            // 
            // label_Detial_Quantity
            // 
            this.label_Detial_Quantity.AutoSize = true;
            this.label_Detial_Quantity.Location = new System.Drawing.Point(66, 101);
            this.label_Detial_Quantity.Name = "label_Detial_Quantity";
            this.label_Detial_Quantity.Size = new System.Drawing.Size(59, 12);
            this.label_Detial_Quantity.TabIndex = 2;
            this.label_Detial_Quantity.Text = "Quantity:";
            // 
            // label_Detial_SingleCost
            // 
            this.label_Detial_SingleCost.AutoSize = true;
            this.label_Detial_SingleCost.Location = new System.Drawing.Point(60, 64);
            this.label_Detial_SingleCost.Name = "label_Detial_SingleCost";
            this.label_Detial_SingleCost.Size = new System.Drawing.Size(65, 12);
            this.label_Detial_SingleCost.TabIndex = 1;
            this.label_Detial_SingleCost.Text = "SigleCost:";
            // 
            // label_Detial_Name
            // 
            this.label_Detial_Name.AutoSize = true;
            this.label_Detial_Name.Location = new System.Drawing.Point(90, 30);
            this.label_Detial_Name.Name = "label_Detial_Name";
            this.label_Detial_Name.Size = new System.Drawing.Size(35, 12);
            this.label_Detial_Name.TabIndex = 0;
            this.label_Detial_Name.Text = "Name:";
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddOrder.Location = new System.Drawing.Point(285, 163);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(75, 23);
            this.button_AddOrder.TabIndex = 9;
            this.button_AddOrder.Text = "Add";
            this.button_AddOrder.UseVisualStyleBackColor = false;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 430);
            this.Controls.Add(this.button_AddOrder);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label_TotalCost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Client);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Client);
            this.Controls.Add(this.label_Cost);
            this.Controls.Add(this.label_ID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "创建订单";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderDetial)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SingleCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singleCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label label_ID;
        public System.Windows.Forms.Label label_Cost;
        public System.Windows.Forms.Label label_Client;
        public System.Windows.Forms.TextBox textBox_ID;
        public System.Windows.Forms.TextBox textBox_Client;
        public System.Windows.Forms.DataGridView dataGridView_Detials;
        public System.Windows.Forms.Label label_TotalCost;
        public System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.Label label_Detial_Name;
        public System.Windows.Forms.TextBox textBox_Detial_Name;
        public System.Windows.Forms.Label label_Detial_TotalCost;
        public System.Windows.Forms.Label label_Detial_Quantity;
        public System.Windows.Forms.Label label_Detial_SingleCost;
        public System.Windows.Forms.Button button_AddDetial;
        public System.Windows.Forms.Label label_Detial_TotalCostNumber;
        public System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        public System.Windows.Forms.NumericUpDown numericUpDown_SingleCost;
        public System.Windows.Forms.Button button_DelDetial;
        public System.Windows.Forms.Button button_AddOrder;
        public System.Windows.Forms.BindingSource bindingSource_OrderDetial;
        public System.Windows.Forms.Panel panel1;
    }
}