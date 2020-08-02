namespace ActiveRedactor
{
    partial class InCassa
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.Changebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.BoxSum = new System.Windows.Forms.TextBox();
            this.BoxCurrency = new System.Windows.Forms.TextBox();
            this.BoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(103, 383);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(102, 38);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(338, 383);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(95, 38);
            this.Changebtn.TabIndex = 2;
            this.Changebtn.Text = "Редактировать";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(574, 383);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 38);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "Удалить";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // BoxSum
            // 
            this.BoxSum.Location = new System.Drawing.Point(172, 148);
            this.BoxSum.Name = "BoxSum";
            this.BoxSum.Size = new System.Drawing.Size(100, 20);
            this.BoxSum.TabIndex = 4;
            this.BoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxSum_KeyPress);
            // 
            // BoxCurrency
            // 
            this.BoxCurrency.Location = new System.Drawing.Point(172, 224);
            this.BoxCurrency.Name = "BoxCurrency";
            this.BoxCurrency.Size = new System.Drawing.Size(100, 20);
            this.BoxCurrency.TabIndex = 5;
            // 
            // BoxId
            // 
            this.BoxId.Location = new System.Drawing.Point(172, 78);
            this.BoxId.Name = "BoxId";
            this.BoxId.Size = new System.Drawing.Size(100, 20);
            this.BoxId.TabIndex = 6;
            this.BoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Валюта;";
            // 
            // InCassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxId);
            this.Controls.Add(this.BoxCurrency);
            this.Controls.Add(this.BoxSum);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InCassa";
            this.Text = "InCassa";
            this.Load += new System.EventHandler(this.InCassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox BoxSum;
        private System.Windows.Forms.TextBox BoxCurrency;
        private System.Windows.Forms.TextBox BoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}