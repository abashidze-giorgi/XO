namespace XO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_boardColor = new System.Windows.Forms.Button();
            this.cmb_ai_lvl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.cmb_start = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(383, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_boardColor
            // 
            this.btn_boardColor.Location = new System.Drawing.Point(116, 177);
            this.btn_boardColor.Name = "btn_boardColor";
            this.btn_boardColor.Size = new System.Drawing.Size(146, 23);
            this.btn_boardColor.TabIndex = 1;
            this.btn_boardColor.Text = "დაფის ფერი";
            this.btn_boardColor.UseVisualStyleBackColor = true;
            this.btn_boardColor.Click += new System.EventHandler(this.btn_boardColor_Click);
            // 
            // cmb_ai_lvl
            // 
            this.cmb_ai_lvl.FormattingEnabled = true;
            this.cmb_ai_lvl.Items.AddRange(new object[] {
            "მარტივი",
            "რთული"});
            this.cmb_ai_lvl.Location = new System.Drawing.Point(116, 12);
            this.cmb_ai_lvl.Name = "cmb_ai_lvl";
            this.cmb_ai_lvl.Size = new System.Drawing.Size(187, 21);
            this.cmb_ai_lvl.TabIndex = 2;
            this.cmb_ai_lvl.SelectedIndexChanged += new System.EventHandler(this.cmb_ai_lvl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "სირთულე:";
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(231, 403);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(146, 23);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "გადატვირთვა";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // cmb_start
            // 
            this.cmb_start.FormattingEnabled = true;
            this.cmb_start.Items.AddRange(new object[] {
            "მომხმარებელი",
            "კომპიუტერი"});
            this.cmb_start.Location = new System.Drawing.Point(116, 60);
            this.cmb_start.Name = "cmb_start";
            this.cmb_start.Size = new System.Drawing.Size(187, 21);
            this.cmb_start.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "იწყებს:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_start);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ai_lvl);
            this.Controls.Add(this.btn_boardColor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_boardColor;
        private System.Windows.Forms.ComboBox cmb_ai_lvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.ComboBox cmb_start;
        private System.Windows.Forms.Label label2;
    }
}

