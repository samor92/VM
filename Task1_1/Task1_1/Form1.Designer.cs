namespace Task1_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBxMatrix = new System.Windows.Forms.GroupBox();
            this.dtGrdVwMatrix = new System.Windows.Forms.DataGridView();
            this.grpBxMainButton = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.grpBxMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMatrix)).BeginInit();
            this.grpBxMainButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Grid1.Location = new System.Drawing.Point(12, 12);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowTemplate.Height = 24;
            this.Grid1.Size = new System.Drawing.Size(643, 288);
            this.Grid1.TabIndex = 0;
            this.Grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Размерность";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Диапазон";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Средняя относительная погрешность";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "среднее значение оценки точности";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBxMatrix
            // 
            this.grpBxMatrix.Controls.Add(this.dtGrdVwMatrix);
            this.grpBxMatrix.Location = new System.Drawing.Point(661, 11);
            this.grpBxMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxMatrix.Name = "grpBxMatrix";
            this.grpBxMatrix.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxMatrix.Size = new System.Drawing.Size(249, 241);
            this.grpBxMatrix.TabIndex = 2;
            this.grpBxMatrix.TabStop = false;
            this.grpBxMatrix.Text = "Вид матрицы";
            // 
            // dtGrdVwMatrix
            // 
            this.dtGrdVwMatrix.AllowUserToAddRows = false;
            this.dtGrdVwMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwMatrix.Location = new System.Drawing.Point(2, 15);
            this.dtGrdVwMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrdVwMatrix.Name = "dtGrdVwMatrix";
            this.dtGrdVwMatrix.ReadOnly = true;
            this.dtGrdVwMatrix.RowTemplate.Height = 24;
            this.dtGrdVwMatrix.Size = new System.Drawing.Size(245, 224);
            this.dtGrdVwMatrix.TabIndex = 0;
            // 
            // grpBxMainButton
            // 
            this.grpBxMainButton.Controls.Add(this.button1);
            this.grpBxMainButton.Location = new System.Drawing.Point(663, 256);
            this.grpBxMainButton.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxMainButton.Name = "grpBxMainButton";
            this.grpBxMainButton.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxMainButton.Size = new System.Drawing.Size(247, 44);
            this.grpBxMainButton.TabIndex = 3;
            this.grpBxMainButton.TabStop = false;
            this.grpBxMainButton.Text = "Управление";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 314);
            this.Controls.Add(this.grpBxMainButton);
            this.Controls.Add(this.grpBxMatrix);
            this.Controls.Add(this.Grid1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Задача 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.grpBxMatrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMatrix)).EndInit();
            this.grpBxMainButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpBxMatrix;
        private System.Windows.Forms.DataGridView dtGrdVwMatrix;
        private System.Windows.Forms.GroupBox grpBxMainButton;
    }
}

