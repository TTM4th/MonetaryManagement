namespace FundCollator
{
    partial class EmoneyInput
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Emoney = new System.Windows.Forms.GroupBox();
            this.emoney_textBox = new System.Windows.Forms.TextBox();
            this.label_yen = new System.Windows.Forms.Label();
            this.groupBox_Emoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Emoney
            // 
            this.groupBox_Emoney.Controls.Add(this.emoney_textBox);
            this.groupBox_Emoney.Controls.Add(this.label_yen);
            this.groupBox_Emoney.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Emoney.Name = "groupBox_Emoney";
            this.groupBox_Emoney.Size = new System.Drawing.Size(221, 147);
            this.groupBox_Emoney.TabIndex = 0;
            this.groupBox_Emoney.TabStop = false;
            this.groupBox_Emoney.Text = "電子マネー";
            // 
            // emoney_textBox
            // 
            this.emoney_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.emoney_textBox.Location = new System.Drawing.Point(42, 63);
            this.emoney_textBox.Name = "emoney_textBox";
            this.emoney_textBox.ShortcutsEnabled = false;
            this.emoney_textBox.Size = new System.Drawing.Size(104, 19);
            this.emoney_textBox.TabIndex = 1;
            this.emoney_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emoney_textBox_KeyPress);
            // 
            // label_yen
            // 
            this.label_yen.AutoSize = true;
            this.label_yen.Location = new System.Drawing.Point(152, 66);
            this.label_yen.Name = "label_yen";
            this.label_yen.Size = new System.Drawing.Size(17, 12);
            this.label_yen.TabIndex = 0;
            this.label_yen.Text = "円";
            // 
            // EmoneyInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Emoney);
            this.Name = "EmoneyInput";
            this.Size = new System.Drawing.Size(231, 157);
            this.groupBox_Emoney.ResumeLayout(false);
            this.groupBox_Emoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Emoney;
        private System.Windows.Forms.TextBox emoney_textBox;
        private System.Windows.Forms.Label label_yen;
    }
}
