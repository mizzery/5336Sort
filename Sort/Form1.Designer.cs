namespace Sort
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
            this.GRN = new System.Windows.Forms.Button();
            this.TBGRN = new System.Windows.Forms.TextBox();
            this.TBGRNC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GRN
            // 
            this.GRN.Location = new System.Drawing.Point(1187, 12);
            this.GRN.Name = "GRN";
            this.GRN.Size = new System.Drawing.Size(151, 23);
            this.GRN.TabIndex = 0;
            this.GRN.Text = "Generate Random Numbers";
            this.GRN.UseVisualStyleBackColor = true;
            this.GRN.Click += new System.EventHandler(this.GRN_Click);
            // 
            // TBGRN
            // 
            this.TBGRN.Location = new System.Drawing.Point(12, 13);
            this.TBGRN.Name = "TBGRN";
            this.TBGRN.Size = new System.Drawing.Size(1169, 20);
            this.TBGRN.TabIndex = 1;
            // 
            // TBGRNC
            // 
            this.TBGRNC.Location = new System.Drawing.Point(1228, 41);
            this.TBGRNC.Name = "TBGRNC";
            this.TBGRNC.Size = new System.Drawing.Size(110, 20);
            this.TBGRNC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1187, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count:";
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 39);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 6;
            this.B1.Text = "Пузырек";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(93, 39);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 23);
            this.B2.TabIndex = 7;
            this.B2.Text = "Седжвик";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(174, 39);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 23);
            this.B3.TabIndex = 8;
            this.B3.Text = "Шейкер";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(255, 39);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(75, 23);
            this.B4.TabIndex = 9;
            this.B4.Text = "Вставки";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(233, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "С выводом результата (очень медленно)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 77);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBGRNC);
            this.Controls.Add(this.TBGRN);
            this.Controls.Add(this.GRN);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GRN;
        private System.Windows.Forms.TextBox TBGRN;
        private System.Windows.Forms.TextBox TBGRNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

