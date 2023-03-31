namespace DemoAD
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_product_type = new System.Windows.Forms.ComboBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_artic_num = new System.Windows.Forms.TextBox();
            this.textBox_min_cost_for_ag = new System.Windows.Forms.TextBox();
            this.textBox_image_path = new System.Windows.Forms.TextBox();
            this.textBox_prod_per_count = new System.Windows.Forms.TextBox();
            this.textBox_prod_workshop_num = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип продукта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Заголовок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Артикул:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Минимальная цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название картинки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во тел.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "№ цеха:";
            // 
            // comboBox_product_type
            // 
            this.comboBox_product_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.comboBox_product_type.FormattingEnabled = true;
            this.comboBox_product_type.Location = new System.Drawing.Point(98, 13);
            this.comboBox_product_type.Name = "comboBox_product_type";
            this.comboBox_product_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product_type.TabIndex = 15;
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.textBox_title.Location = new System.Drawing.Point(98, 48);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(121, 20);
            this.textBox_title.TabIndex = 16;
            // 
            // textBox_artic_num
            // 
            this.textBox_artic_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.textBox_artic_num.Location = new System.Drawing.Point(98, 83);
            this.textBox_artic_num.Name = "textBox_artic_num";
            this.textBox_artic_num.Size = new System.Drawing.Size(121, 20);
            this.textBox_artic_num.TabIndex = 17;
            // 
            // textBox_min_cost_for_ag
            // 
            this.textBox_min_cost_for_ag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.textBox_min_cost_for_ag.Location = new System.Drawing.Point(113, 124);
            this.textBox_min_cost_for_ag.Name = "textBox_min_cost_for_ag";
            this.textBox_min_cost_for_ag.Size = new System.Drawing.Size(121, 20);
            this.textBox_min_cost_for_ag.TabIndex = 18;
            // 
            // textBox_image_path
            // 
            this.textBox_image_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.textBox_image_path.Location = new System.Drawing.Point(128, 158);
            this.textBox_image_path.Name = "textBox_image_path";
            this.textBox_image_path.Size = new System.Drawing.Size(121, 20);
            this.textBox_image_path.TabIndex = 19;
            // 
            // textBox_prod_per_count
            // 
            this.textBox_prod_per_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.textBox_prod_per_count.Location = new System.Drawing.Point(98, 190);
            this.textBox_prod_per_count.Name = "textBox_prod_per_count";
            this.textBox_prod_per_count.Size = new System.Drawing.Size(121, 20);
            this.textBox_prod_per_count.TabIndex = 20;
            // 
            // textBox_prod_workshop_num
            // 
            this.textBox_prod_workshop_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.textBox_prod_workshop_num.Location = new System.Drawing.Point(69, 216);
            this.textBox_prod_workshop_num.Name = "textBox_prod_workshop_num";
            this.textBox_prod_workshop_num.Size = new System.Drawing.Size(121, 20);
            this.textBox_prod_workshop_num.TabIndex = 21;
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_insert.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_insert.ForeColor = System.Drawing.Color.Black;
            this.button_insert.Location = new System.Drawing.Point(48, 256);
            this.button_insert.Name = "button_insert";
            this.button_insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_insert.Size = new System.Drawing.Size(127, 37);
            this.button_insert.TabIndex = 22;
            this.button_insert.Text = "Добавить продукт";
            this.button_insert.UseVisualStyleBackColor = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 326);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textBox_prod_workshop_num);
            this.Controls.Add(this.textBox_prod_per_count);
            this.Controls.Add(this.textBox_image_path);
            this.Controls.Add(this.textBox_min_cost_for_ag);
            this.Controls.Add(this.textBox_artic_num);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.comboBox_product_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Добавление продукта";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_product_type;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_artic_num;
        private System.Windows.Forms.TextBox textBox_min_cost_for_ag;
        private System.Windows.Forms.TextBox textBox_image_path;
        private System.Windows.Forms.TextBox textBox_prod_per_count;
        private System.Windows.Forms.TextBox textBox_prod_workshop_num;
        private System.Windows.Forms.Button button_insert;
    }
}

