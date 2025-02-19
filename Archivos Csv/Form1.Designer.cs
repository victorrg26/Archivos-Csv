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
            menuStrip1 = new MenuStrip();
            fechasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtvcsv).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtvcsv
            // 
            dtvcsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvcsv.Location = new Point(3, 31);
            dtvcsv.Name = "dtvcsv";
            dtvcsv.RowHeadersWidth = 51;
            dtvcsv.Size = new Size(947, 310);
            dtvcsv.TabIndex = 0;
            dtvcsv.CellContentClick += dtvcsv_CellContentClick;
            // 
            // btncsv
            // 
            btncsv.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btncsv.Location = new Point(3, 353);
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
            tableLayoutPanel1.Controls.Add(btncsv, 0, 2);
            tableLayoutPanel1.Controls.Add(dtvcsv, 0, 1);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.130081F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.86992F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.Size = new Size(953, 390);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fechasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(953, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fechasToolStripMenuItem
            // 
            fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            fechasToolStripMenuItem.Size = new Size(67, 24);
            fechasToolStripMenuItem.Text = "Fechas";
            fechasToolStripMenuItem.Click += fechasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 396);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtvcsv).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtvcsv;
        private Button btncsv;
        private OpenFileDialog openFileDialogcsv;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fechasToolStripMenuItem;
    }
}
