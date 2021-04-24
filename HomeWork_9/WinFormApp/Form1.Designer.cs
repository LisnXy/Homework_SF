
namespace WinFormApp
{
    partial class Form1
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
            this.textBox_Target = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Target = new System.Windows.Forms.Label();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.groupBox_Displaytable = new System.Windows.Forms.GroupBox();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Results = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_Exception = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource_Exception = new System.Windows.Forms.BindingSource(this.components);
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Function.SuspendLayout();
            this.groupBox_Displaytable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Results)).BeginInit();
            this.groupBox_Exception.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Exception)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Target
            // 
            this.textBox_Target.Location = new System.Drawing.Point(211, 40);
            this.textBox_Target.Name = "textBox_Target";
            this.textBox_Target.Size = new System.Drawing.Size(292, 21);
            this.textBox_Target.TabIndex = 1;
            this.textBox_Target.TextChanged += new System.EventHandler(this.textBox_Target_TextChanged);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(242, 90);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(96, 39);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "爬取";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Target
            // 
            this.label_Target.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Target.Location = new System.Drawing.Point(114, 33);
            this.label_Target.Name = "label_Target";
            this.label_Target.Size = new System.Drawing.Size(91, 28);
            this.label_Target.TabIndex = 0;
            this.label_Target.Text = "Target:";
            this.label_Target.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.label_Target);
            this.groupBox_Function.Controls.Add(this.button_Start);
            this.groupBox_Function.Controls.Add(this.textBox_Target);
            this.groupBox_Function.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Function.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(858, 158);
            this.groupBox_Function.TabIndex = 3;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "功能";
            // 
            // groupBox_Displaytable
            // 
            this.groupBox_Displaytable.Controls.Add(this.dataGridView_Results);
            this.groupBox_Displaytable.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Displaytable.Location = new System.Drawing.Point(0, 158);
            this.groupBox_Displaytable.Name = "groupBox_Displaytable";
            this.groupBox_Displaytable.Size = new System.Drawing.Size(858, 209);
            this.groupBox_Displaytable.TabIndex = 4;
            this.groupBox_Displaytable.TabStop = false;
            this.groupBox_Displaytable.Text = "结果";
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AutoGenerateColumns = false;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn});
            this.dataGridView_Results.DataSource = this.bindingSource_Results;
            this.dataGridView_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Results.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.RowTemplate.Height = 23;
            this.dataGridView_Results.Size = new System.Drawing.Size(852, 189);
            this.dataGridView_Results.TabIndex = 0;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // bindingSource_Results
            // 
            this.bindingSource_Results.DataSource = typeof(WinFormApp.Url);
            // 
            // groupBox_Exception
            // 
            this.groupBox_Exception.Controls.Add(this.dataGridView1);
            this.groupBox_Exception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Exception.Location = new System.Drawing.Point(0, 367);
            this.groupBox_Exception.Name = "groupBox_Exception";
            this.groupBox_Exception.Size = new System.Drawing.Size(858, 231);
            this.groupBox_Exception.TabIndex = 5;
            this.groupBox_Exception.TabStop = false;
            this.groupBox_Exception.Text = "错误信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bindingSource_Exception;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(852, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource_Exception
            // 
            this.bindingSource_Exception.DataSource = typeof(WinFormApp.Url);
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 598);
            this.Controls.Add(this.groupBox_Exception);
            this.Controls.Add(this.groupBox_Displaytable);
            this.Controls.Add(this.groupBox_Function);
            this.Name = "Form1";
            this.Text = "Crawler";
            this.groupBox_Function.ResumeLayout(false);
            this.groupBox_Function.PerformLayout();
            this.groupBox_Displaytable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Results)).EndInit();
            this.groupBox_Exception.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Exception)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Target;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Target;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.GroupBox groupBox_Displaytable;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.BindingSource bindingSource_Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox_Exception;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bindingSource_Exception;
    }
}

