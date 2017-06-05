namespace MyUtils.DebuggerVisualizers.UITest
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.CollectionVisualizerDialogButton = new System.Windows.Forms.Button();
            this.DataSetVisualizerDialogButton = new System.Windows.Forms.Button();
            this.KeyValueVisualizerDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CollectionVisualizerDialogButton
            // 
            this.CollectionVisualizerDialogButton.Location = new System.Drawing.Point(12, 12);
            this.CollectionVisualizerDialogButton.Name = "CollectionVisualizerDialogButton";
            this.CollectionVisualizerDialogButton.Size = new System.Drawing.Size(265, 45);
            this.CollectionVisualizerDialogButton.TabIndex = 0;
            this.CollectionVisualizerDialogButton.Text = "CollectionVisualizerDialog\r\n List<\'a>";
            this.CollectionVisualizerDialogButton.UseVisualStyleBackColor = true;
            this.CollectionVisualizerDialogButton.Click += new System.EventHandler(this.CollectionVisualizerDialogButton_Click);
            // 
            // DataSetVisualizerDialogButton
            // 
            this.DataSetVisualizerDialogButton.Location = new System.Drawing.Point(12, 63);
            this.DataSetVisualizerDialogButton.Name = "DataSetVisualizerDialogButton";
            this.DataSetVisualizerDialogButton.Size = new System.Drawing.Size(265, 45);
            this.DataSetVisualizerDialogButton.TabIndex = 1;
            this.DataSetVisualizerDialogButton.Text = "DataSetVisualizerDialog";
            this.DataSetVisualizerDialogButton.UseVisualStyleBackColor = true;
            this.DataSetVisualizerDialogButton.Click += new System.EventHandler(this.DataSetVisualizerDialogButton_Click);
            // 
            // KeyValueVisualizerDialogButton
            // 
            this.KeyValueVisualizerDialogButton.Location = new System.Drawing.Point(12, 114);
            this.KeyValueVisualizerDialogButton.Name = "KeyValueVisualizerDialogButton";
            this.KeyValueVisualizerDialogButton.Size = new System.Drawing.Size(265, 45);
            this.KeyValueVisualizerDialogButton.TabIndex = 2;
            this.KeyValueVisualizerDialogButton.Text = "KeyValueVisualizerDialog";
            this.KeyValueVisualizerDialogButton.UseVisualStyleBackColor = true;
            this.KeyValueVisualizerDialogButton.Click += new System.EventHandler(this.KeyValueVisualizerDialogButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 434);
            this.Controls.Add(this.KeyValueVisualizerDialogButton);
            this.Controls.Add(this.DataSetVisualizerDialogButton);
            this.Controls.Add(this.CollectionVisualizerDialogButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FormHarness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CollectionVisualizerDialogButton;
        private System.Windows.Forms.Button DataSetVisualizerDialogButton;
        private System.Windows.Forms.Button KeyValueVisualizerDialogButton;
    }
}

