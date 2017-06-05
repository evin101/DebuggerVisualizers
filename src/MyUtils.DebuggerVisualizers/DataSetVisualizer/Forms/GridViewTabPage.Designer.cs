namespace MyUtils.DebuggerVisualizers.DataSetVisualizer.Forms
{
    partial class InitializedGridViewContainer
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.DataRowGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataRowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataRowGridView
            // 
            this.DataRowGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataRowGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataRowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRowGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataRowGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataRowGridView.Location = new System.Drawing.Point(0, 0);
            this.DataRowGridView.Margin = new System.Windows.Forms.Padding(0);
            this.DataRowGridView.MultiSelect = false;
            this.DataRowGridView.Name = "DataRowGridView";
            this.DataRowGridView.ReadOnly = true;
            this.DataRowGridView.RowHeadersVisible = false;
            this.DataRowGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.DataRowGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataRowGridView.RowTemplate.Height = 21;
            this.DataRowGridView.RowTemplate.ReadOnly = true;
            this.DataRowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataRowGridView.Size = new System.Drawing.Size(597, 193);
            this.DataRowGridView.StandardTab = true;
            this.DataRowGridView.TabIndex = 1;
            // 
            // InitializedGridViewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataRowGridView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InitializedGridViewContainer";
            this.Size = new System.Drawing.Size(597, 193);
            ((System.ComponentModel.ISupportInitialize)(this.DataRowGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataRowGridView;
    }
}
