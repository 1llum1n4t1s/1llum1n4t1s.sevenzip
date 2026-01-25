using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice.Settings
{
    partial class AssociateIconWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AssociateIconWindow));
            this.RootPanel = new TableLayoutPanel();
            this.HeaderLabel = new Label();
            this.IconListView = new ListView();
            this.ButtonsPanel = new TableLayoutPanel();
            this.ExecButton = new Button();
            this.ExitButton = new Button();
            this.RootPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 3;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.RootPanel.Controls.Add(this.HeaderLabel, 1, 1);
            this.RootPanel.Controls.Add(this.IconListView, 1, 2);
            this.RootPanel.Controls.Add(this.ButtonsPanel, 0, 4);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 5;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            this.RootPanel.Size = new Size(384, 191);
            this.RootPanel.TabIndex = 0;
            //
            // HeaderLabel
            //
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Dock = DockStyle.Fill;
            this.HeaderLabel.Location = new Point(12, 12);
            this.HeaderLabel.Margin = new Padding(3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new Size(360, 14);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "下の一覧からアイコンを選択";
            this.HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // IconListView
            //
            this.IconListView.Dock = DockStyle.Fill;
            this.IconListView.HideSelection = false;
            this.IconListView.Location = new Point(12, 32);
            this.IconListView.MultiSelect = false;
            this.IconListView.Name = "IconListView";
            this.IconListView.Size = new Size(360, 82);
            this.IconListView.TabIndex = 2;
            this.IconListView.UseCompatibleStateImageBehavior = false;
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.BackColor = SystemColors.Control;
            this.ButtonsPanel.ColumnCount = 4;
            this.RootPanel.SetColumnSpan(this.ButtonsPanel, 3);
            this.ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            this.ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.ButtonsPanel.Controls.Add(this.ExecButton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.ExitButton, 2, 0);
            this.ButtonsPanel.Dock = DockStyle.Fill;
            this.ButtonsPanel.Location = new Point(0, 137);
            this.ButtonsPanel.Margin = new Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 1;
            this.ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ButtonsPanel.Size = new Size(384, 54);
            this.ButtonsPanel.TabIndex = 0;
            //
            // ExecButton
            //
            this.ExecButton.DialogResult = DialogResult.OK;
            this.ExecButton.Dock = DockStyle.Fill;
            this.ExecButton.Location = new Point(141, 12);
            this.ExecButton.Margin = new Padding(3, 12, 3, 12);
            this.ExecButton.Name = "ExecButton";
            this.ExecButton.Size = new Size(125, 30);
            this.ExecButton.TabIndex = 1;
            this.ExecButton.Text = "OK";
            this.ExecButton.UseVisualStyleBackColor = true;
            //
            // ExitButton
            //
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Dock = DockStyle.Fill;
            this.ExitButton.Location = new Point(272, 12);
            this.ExitButton.Margin = new Padding(3, 12, 3, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(100, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // AssociateIconWindow
            //
            this.AcceptButton = this.ExitButton;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(384, 191);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new Size(400, 230);
            this.Name = "AssociateIconWindow";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "ファイルの関連付け用アイコンの変更";
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private Label HeaderLabel;
        private ListView IconListView;
        private TableLayoutPanel ButtonsPanel;
        private Button ExitButton;
        private Button ExecButton;
    }
}