namespace Archivos_Csv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtvcsv = new DataGridView();
            btncsv = new Button();
            openFileDialogcsv = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dtvcsv).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtvcsv
            // 
            dtvcsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvcsv.Dock = DockStyle.Fill;
            dtvcsv.Location = new Point(3, 3);
            dtvcsv.Name = "dtvcsv";
            dtvcsv.RowHeadersWidth = 51;
            dtvcsv.Size = new Size(947, 310);
            dtvcsv.TabIndex = 0;
            dtvcsv.CellContentClick += dtvcsv_CellContentClick;
            // 
            // btncsv
            // 
            btncsv.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btncsv.Location = new Point(3, 338);
            btncsv.Name = "btncsv";
            btncsv.Size = new Size(947, 29);
            btncsv.TabIndex = 1;
            btncsv.Text = "Cargar ";
            btncsv.UseVisualStyleBackColor = true;
            btncsv.Click += button1_Click;
            // 
            // openFileDialogcsv
            // 
            openFileDialogcsv.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dtvcsv, 0, 0);
            tableLayoutPanel1.Controls.Add(btncsv, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.14754F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.852459F));
            tableLayoutPanel1.Size = new Size(953, 390);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 396);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtvcsv).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtvcsv;
        private Button btncsv;
        private OpenFileDialog openFileDialogcsv;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
