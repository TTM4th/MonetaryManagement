namespace FundRegister
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
            KubunListBox = new System.Windows.Forms.ListBox();
            KubunGroupBox = new System.Windows.Forms.GroupBox();
            SelectDateCalender = new System.Windows.Forms.MonthCalendar();
            InputGridView = new System.Windows.Forms.DataGridView();
            EnterButton = new System.Windows.Forms.Button();
            DeleteButton = new System.Windows.Forms.Button();
            RegisterButton = new System.Windows.Forms.Button();
            InputGroupBox = new System.Windows.Forms.GroupBox();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KubunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputGridView).BeginInit();
            InputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // KubunListBox
            // 
            KubunListBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            KubunListBox.FormattingEnabled = true;
            KubunListBox.ItemHeight = 13;
            KubunListBox.Location = new System.Drawing.Point(16, 35);
            KubunListBox.Margin = new System.Windows.Forms.Padding(4);
            KubunListBox.Name = "KubunListBox";
            KubunListBox.Size = new System.Drawing.Size(170, 147);
            KubunListBox.TabIndex = 0;
            KubunListBox.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // KubunGroupBox
            // 
            KubunGroupBox.Controls.Add(KubunListBox);
            KubunGroupBox.Location = new System.Drawing.Point(267, 40);
            KubunGroupBox.Margin = new System.Windows.Forms.Padding(4);
            KubunGroupBox.Name = "KubunGroupBox";
            KubunGroupBox.Padding = new System.Windows.Forms.Padding(4);
            KubunGroupBox.Size = new System.Drawing.Size(203, 210);
            KubunGroupBox.TabIndex = 1;
            KubunGroupBox.TabStop = false;
            KubunGroupBox.Text = "区分";
            // 
            // SelectDateCalender
            // 
            SelectDateCalender.Location = new System.Drawing.Point(21, 48);
            SelectDateCalender.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            SelectDateCalender.MaxSelectionCount = 1;
            SelectDateCalender.Name = "SelectDateCalender";
            SelectDateCalender.TabIndex = 2;
            SelectDateCalender.DateSelected += SelectDateCalender_DateSelected;
            // 
            // InputGridView
            // 
            InputGridView.AllowUserToAddRows = false;
            InputGridView.AllowUserToDeleteRows = false;
            InputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Date, Price, Classification });
            InputGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            InputGridView.Location = new System.Drawing.Point(15, 24);
            InputGridView.Margin = new System.Windows.Forms.Padding(4);
            InputGridView.MultiSelect = false;
            InputGridView.Name = "InputGridView";
            InputGridView.RowTemplate.Height = 21;
            InputGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            InputGridView.Size = new System.Drawing.Size(318, 365);
            InputGridView.TabIndex = 3;
            // 
            // EnterButton
            // 
            EnterButton.Location = new System.Drawing.Point(349, 24);
            EnterButton.Margin = new System.Windows.Forms.Padding(4);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new System.Drawing.Size(88, 29);
            EnterButton.TabIndex = 4;
            EnterButton.Text = "追加";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(349, 61);
            DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(88, 29);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "消去";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new System.Drawing.Point(349, 98);
            RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new System.Drawing.Size(86, 68);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "登録";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // InputGroupBox
            // 
            InputGroupBox.Controls.Add(InputGridView);
            InputGroupBox.Controls.Add(RegisterButton);
            InputGroupBox.Controls.Add(EnterButton);
            InputGroupBox.Controls.Add(DeleteButton);
            InputGroupBox.Location = new System.Drawing.Point(21, 265);
            InputGroupBox.Margin = new System.Windows.Forms.Padding(4);
            InputGroupBox.Name = "InputGroupBox";
            InputGroupBox.Padding = new System.Windows.Forms.Padding(4);
            InputGroupBox.Size = new System.Drawing.Size(449, 421);
            InputGroupBox.TabIndex = 7;
            InputGroupBox.TabStop = false;
            InputGroupBox.Text = "入力データ";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ID.Visible = false;
            // 
            // Date
            // 
            Date.HeaderText = "日付";
            Date.MaxInputLength = 10;
            Date.MinimumWidth = 120;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Date.Width = 120;
            // 
            // Price
            // 
            Price.HeaderText = "利用金額";
            Price.MinimumWidth = 120;
            Price.Name = "Price";
            Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Price.Width = 120;
            // 
            // Classification
            // 
            Classification.FillWeight = 30F;
            Classification.HeaderText = "区分";
            Classification.MaxInputLength = 1;
            Classification.MinimumWidth = 35;
            Classification.Name = "Classification";
            Classification.ReadOnly = true;
            Classification.Width = 35;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(484, 709);
            Controls.Add(InputGroupBox);
            Controls.Add(SelectDateCalender);
            Controls.Add(KubunGroupBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            Name = "RegisterForm";
            Text = "データ入力";
            Load += RegisterForm_Load;
            KubunGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InputGridView).EndInit();
            InputGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox KubunGroupBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.GroupBox InputGroupBox;
        internal System.Windows.Forms.DataGridView InputGridView;
        internal System.Windows.Forms.MonthCalendar SelectDateCalender;
        internal System.Windows.Forms.ListBox KubunListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
    }
}

