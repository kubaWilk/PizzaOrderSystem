namespace PiizzeriaOrderApp
{
    partial class OrderHistory
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectedOrderListBox = new System.Windows.Forms.ListBox();
            this.OrderHistoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(146, 256);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Zamknij";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectedOrderListBox
            // 
            this.SelectedOrderListBox.FormattingEnabled = true;
            this.SelectedOrderListBox.Location = new System.Drawing.Point(203, 12);
            this.SelectedOrderListBox.Name = "SelectedOrderListBox";
            this.SelectedOrderListBox.Size = new System.Drawing.Size(151, 238);
            this.SelectedOrderListBox.TabIndex = 3;
            // 
            // OrderHistoryListBox
            // 
            this.OrderHistoryListBox.FormattingEnabled = true;
            this.OrderHistoryListBox.Location = new System.Drawing.Point(12, 12);
            this.OrderHistoryListBox.Name = "OrderHistoryListBox";
            this.OrderHistoryListBox.Size = new System.Drawing.Size(151, 238);
            this.OrderHistoryListBox.TabIndex = 0;
            this.OrderHistoryListBox.SelectedIndexChanged += new System.EventHandler(this.OrderHistoryListBox_SelectedIndexChanged);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 291);
            this.Controls.Add(this.SelectedOrderListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OrderHistoryListBox);
            this.MaximumSize = new System.Drawing.Size(380, 330);
            this.MinimumSize = new System.Drawing.Size(380, 330);
            this.Name = "OrderHistory";
            this.Text = "Historia Zamówień";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox SelectedOrderListBox;
        private System.Windows.Forms.ListBox OrderHistoryListBox;
    }
}