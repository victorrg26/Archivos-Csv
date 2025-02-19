namespace Archivos_Csv
{
    partial class FrnVarios
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
            btncurp = new Button();
            txtCurp = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dtpfechacal = new DateTimePicker();
            label2 = new Label();
            dtpfechanac = new DateTimePicker();
            btnCalcular = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btncurp
            // 
            btncurp.Location = new Point(381, 367);
            btncurp.Name = "btncurp";
            btncurp.Size = new Size(94, 29);
            btncurp.TabIndex = 10;
            btncurp.Text = "CURP";
            btncurp.UseVisualStyleBackColor = true;
            btncurp.Click += btncurp_Click;
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(12, 369);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(281, 27);
            txtCurp.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpfechacal, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpfechanac, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(104, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.96552F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.03448F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(609, 259);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha de Nacimiento";
            // 
            // dtpfechacal
            // 
            dtpfechacal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpfechacal.Location = new Point(3, 161);
            dtpfechacal.Name = "dtpfechacal";
            dtpfechacal.Size = new Size(298, 27);
            dtpfechacal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 116);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Calculo";
            // 
            // dtpfechanac
            // 
            dtpfechanac.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpfechanac.Location = new Point(3, 70);
            dtpfechanac.Name = "dtpfechanac";
            dtpfechanac.Size = new Size(298, 27);
            dtpfechanac.TabIndex = 0;
            dtpfechanac.ValueChanged += dtpfechanac_ValueChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.Location = new Point(307, 215);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(299, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 336);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 9;
            label3.Text = "CURP";
            // 
            // FrnVarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncurp);
            Controls.Add(txtCurp);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Name = "FrnVarios";
            Text = "FrnVarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncurp;
        private TextBox txtCurp;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpfechacal;
        private Label label2;
        private DateTimePicker dtpfechanac;
        private Button btnCalcular;
        private Label label3;
    }
}