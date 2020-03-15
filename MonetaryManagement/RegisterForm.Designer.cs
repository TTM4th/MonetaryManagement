namespace MonetaryManagement
{
    partial class RegisterForm
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
            this.KubunListBox = new System.Windows.Forms.ListBox();
            this.KubunGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectDateCalender = new System.Windows.Forms.MonthCalendar();
            this.InputGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.KubunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputGridView)).BeginInit();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // KubunListBox
            // 
            this.KubunListBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KubunListBox.FormattingEnabled = true;
            this.KubunListBox.Location = new System.Drawing.Point(26, 28);
            this.KubunListBox.Name = "KubunListBox";
            this.KubunListBox.Size = new System.Drawing.Size(101, 108);
            this.KubunListBox.TabIndex = 0;
            this.KubunListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // KubunGroupBox
            // 
            this.KubunGroupBox.Controls.Add(this.KubunListBox);
            this.KubunGroupBox.Location = new System.Drawing.Point(247, 32);
            this.KubunGroupBox.Name = "KubunGroupBox";
            this.KubunGroupBox.Size = new System.Drawing.Size(156, 168);
            this.KubunGroupBox.TabIndex = 1;
            this.KubunGroupBox.TabStop = false;
            this.KubunGroupBox.Text = "区分";
            // 
            // SelectDateCalender
            // 
            this.SelectDateCalender.Location = new System.Drawing.Point(18, 38);
            this.SelectDateCalender.MaxSelectionCount = 1;
            this.SelectDateCalender.Name = "SelectDateCalender";
            this.SelectDateCalender.TabIndex = 2;
            this.SelectDateCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.SelectDateCalender_DateSelected);
            // 
            // InputGridView
            // 
            this.InputGridView.AllowUserToAddRows = false;
            this.InputGridView.AllowUserToDeleteRows = false;
            this.InputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Price,
            this.Classification});
            this.InputGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.InputGridView.Location = new System.Drawing.Point(13, 19);
            this.InputGridView.Name = "InputGridView";
            this.InputGridView.RowTemplate.Height = 21;
            this.InputGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InputGridView.Size = new System.Drawing.Size(273, 292);
            this.InputGridView.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.HeaderText = "日付";
            this.Date.MaxInputLength = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price
            // 
            this.Price.HeaderText = "利用金額";
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classification
            // 
            this.Classification.FillWeight = 30F;
            this.Classification.HeaderText = "区分";
            this.Classification.MaxInputLength = 1;
            this.Classification.MinimumWidth = 30;
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.Width = 30;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(299, 19);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "追加";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(299, 49);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "消去";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(299, 78);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(74, 54);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "登録";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.InputGridView);
            this.InputGroupBox.Controls.Add(this.RegisterButton);
            this.InputGroupBox.Controls.Add(this.EnterButton);
            this.InputGroupBox.Controls.Add(this.DeleteButton);
            this.InputGroupBox.Location = new System.Drawing.Point(18, 212);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(385, 337);
            this.InputGroupBox.TabIndex = 7;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "入力データ";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(415, 567);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.SelectDateCalender);
            this.Controls.Add(this.KubunGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "データ入力";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.KubunGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputGridView)).EndInit();
            this.InputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox KubunGroupBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.GroupBox InputGroupBox;
        internal System.Windows.Forms.DataGridView InputGridView;
        internal System.Windows.Forms.MonthCalendar SelectDateCalender;
        internal System.Windows.Forms.ListBox KubunListBox;
    }
}

