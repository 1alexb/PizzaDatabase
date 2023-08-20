namespace PizzaDatabase
{
    partial class FrmPizza
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
            components = new System.ComponentModel.Container();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            chkDelivery = new CheckBox();
            label7 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtOrderDate = new TextBox();
            label5 = new Label();
            txtOrderId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtRecordCount = new TextBox();
            ToolTip = new ToolTip(components);
            pictureBox1 = new PictureBox();
            cmbPizzaType = new ComboBox();
            cmbPizzaSize = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Location = new Point(405, 381);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 23);
            btnLast.TabIndex = 48;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(313, 381);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 47;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Location = new Point(116, 382);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 46;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirst.Location = new Point(28, 382);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 23);
            btnFirst.TabIndex = 45;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(405, 335);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 44;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(405, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(405, 245);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(405, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(405, 154);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 24);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(405, 112);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // chkDelivery
            // 
            chkDelivery.AutoSize = true;
            chkDelivery.BackColor = Color.FromArgb(210, 255, 255);
            chkDelivery.Location = new Point(373, 342);
            chkDelivery.Name = "chkDelivery";
            chkDelivery.Size = new Size(15, 14);
            chkDelivery.TabIndex = 38;
            ToolTip.SetToolTip(chkDelivery, "Tick to confirm this is a home delivery.");
            chkDelivery.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(28, 334);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 37;
            label7.Text = "Delivery?";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(197, 290);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(191, 23);
            txtPrice.TabIndex = 36;
            txtPrice.Text = "€0.00";
            txtPrice.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(txtPrice, "The price is automatic, overwrite any discounts.");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(28, 293);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 35;
            label6.Text = "Price:";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new Point(197, 246);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(170, 23);
            txtOrderDate.TabIndex = 34;
            txtOrderDate.Text = "dd/mm/yyyy";
            txtOrderDate.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(txtOrderDate, "Use the calendar to select the date.");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(28, 248);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 33;
            label5.Text = "Order Date:";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(197, 112);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(191, 23);
            txtOrderId.TabIndex = 28;
            ToolTip.SetToolTip(txtOrderId, "Enter the Order ID in O0000 format. Example: letter O0001");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(28, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 27;
            label2.Text = "Order ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 48F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(41, 7);
            label1.Name = "label1";
            label1.Size = new Size(417, 102);
            label1.TabIndex = 26;
            label1.Text = "PizzaBoole";
            // 
            // txtRecordCount
            // 
            txtRecordCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecordCount.Location = new Point(197, 382);
            txtRecordCount.Margin = new Padding(3, 2, 3, 2);
            txtRecordCount.Name = "txtRecordCount";
            txtRecordCount.PlaceholderText = "1 of 15";
            txtRecordCount.Size = new Size(110, 23);
            txtRecordCount.TabIndex = 49;
            txtRecordCount.Text = "1 of 15";
            txtRecordCount.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._35117_7_pepperoni_pizza_transparent;
            pictureBox1.Location = new Point(498, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 498);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // cmbPizzaType
            // 
            cmbPizzaType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaType.FormattingEnabled = true;
            cmbPizzaType.Items.AddRange(new object[] { "", "Margherita", "Pepperoni", "BBQ", "Hawaiian", "Veggie" });
            cmbPizzaType.Location = new Point(197, 154);
            cmbPizzaType.Name = "cmbPizzaType";
            cmbPizzaType.Size = new Size(191, 23);
            cmbPizzaType.TabIndex = 51;

            // 
            // cmbPizzaSize
            // 
            cmbPizzaSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaSize.FormattingEnabled = true;
            cmbPizzaSize.Items.AddRange(new object[] { "", "Small", "Medium", "Large" });
            cmbPizzaSize.Location = new Point(197, 200);
            cmbPizzaSize.Name = "cmbPizzaSize";
            cmbPizzaSize.Size = new Size(191, 23);
            cmbPizzaSize.TabIndex = 52;

            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(373, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(15, 23);
            dateTimePicker1.TabIndex = 53;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 157);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 54;
            label3.Text = "Pizza Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(28, 202);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 55;
            label4.Text = "Pizza Size:";
            // 
            // FrmPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbPizzaSize);
            Controls.Add(cmbPizzaType);
            Controls.Add(pictureBox1);
            Controls.Add(txtRecordCount);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(chkDelivery);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(txtOrderDate);
            Controls.Add(label5);
            Controls.Add(txtOrderId);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "FrmPizza";
            Text = "Task A";
            Load += FrmPizza_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnExit;
        private Button btnCancel;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private CheckBox chkDelivery;
        private Label label7;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtOrderDate;
        private Label label5;
        private TextBox txtOrderId;
        private Label label2;
        private Label label1;
        private TextBox txtRecordCount;
        private ToolTip ToolTip;
        private PictureBox pictureBox1;
        private ComboBox cmbPizzaType;
        private ComboBox cmbPizzaSize;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
    }
}