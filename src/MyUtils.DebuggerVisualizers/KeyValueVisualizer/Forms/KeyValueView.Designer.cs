using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyUtils.DebuggerVisualizers.KeyValueVisualizer.Forms
{
    partial class KeyValueView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyValueView));
            this.EntityGridView = new System.Windows.Forms.DataGridView();
            this.TypeNameLabel = new System.Windows.Forms.Label();
            this.TypeNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EntityGridView
            // 
            this.EntityGridView.AllowUserToAddRows = false;
            this.EntityGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.EntityGridView, "EntityGridView");
            this.EntityGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EntityGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntityGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.EntityGridView.MultiSelect = false;
            this.EntityGridView.Name = "EntityGridView";
            this.EntityGridView.ReadOnly = true;
            this.EntityGridView.RowHeadersVisible = false;
            this.EntityGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.EntityGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EntityGridView.RowTemplate.Height = 21;
            this.EntityGridView.RowTemplate.ReadOnly = true;
            this.EntityGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EntityGridView.StandardTab = true;
            // 
            // TypeNameLabel
            // 
            resources.ApplyResources(this.TypeNameLabel, "TypeNameLabel");
            this.TypeNameLabel.Name = "TypeNameLabel";
            // 
            // TypeNameTextBox
            // 
            resources.ApplyResources(this.TypeNameTextBox, "TypeNameTextBox");
            this.TypeNameTextBox.Name = "TypeNameTextBox";
            this.TypeNameTextBox.ReadOnly = true;
            // 
            // KeyValueView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TypeNameTextBox);
            this.Controls.Add(this.TypeNameLabel);
            this.Controls.Add(this.EntityGridView);
            this.Name = "KeyValueView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CollectionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView EntityGridView;
        private Label TypeNameLabel;
        private TextBox TypeNameTextBox;

        #endregion
    }
}