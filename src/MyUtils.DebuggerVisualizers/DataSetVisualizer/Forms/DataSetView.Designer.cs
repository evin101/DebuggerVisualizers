using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyUtils.DebuggerVisualizers.DataSetVisualizer.Forms
{
    partial class DataSetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSetView));
            this.DataSetNameLabel = new System.Windows.Forms.Label();
            this.DataSetNameTextBox = new System.Windows.Forms.TextBox();
            this.DataTableTabControl = new System.Windows.Forms.TabControl();
            this.FirstTabPage = new System.Windows.Forms.TabPage();
            this.initializedGridViewContainer1 = new MyUtils.DebuggerVisualizers.DataSetVisualizer.Forms.InitializedGridViewContainer();
            this.DataTableTabControl.SuspendLayout();
            this.FirstTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataSetNameLabel
            // 
            resources.ApplyResources(this.DataSetNameLabel, "DataSetNameLabel");
            this.DataSetNameLabel.Name = "DataSetNameLabel";
            // 
            // TypeNameTextBox
            // 
            resources.ApplyResources(this.DataSetNameTextBox, "TypeNameTextBox");
            this.DataSetNameTextBox.Name = "TypeNameTextBox";
            this.DataSetNameTextBox.ReadOnly = true;
            // 
            // DataTableTabControl
            // 
            resources.ApplyResources(this.DataTableTabControl, "DataTableTabControl");
            this.DataTableTabControl.Controls.Add(this.FirstTabPage);
            this.DataTableTabControl.Name = "DataTableTabControl";
            this.DataTableTabControl.SelectedIndex = 0;
            // 
            // FirstTabPage
            // 
            this.FirstTabPage.Controls.Add(this.initializedGridViewContainer1);
            resources.ApplyResources(this.FirstTabPage, "FirstTabPage");
            this.FirstTabPage.Name = "FirstTabPage";
            this.FirstTabPage.UseVisualStyleBackColor = true;
            // 
            // initializedGridViewContainer1
            // 
            resources.ApplyResources(this.initializedGridViewContainer1, "initializedGridViewContainer1");
            this.initializedGridViewContainer1.Name = "initializedGridViewContainer1";
            // 
            // DataSetView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataTableTabControl);
            this.Controls.Add(this.DataSetNameTextBox);
            this.Controls.Add(this.DataSetNameLabel);
            this.Name = "DataSetView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.DataSetView_Load);
            this.DataTableTabControl.ResumeLayout(false);
            this.FirstTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label DataSetNameLabel;
        private TextBox DataSetNameTextBox;

        #endregion

        private TabControl DataTableTabControl;
        private TabPage FirstTabPage;
        private InitializedGridViewContainer initializedGridViewContainer1;
    }
}