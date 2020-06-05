namespace MainMenu
{
    partial class Form1
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
            this.SelectTableNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableNameComboBox
            // 
            this.TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableNameComboBox.FormattingEnabled = true;
            this.TableNameComboBox.Items.AddRange(new object[] {
            "2020-06",
            "TEST"});
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
            this.SelectTableNameGroupBox.Size = new System.Drawing.Size(200, 100);
            this.SelectTableNameGroupBox.TabIndex = 1;
            this.SelectTableNameGroupBox.TabStop = false;
            this.SelectTableNameGroupBox.Text = "テーブル選択";
            // 
            // RunFundRegister
            // 
            this.RunFundRegister.Location = new System.Drawing.Point(119, 62);
            this.RunFundRegister.Name = "RunFundRegister";
            this.RunFundRegister.Size = new System.Drawing.Size(75, 23);
            this.RunFundRegister.TabIndex = 2;
            this.RunFundRegister.Text = "登録画面へ";
            this.RunFundRegister.UseVisualStyleBackColor = true;
            this.RunFundRegister.Click += new System.EventHandler(this.RunFundRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectTableNameGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SelectTableNameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TableNameComboBox;
        private System.Windows.Forms.GroupBox SelectTableNameGroupBox;
        private System.Windows.Forms.Button RunFundRegister;
    }
}

