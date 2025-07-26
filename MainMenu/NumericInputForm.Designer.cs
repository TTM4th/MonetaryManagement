using System.Windows.Forms;

namespace MainMenu
{
    partial class NumericInputForm
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

        private TextBox TextBox;
        private Button OkButton;

        private void InitializeComponent()
        {
            TextBox = new TextBox();
            OkButton = new Button();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Location = new System.Drawing.Point(46, 28);
            TextBox.Name = "TextBox";
            TextBox.Size = new System.Drawing.Size(155, 31);
            TextBox.TabIndex = 0;
            TextBox.KeyPress += TextBox_KeyPress;
            // 
            // OkButton
            // 
            OkButton.Location = new System.Drawing.Point(86, 74);
            OkButton.Name = "OkButton";
            OkButton.Size = new System.Drawing.Size(75, 38);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.Click += OkButton_Click;
            // 
            // NumericInputForm
            // 
            AcceptButton = OkButton;
            ClientSize = new System.Drawing.Size(241, 150);
            Controls.Add(TextBox);
            Controls.Add(OkButton);
            Name = "NumericInputForm";
            Text = "数値入力";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
