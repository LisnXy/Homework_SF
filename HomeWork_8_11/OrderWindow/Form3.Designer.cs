
namespace OrderWindow
{
    partial class Form3:Form2
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
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SingleCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderDetial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(0, 225);
            this.groupBox.Size = new System.Drawing.Size(452, 228);
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Location = new System.Drawing.Point(285, 150);
            this.button_AddOrder.Text = "Confirm";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(452, 0);
            this.panel1.Size = new System.Drawing.Size(444, 453);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 453);
            this.Name = "Form3";
            this.Text = "修改订单";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SingleCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderDetial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}