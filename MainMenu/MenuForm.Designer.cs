namespace MainMenu
{
    partial class MenuForm
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
            this.TableNameComboBox = new System.Windows.Forms.ComboBox();
            this.SelectTableNameGroupBox = new System.Windows.Forms.GroupBox();
            this.RunFundRegister = new System.Windows.Forms.Button();
            this.NowBalanceGroupBox = new System.Windows.Forms.GroupBox();
            this.button_Run_collator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NowBalanceLabel = new System.Windows.Forms.Label();
            this.SelectTableNameGroupBox.SuspendLayout();
            this.NowBalanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableNameComboBox
            // 
            this.TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableNameComboBox.FormattingEnabled = true;
            this.TableNameComboBox.Location = new System.Drawing.Point(6, 36);
            this.TableNameComboBox.Name = "TableNameComboBox";
            this.TableNameComboBox.Size = new System.Drawing.Size(188, 20);
            this.TableNameComboBox.TabIndex = 0;
            // 
            // SelectTableNameGroupBox
            // 
            this.SelectTableNameGroupBox.Controls.Add(this.RunFundRegister);
            this.SelectTableNameGroupBox.Controls.Add(this.TableNameComboBox);
            this.SelectTableNameGroupBox.Location = new System.Drawing.Point(12, 13);
            this.SelectTableNameGroupBox.Name = "SelectTableNameGroupBox";
            this.SelectTableNameGroupBox.Size = new System.Drawing.Size(201, 153);
            this.SelectTableNameGroupBox.TabIndex = 1;
            this.SelectTableNameGroupBox.TabStop = false;
            this.SelectTableNameGroupBox.Text = "テーブル選択";
            // 
            // RunFundRegister
            // 
            this.RunFundRegister.Location = new System.Drawing.Point(119, 113);
            this.RunFundRegister.Name = "RunFundRegister";
            this.RunFundRegister.Size = new System.Drawing.Size(75, 23);
            this.RunFundRegister.TabIndex = 2;
            this.RunFundRegister.Text = "登録画面へ";
            this.RunFundRegister.UseVisualStyleBackColor = true;
            this.RunFundRegister.Click += new System.EventHandler(this.RunFundRegister_Click);
            // 
            // NowBalanceGroupBox
            // 
            this.NowBalanceGroupBox.Controls.Add(this.button_Run_collator);
            this.NowBalanceGroupBox.Controls.Add(this.label1);
            this.NowBalanceGroupBox.Controls.Add(this.NowBalanceLabel);
            this.NowBalanceGroupBox.Location = new System.Drawing.Point(242, 13);
            this.NowBalanceGroupBox.Name = "NowBalanceGroupBox";
            this.NowBalanceGroupBox.Size = new System.Drawing.Size(271, 153);
            this.NowBalanceGroupBox.TabIndex = 2;
            this.NowBalanceGroupBox.TabStop = false;
            this.NowBalanceGroupBox.Text = "現在手持残高";
            // 
            // button_Run_collator
            // 
            this.button_Run_collator.Location = new System.Drawing.Point(142, 113);
            this.button_Run_collator.Name = "button_Run_collator";
            this.button_Run_collator.Size = new System.Drawing.Size(113, 22);
            this.button_Run_collator.TabIndex = 2;
            this.button_Run_collator.Text = "手持残高との照合";
            this.button_Run_collator.UseVisualStyleBackColor = true;
            this.button_Run_collator.Click += new System.EventHandler(this.Button_Run_collator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "￥";
            // 
            // NowBalanceLabel
            // 
            this.NowBalanceLabel.AutoSize = true;
            this.NowBalanceLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowBalanceLabel.Location = new System.Drawing.Point(86, 65);
            this.NowBalanceLabel.Name = "NowBalanceLabel";
            this.NowBalanceLabel.Size = new System.Drawing.Size(105, 19);
            this.NowBalanceLabel.TabIndex = 0;
            this.NowBalanceLabel.Text = "<現在残高>";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NowBalanceGroupBox);
            this.Controls.Add(this.SelectTableNameGroupBox);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SelectTableNameGroupBox.ResumeLayout(false);
            this.NowBalanceGroupBox.ResumeLayout(false);
            this.NowBalanceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SelectTableNameGroupBox;
        private System.Windows.Forms.Button RunFundRegister;
        private System.Windows.Forms.GroupBox NowBalanceGroupBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label NowBalanceLabel;
        internal System.Windows.Forms.ComboBox TableNameComboBox;
        private System.Windows.Forms.Button button_Run_collator;
    }
}

