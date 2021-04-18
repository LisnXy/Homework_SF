
namespace OrderWindow
{
    partial class Manager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.button_DelOrder = new System.Windows.Forms.Button();
            this.button_ReviseOrder = new System.Windows.Forms.Button();
            this.button_InportOrder = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_ExportOrder = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Order = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.comboBox_Query = new System.Windows.Forms.ComboBox();
            this.button_Query = new System.Windows.Forms.Button();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.groupBox_Query = new System.Windows.Forms.GroupBox();
            this.button_Restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.panel_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Order)).BeginInit();
            this.groupBox_Operations.SuspendLayout();
            this.groupBox_Query.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.AutoGenerateColumns = false;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn});
            this.dataGridView_Order.DataSource = this.bindingSource_Order;
            this.dataGridView_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Order.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Order.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersWidth = 82;
            this.dataGridView_Order.RowTemplate.Height = 37;
            this.dataGridView_Order.Size = new System.Drawing.Size(383, 440);
            this.dataGridView_Order.TabIndex = 0;
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Info.Controls.Add(this.dataGridView_Order);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Info.Location = new System.Drawing.Point(238, 0);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(383, 440);
            this.panel_Info.TabIndex = 1;
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Location = new System.Drawing.Point(20, 34);
            this.button_AddOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(69, 24);
            this.button_AddOrder.TabIndex = 2;
            this.button_AddOrder.Text = "创建订单";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // button_DelOrder
            // 
            this.button_DelOrder.Location = new System.Drawing.Point(118, 34);
            this.button_DelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_DelOrder.Name = "button_DelOrder";
            this.button_DelOrder.Size = new System.Drawing.Size(68, 24);
            this.button_DelOrder.TabIndex = 3;
            this.button_DelOrder.Text = "删除订单";
            this.button_DelOrder.UseVisualStyleBackColor = true;
            this.button_DelOrder.Click += new System.EventHandler(this.button_DelOrder_Click);
            // 
            // button_ReviseOrder
            // 
            this.button_ReviseOrder.Location = new System.Drawing.Point(118, 82);
            this.button_ReviseOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_ReviseOrder.Name = "button_ReviseOrder";
            this.button_ReviseOrder.Size = new System.Drawing.Size(68, 24);
            this.button_ReviseOrder.TabIndex = 4;
            this.button_ReviseOrder.Text = "修改订单";
            this.button_ReviseOrder.UseVisualStyleBackColor = true;
            this.button_ReviseOrder.Click += new System.EventHandler(this.button_ReviseOrder_Click);
            // 
            // button_InportOrder
            // 
            this.button_InportOrder.Location = new System.Drawing.Point(21, 82);
            this.button_InportOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_InportOrder.Name = "button_InportOrder";
            this.button_InportOrder.Size = new System.Drawing.Size(68, 24);
            this.button_InportOrder.TabIndex = 5;
            this.button_InportOrder.Text = "导入订单";
            this.button_InportOrder.UseVisualStyleBackColor = true;
            this.button_InportOrder.Click += new System.EventHandler(this.button_InportOrder_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"xml文件|*.xml|所有文件|*.*\"";
            this.openFileDialog.Title = "导入订单";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // button_ExportOrder
            // 
            this.button_ExportOrder.Location = new System.Drawing.Point(21, 130);
            this.button_ExportOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExportOrder.Name = "button_ExportOrder";
            this.button_ExportOrder.Size = new System.Drawing.Size(68, 24);
            this.button_ExportOrder.TabIndex = 6;
            this.button_ExportOrder.Text = "导出订单";
            this.button_ExportOrder.UseVisualStyleBackColor = true;
            this.button_ExportOrder.Click += new System.EventHandler(this.button_ExportOrder_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"xml文件|*.xml\"";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // bindingSource_Order
            // 
            this.bindingSource_Order.DataSource = typeof(OrderManager.Order);
            // 
            // textBox_Query
            // 
            this.textBox_Query.Location = new System.Drawing.Point(58, 37);
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.Size = new System.Drawing.Size(100, 21);
            this.textBox_Query.TabIndex = 7;
            // 
            // comboBox_Query
            // 
            this.comboBox_Query.FormattingEnabled = true;
            this.comboBox_Query.Items.AddRange(new object[] {
            "ID",
            "Cost",
            "Client"});
            this.comboBox_Query.Location = new System.Drawing.Point(58, 81);
            this.comboBox_Query.Name = "comboBox_Query";
            this.comboBox_Query.Size = new System.Drawing.Size(100, 20);
            this.comboBox_Query.TabIndex = 8;
            // 
            // button_Query
            // 
            this.button_Query.Location = new System.Drawing.Point(111, 124);
            this.button_Query.Name = "button_Query";
            this.button_Query.Size = new System.Drawing.Size(75, 23);
            this.button_Query.TabIndex = 9;
            this.button_Query.Text = "查询";
            this.button_Query.UseVisualStyleBackColor = true;
            this.button_Query.Click += new System.EventHandler(this.button_Query_Click);
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.button_DelOrder);
            this.groupBox_Operations.Controls.Add(this.button_ReviseOrder);
            this.groupBox_Operations.Controls.Add(this.button_AddOrder);
            this.groupBox_Operations.Controls.Add(this.button_InportOrder);
            this.groupBox_Operations.Controls.Add(this.button_ExportOrder);
            this.groupBox_Operations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Operations.Location = new System.Drawing.Point(0, 198);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(238, 242);
            this.groupBox_Operations.TabIndex = 10;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "功能";
            // 
            // groupBox_Query
            // 
            this.groupBox_Query.Controls.Add(this.button_Restore);
            this.groupBox_Query.Controls.Add(this.textBox_Query);
            this.groupBox_Query.Controls.Add(this.button_Query);
            this.groupBox_Query.Controls.Add(this.comboBox_Query);
            this.groupBox_Query.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Query.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Query.Name = "groupBox_Query";
            this.groupBox_Query.Size = new System.Drawing.Size(238, 192);
            this.groupBox_Query.TabIndex = 11;
            this.groupBox_Query.TabStop = false;
            this.groupBox_Query.Text = "查询";
            // 
            // button_Restore
            // 
            this.button_Restore.Location = new System.Drawing.Point(30, 124);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(75, 23);
            this.button_Restore.TabIndex = 10;
            this.button_Restore.Text = "重置";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 440);
            this.Controls.Add(this.groupBox_Query);
            this.Controls.Add(this.groupBox_Operations);
            this.Controls.Add(this.panel_Info);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager";
            this.Text = "OrderManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.panel_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Order)).EndInit();
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_Query.ResumeLayout(false);
            this.groupBox_Query.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Button button_DelOrder;
        private System.Windows.Forms.BindingSource bindingSource_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_ReviseOrder;
        private System.Windows.Forms.Button button_InportOrder;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_ExportOrder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBox_Query;
        private System.Windows.Forms.ComboBox comboBox_Query;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.GroupBox groupBox_Query;
        private System.Windows.Forms.Button button_Restore;
    }
}

