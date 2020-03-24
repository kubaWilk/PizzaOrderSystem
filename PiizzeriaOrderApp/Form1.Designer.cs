namespace PiizzeriaOrderApp
{
    partial class OrderWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainDishButton = new System.Windows.Forms.Button();
            this.PizzaButton = new System.Windows.Forms.Button();
            this.SoupsButton = new System.Windows.Forms.Button();
            this.MDAddsButton = new System.Windows.Forms.Button();
            this.DrinksButton = new System.Windows.Forms.Button();
            this.MenuItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SummedOrderPriceLabel = new System.Windows.Forms.Label();
            this.OrderCommentsLabel = new System.Windows.Forms.Label();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.DeleteFromOrderButton = new System.Windows.Forms.Button();
            this.PlaceAnOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MainDishButton);
            this.flowLayoutPanel1.Controls.Add(this.PizzaButton);
            this.flowLayoutPanel1.Controls.Add(this.SoupsButton);
            this.flowLayoutPanel1.Controls.Add(this.MDAddsButton);
            this.flowLayoutPanel1.Controls.Add(this.DrinksButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 58);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainDishButton
            // 
            this.MainDishButton.Location = new System.Drawing.Point(3, 3);
            this.MainDishButton.Name = "MainDishButton";
            this.MainDishButton.Size = new System.Drawing.Size(85, 46);
            this.MainDishButton.TabIndex = 0;
            this.MainDishButton.Text = "Danie Główne";
            this.MainDishButton.UseVisualStyleBackColor = true;
            this.MainDishButton.Click += new System.EventHandler(this.MainDishButton_Click);
            // 
            // PizzaButton
            // 
            this.PizzaButton.Location = new System.Drawing.Point(94, 3);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(86, 46);
            this.PizzaButton.TabIndex = 2;
            this.PizzaButton.Text = "Pizza";
            this.PizzaButton.UseVisualStyleBackColor = true;
            this.PizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // SoupsButton
            // 
            this.SoupsButton.Location = new System.Drawing.Point(186, 3);
            this.SoupsButton.Name = "SoupsButton";
            this.SoupsButton.Size = new System.Drawing.Size(88, 46);
            this.SoupsButton.TabIndex = 3;
            this.SoupsButton.Text = "Zupy";
            this.SoupsButton.UseVisualStyleBackColor = true;
            this.SoupsButton.Click += new System.EventHandler(this.SoupsButton_Click);
            // 
            // MDAddsButton
            // 
            this.MDAddsButton.Location = new System.Drawing.Point(280, 3);
            this.MDAddsButton.Name = "MDAddsButton";
            this.MDAddsButton.Size = new System.Drawing.Size(76, 46);
            this.MDAddsButton.TabIndex = 1;
            this.MDAddsButton.Text = "Dodatki";
            this.MDAddsButton.UseVisualStyleBackColor = true;
            this.MDAddsButton.Click += new System.EventHandler(this.MDAddsButton_Click);
            // 
            // DrinksButton
            // 
            this.DrinksButton.Location = new System.Drawing.Point(362, 3);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(85, 46);
            this.DrinksButton.TabIndex = 4;
            this.DrinksButton.Text = "Napoje";
            this.DrinksButton.UseVisualStyleBackColor = true;
            this.DrinksButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // MenuItemsListBox
            // 
            this.MenuItemsListBox.FormattingEnabled = true;
            this.MenuItemsListBox.ItemHeight = 15;
            this.MenuItemsListBox.Location = new System.Drawing.Point(15, 106);
            this.MenuItemsListBox.Name = "MenuItemsListBox";
            this.MenuItemsListBox.Size = new System.Drawing.Size(203, 274);
            this.MenuItemsListBox.TabIndex = 1;
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 15;
            this.OrderItemsListBox.Location = new System.Drawing.Point(265, 106);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(203, 274);
            this.OrderItemsListBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 449);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 23);
            this.textBox1.TabIndex = 3;
            // 
            // SummedOrderPriceLabel
            // 
            this.SummedOrderPriceLabel.AutoSize = true;
            this.SummedOrderPriceLabel.Location = new System.Drawing.Point(219, 391);
            this.SummedOrderPriceLabel.Name = "SummedOrderPriceLabel";
            this.SummedOrderPriceLabel.Size = new System.Drawing.Size(45, 15);
            this.SummedOrderPriceLabel.TabIndex = 5;
            this.SummedOrderPriceLabel.Text = "SUMA: ";
            this.SummedOrderPriceLabel.Click += new System.EventHandler(this.SummedOrderPriceLabel_Click);
            // 
            // OrderCommentsLabel
            // 
            this.OrderCommentsLabel.AutoSize = true;
            this.OrderCommentsLabel.Location = new System.Drawing.Point(15, 430);
            this.OrderCommentsLabel.Name = "OrderCommentsLabel";
            this.OrderCommentsLabel.Size = new System.Drawing.Size(124, 15);
            this.OrderCommentsLabel.TabIndex = 6;
            this.OrderCommentsLabel.Text = "Uwagi do zamówienia:";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(15, 387);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(139, 23);
            this.AddToOrderButton.TabIndex = 7;
            this.AddToOrderButton.Text = "Dodaj do zamówienia";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // DeleteFromOrderButton
            // 
            this.DeleteFromOrderButton.Location = new System.Drawing.Point(322, 387);
            this.DeleteFromOrderButton.Name = "DeleteFromOrderButton";
            this.DeleteFromOrderButton.Size = new System.Drawing.Size(146, 23);
            this.DeleteFromOrderButton.TabIndex = 8;
            this.DeleteFromOrderButton.Text = "Usuń z zamówienia";
            this.DeleteFromOrderButton.UseVisualStyleBackColor = true;
            this.DeleteFromOrderButton.Click += new System.EventHandler(this.DeleteFromOrderButton_Click);
            // 
            // PlaceAnOrderButton
            // 
            this.PlaceAnOrderButton.Location = new System.Drawing.Point(153, 478);
            this.PlaceAnOrderButton.Name = "PlaceAnOrderButton";
            this.PlaceAnOrderButton.Size = new System.Drawing.Size(170, 23);
            this.PlaceAnOrderButton.TabIndex = 9;
            this.PlaceAnOrderButton.Text = "Złóż zamówienie";
            this.PlaceAnOrderButton.UseVisualStyleBackColor = true;
            // 
            // OrderWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(504, 529);
            this.Controls.Add(this.PlaceAnOrderButton);
            this.Controls.Add(this.DeleteFromOrderButton);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.OrderCommentsLabel);
            this.Controls.Add(this.SummedOrderPriceLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.MenuItemsListBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "OrderWindow";
            this.Text = "Złóż zamówienie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MainDishButton;
        private System.Windows.Forms.Button PizzaButton;
        private System.Windows.Forms.Button SoupsButton;
        private System.Windows.Forms.Button MDAddsButton;
        private System.Windows.Forms.Button DrinksButton;
        private System.Windows.Forms.ListBox MenuItemsListBox;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SummedOrderPriceLabel;
        private System.Windows.Forms.Label OrderCommentsLabel;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button DeleteFromOrderButton;
        private System.Windows.Forms.Button PlaceAnOrderButton;
    }
}

