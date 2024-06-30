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
            TableNameComboBox = new System.Windows.Forms.ComboBox();
            SelectTableNameGroupBox = new System.Windows.Forms.GroupBox();
            RunFundRegister = new System.Windows.Forms.Button();
            NowBalanceGroupBox = new System.Windows.Forms.GroupBox();
            button_Run_collator = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            NowBalanceLabel = new System.Windows.Forms.Label();
            sumByClassBox = new SumByClass();
            SelectTableNameGroupBox.SuspendLayout();
            NowBalanceGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TableNameComboBox
            // 
            TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TableNameComboBox.FormattingEnabled = true;
            TableNameComboBox.Location = new System.Drawing.Point(7, 45);
            TableNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            TableNameComboBox.Name = "TableNameComboBox";
            TableNameComboBox.Size = new System.Drawing.Size(219, 23);
            TableNameComboBox.TabIndex = 0;
            TableNameComboBox.SelectedValueChanged += TableNameComboBox_SelectedValueChanged;
            // 
            // SelectTableNameGroupBox
            // 
            SelectTableNameGroupBox.Controls.Add(RunFundRegister);
            SelectTableNameGroupBox.Controls.Add(TableNameComboBox);
            SelectTableNameGroupBox.Location = new System.Drawing.Point(14, 16);
            SelectTableNameGroupBox.Margin = new System.Windows.Forms.Padding(4);
            SelectTableNameGroupBox.Name = "SelectTableNameGroupBox";
            SelectTableNameGroupBox.Padding = new System.Windows.Forms.Padding(4);
            SelectTableNameGroupBox.Size = new System.Drawing.Size(234, 191);
            SelectTableNameGroupBox.TabIndex = 1;
            SelectTableNameGroupBox.TabStop = false;
            SelectTableNameGroupBox.Text = "テーブル選択";
            // 
            // RunFundRegister
            // 
            RunFundRegister.Location = new System.Drawing.Point(139, 141);
            RunFundRegister.Margin = new System.Windows.Forms.Padding(4);
            RunFundRegister.Name = "RunFundRegister";
            RunFundRegister.Size = new System.Drawing.Size(88, 29);
            RunFundRegister.TabIndex = 2;
            RunFundRegister.Text = "登録画面へ";
            RunFundRegister.UseVisualStyleBackColor = true;
            RunFundRegister.Click += RunFundRegister_Click;
            // 
            // NowBalanceGroupBox
            // 
            NowBalanceGroupBox.Controls.Add(button_Run_collator);
            NowBalanceGroupBox.Controls.Add(label1);
            NowBalanceGroupBox.Controls.Add(NowBalanceLabel);
            NowBalanceGroupBox.Location = new System.Drawing.Point(282, 16);
            NowBalanceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            NowBalanceGroupBox.Name = "NowBalanceGroupBox";
            NowBalanceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            NowBalanceGroupBox.Size = new System.Drawing.Size(316, 191);
            NowBalanceGroupBox.TabIndex = 2;
            NowBalanceGroupBox.TabStop = false;
            NowBalanceGroupBox.Text = "現在手持残高";
            // 
            // button_Run_collator
            // 
            button_Run_collator.Location = new System.Drawing.Point(166, 141);
            button_Run_collator.Margin = new System.Windows.Forms.Padding(4);
            button_Run_collator.Name = "button_Run_collator";
            button_Run_collator.Size = new System.Drawing.Size(132, 28);
            button_Run_collator.TabIndex = 2;
            button_Run_collator.Text = "手持残高との照合";
            button_Run_collator.UseVisualStyleBackColor = true;
            button_Run_collator.Click += Button_Run_collator_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            label1.Location = new System.Drawing.Point(61, 82);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 19);
            label1.TabIndex = 1;
            label1.Text = "￥";
            // 
            // NowBalanceLabel
            // 
            NowBalanceLabel.AutoSize = true;
            NowBalanceLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            NowBalanceLabel.Location = new System.Drawing.Point(100, 81);
            NowBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NowBalanceLabel.Name = "NowBalanceLabel";
            NowBalanceLabel.Size = new System.Drawing.Size(105, 19);
            NowBalanceLabel.TabIndex = 0;
            NowBalanceLabel.Text = "<現在残高>";
            // 
            // sumByClassBox
            // 
            sumByClassBox.AutoSize = true;
            sumByClassBox.Location = new System.Drawing.Point(0, 214);
            sumByClassBox.Name = "sumByClassBox";
            sumByClassBox.Size = new System.Drawing.Size(473, 316);
            sumByClassBox.TabIndex = 3;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(635, 562);
            Controls.Add(sumByClassBox);
            Controls.Add(NowBalanceGroupBox);
            Controls.Add(SelectTableNameGroupBox);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            Name = "MenuForm";
            Text = "MainMenu";
            Load += Form1_Load;
            SelectTableNameGroupBox.ResumeLayout(false);
            NowBalanceGroupBox.ResumeLayout(false);
            NowBalanceGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox SelectTableNameGroupBox;
        private System.Windows.Forms.Button RunFundRegister;
        private System.Windows.Forms.GroupBox NowBalanceGroupBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label NowBalanceLabel;
        internal System.Windows.Forms.ComboBox TableNameComboBox;
        private System.Windows.Forms.Button button_Run_collator;
        private SumByClass sumByClassBox;
    }
}

