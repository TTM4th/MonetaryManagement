namespace FundCollator
{
    partial class FundCollatorFrom
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_plus = new System.Windows.Forms.Label();
            this.button_calc = new System.Windows.Forms.Button();
            this.label_cash_info = new System.Windows.Forms.Label();
            this.label_from_db_info = new System.Windows.Forms.Label();
            this.label_cash = new System.Windows.Forms.Label();
            this.label_from_db = new System.Windows.Forms.Label();
            this.label_diff_info = new System.Windows.Forms.Label();
            this.label_diff = new System.Windows.Forms.Label();
            this.emoneyInput1 = new FundCollator.EmoneyInput();
            this.cashInput = new FundCollator.CashInput();
            this.SuspendLayout();
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_plus.Location = new System.Drawing.Point(276, 80);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(21, 21);
            this.label_plus.TabIndex = 1;
            this.label_plus.Text = "+";
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(419, 333);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(111, 36);
            this.button_calc.TabIndex = 10;
            this.button_calc.Text = "手持金額の集計";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.Button_calc_Click);
            // 
            // label_cash_info
            // 
            this.label_cash_info.AutoSize = true;
            this.label_cash_info.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_cash_info.Location = new System.Drawing.Point(276, 199);
            this.label_cash_info.Name = "label_cash_info";
            this.label_cash_info.Size = new System.Drawing.Size(109, 19);
            this.label_cash_info.TabIndex = 4;
            this.label_cash_info.Text = "手持ち金額：";
            // 
            // label_from_db_info
            // 
            this.label_from_db_info.AutoSize = true;
            this.label_from_db_info.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_from_db_info.Location = new System.Drawing.Point(290, 241);
            this.label_from_db_info.Name = "label_from_db_info";
            this.label_from_db_info.Size = new System.Drawing.Size(95, 19);
            this.label_from_db_info.TabIndex = 5;
            this.label_from_db_info.Text = "登録残高：";
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_cash.Location = new System.Drawing.Point(391, 199);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(0, 19);
            this.label_cash.TabIndex = 7;
            // 
            // label_from_db
            // 
            this.label_from_db.AutoSize = true;
            this.label_from_db.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_from_db.Location = new System.Drawing.Point(391, 241);
            this.label_from_db.Name = "label_from_db";
            this.label_from_db.Size = new System.Drawing.Size(0, 19);
            this.label_from_db.TabIndex = 8;
            // 
            // label_diff_info
            // 
            this.label_diff_info.AutoSize = true;
            this.label_diff_info.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_diff_info.Location = new System.Drawing.Point(328, 283);
            this.label_diff_info.Name = "label_diff_info";
            this.label_diff_info.Size = new System.Drawing.Size(57, 19);
            this.label_diff_info.TabIndex = 6;
            this.label_diff_info.Text = "差額：";
            // 
            // label_diff
            // 
            this.label_diff.AutoSize = true;
            this.label_diff.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_diff.Location = new System.Drawing.Point(391, 283);
            this.label_diff.Name = "label_diff";
            this.label_diff.Size = new System.Drawing.Size(0, 19);
            this.label_diff.TabIndex = 9;
            // 
            // emoneyInput1
            // 
            this.emoneyInput1.Location = new System.Drawing.Point(312, 10);
            this.emoneyInput1.Name = "emoneyInput1";
            this.emoneyInput1.Size = new System.Drawing.Size(231, 157);
            this.emoneyInput1.TabIndex = 2;
            // 
            // cashInput
            // 
            this.cashInput.Location = new System.Drawing.Point(12, 10);
            this.cashInput.Name = "cashInput";
            this.cashInput.Size = new System.Drawing.Size(249, 446);
            this.cashInput.TabIndex = 0;
            // 
            // FundCollatorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 468);
            this.Controls.Add(this.label_diff);
            this.Controls.Add(this.label_diff_info);
            this.Controls.Add(this.label_from_db);
            this.Controls.Add(this.label_cash);
            this.Controls.Add(this.label_from_db_info);
            this.Controls.Add(this.label_cash_info);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.emoneyInput1);
            this.Controls.Add(this.cashInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FundCollatorFrom";
            this.Text = "手持金額照合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CashInput cashInput;
        private EmoneyInput emoneyInput1;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Label label_cash_info;
        private System.Windows.Forms.Label label_from_db_info;
        private System.Windows.Forms.Label label_cash;
        private System.Windows.Forms.Label label_from_db;
        private System.Windows.Forms.Label label_diff_info;
        private System.Windows.Forms.Label label_diff;
    }
}

