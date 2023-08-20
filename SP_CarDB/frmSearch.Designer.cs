namespace PizzaDatabase
{
    partial class frmSearch
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
            groupBox1 = new GroupBox();
            txtValue = new TextBox();
            cboOperator = new ComboBox();
            cboField = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRun = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(cboOperator);
            groupBox1.Controls.Add(cboField);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 22);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(545, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(326, 48);
            txtValue.Margin = new Padding(3, 2, 3, 2);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(198, 23);
            txtValue.TabIndex = 5;
            // 
            // cboOperator
            // 
            cboOperator.FormattingEnabled = true;
            cboOperator.Location = new Point(163, 48);
            cboOperator.Margin = new Padding(3, 2, 3, 2);
            cboOperator.Name = "cboOperator";
            cboOperator.Size = new Size(133, 23);
            cboOperator.TabIndex = 4;
            // 
            // cboField
            // 
            cboField.FormattingEnabled = true;
            cboField.Location = new Point(14, 48);
            cboField.Margin = new Padding(3, 2, 3, 2);
            cboField.Name = "cboField";
            cboField.Size = new Size(133, 23);
            cboField.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(326, 17);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 2;
            label3.Text = "Enter text here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(163, 17);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 1;
            label2.Text = "Match Symbol:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Search criteria:";
            label1.Click += label1_Click;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(589, 34);
            btnRun.Margin = new Padding(3, 2, 3, 2);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(82, 28);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(589, 70);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 28);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Firebrick;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 121);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 189);
            dataGridView1.TabIndex = 3;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(708, 338);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnRun);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSearch";
            Text = "Task A Search";
            Load += frmSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtValue;
        private ComboBox cboOperator;
        private ComboBox cboField;
        private Button btnRun;
        private Button btnClose;
        private DataGridView dataGridView1;
    }
}