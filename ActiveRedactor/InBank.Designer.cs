namespace ActiveRedactor
{
    partial class InBank
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
            this.BoxId = new System.Windows.Forms.TextBox();
            this.BoxBank = new System.Windows.Forms.TextBox();
            this.BoxSum = new System.Windows.Forms.TextBox();
            this.BoxCurrency = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(51, 397);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(115, 41);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(277, 397);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(115, 41);
            this.Changebtn.TabIndex = 2;
            this.Changebtn.Text = "Редактировать";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(496, 397);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(115, 41);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "Удалить";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // BoxId
            // 
            this.BoxId.Location = new System.Drawing.Point(107, 38);
            this.BoxId.Name = "BoxId";
            this.BoxId.Size = new System.Drawing.Size(100, 20);
            this.BoxId.TabIndex = 4;
            this.BoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxId_KeyPress);
            // 
            // BoxBank
            // 
            this.BoxBank.Location = new System.Drawing.Point(107, 120);
            this.BoxBank.Name = "BoxBank";
            this.BoxBank.Size = new System.Drawing.Size(100, 20);
            this.BoxBank.TabIndex = 5;
            // 
            // BoxSum
            // 
            this.BoxSum.Location = new System.Drawing.Point(107, 266);
            this.BoxSum.Name = "BoxSum";
            this.BoxSum.Size = new System.Drawing.Size(100, 20);
            this.BoxSum.TabIndex = 6;
            this.BoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxSum_KeyPress);
            // 
            // BoxCurrency
            // 
            this.BoxCurrency.Location = new System.Drawing.Point(107, 340);
            this.BoxCurrency.Name = "BoxCurrency";
            this.BoxCurrency.Size = new System.Drawing.Size(100, 20);
            this.BoxCurrency.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(76, 42);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(25, 16);
            this.Id.TabIndex = 8;
            this.Id.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Банк:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сумма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Валюта:";
            // 
            // BoxAccount
            // 
            this.BoxAccount.Location = new System.Drawing.Point(107, 190);
            this.BoxAccount.Name = "BoxAccount";
            this.BoxAccount.Size = new System.Drawing.Size(100, 20);
            this.BoxAccount.TabIndex = 12;
            this.BoxAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAccount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Счет:";
            // 
            // InBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.BoxCurrency);
            this.Controls.Add(this.BoxSum);
            this.Controls.Add(this.BoxBank);
            this.Controls.Add(this.BoxId);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InBank";
            this.Text = "InBank";
            this.Load += new System.EventHandler(this.InBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox BoxId;
        private System.Windows.Forms.TextBox BoxBank;
        private System.Windows.Forms.TextBox BoxSum;
        private System.Windows.Forms.TextBox BoxCurrency;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxAccount;
        private System.Windows.Forms.Label label1;
    }
}