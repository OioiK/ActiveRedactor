namespace ActiveRedactor
{
    partial class Material
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxYear = new System.Windows.Forms.TextBox();
            this.boxOvalue = new System.Windows.Forms.TextBox();
            this.boxWeight = new System.Windows.Forms.TextBox();
            this.boxSvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxRvalue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(183, 374);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(97, 37);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(427, 374);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(97, 37);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "Редактировать";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(684, 374);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 37);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(220, 35);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(100, 20);
            this.boxId.TabIndex = 4;
            this.boxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxId_KeyPress);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(220, 90);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 20);
            this.boxName.TabIndex = 5;
            // 
            // boxYear
            // 
            this.boxYear.Location = new System.Drawing.Point(220, 186);
            this.boxYear.Name = "boxYear";
            this.boxYear.Size = new System.Drawing.Size(100, 20);
            this.boxYear.TabIndex = 6;
            this.boxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxYear_KeyPress);
            // 
            // boxOvalue
            // 
            this.boxOvalue.Location = new System.Drawing.Point(220, 277);
            this.boxOvalue.Name = "boxOvalue";
            this.boxOvalue.Size = new System.Drawing.Size(100, 20);
            this.boxOvalue.TabIndex = 7;
            this.boxOvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxOvalue_KeyPress);
            // 
            // boxWeight
            // 
            this.boxWeight.Location = new System.Drawing.Point(220, 140);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(100, 20);
            this.boxWeight.TabIndex = 8;
            this.boxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxWeight_KeyPress);
            // 
            // boxSvalue
            // 
            this.boxSvalue.Location = new System.Drawing.Point(220, 234);
            this.boxSvalue.Name = "boxSvalue";
            this.boxSvalue.Size = new System.Drawing.Size(100, 20);
            this.boxSvalue.TabIndex = 9;
            this.boxSvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxSvalue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Вес, кг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Год изготовления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Начальная стоимость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Остаточная стоимость:";
            // 
            // boxRvalue
            // 
            this.boxRvalue.Location = new System.Drawing.Point(220, 322);
            this.boxRvalue.Name = "boxRvalue";
            this.boxRvalue.Size = new System.Drawing.Size(100, 20);
            this.boxRvalue.TabIndex = 16;
            this.boxRvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxRvalue_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Рыночная стоимость:";
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxRvalue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxSvalue);
            this.Controls.Add(this.boxWeight);
            this.Controls.Add(this.boxOvalue);
            this.Controls.Add(this.boxYear);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Material";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxYear;
        private System.Windows.Forms.TextBox boxOvalue;
        private System.Windows.Forms.TextBox boxWeight;
        private System.Windows.Forms.TextBox boxSvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxRvalue;
        private System.Windows.Forms.Label label7;
    }
}