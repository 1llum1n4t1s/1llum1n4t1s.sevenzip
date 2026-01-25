using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice.Settings
{
    partial class CustomizeWindow
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CustomizeWindow));
            this.RootPanel = new TableLayoutPanel();
            this.AddButton = new Button();
            this.DestinationTreeView = new TreeView();
            this.SourceTreeView = new TreeView();
            this.DestinationLabel = new Label();
            this.SourceLabel = new Label();
            this.SubCommandPanel = new TableLayoutPanel();
            this.RemoveButton = new Button();
            this.RenameButton = new Button();
            this.NewCategoryButton = new Button();
            this.DownButton = new Button();
            this.UpButton = new Button();
            this.FooterPanel = new TableLayoutPanel();
            this.ExitButton = new Button();
            this.ApplyButton = new Button();
            this.RootPanel.SuspendLayout();
            this.SubCommandPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 6;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.RootPanel.Controls.Add(this.AddButton, 2, 2);
            this.RootPanel.Controls.Add(this.DestinationTreeView, 3, 2);
            this.RootPanel.Controls.Add(this.SourceTreeView, 1, 2);
            this.RootPanel.Controls.Add(this.DestinationLabel, 3, 1);
            this.RootPanel.Controls.Add(this.SourceLabel, 1, 1);
            this.RootPanel.Controls.Add(this.SubCommandPanel, 4, 2);
            this.RootPanel.Controls.Add(this.FooterPanel, 0, 3);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 4;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            this.RootPanel.Size = new Size(634, 321);
            this.RootPanel.TabIndex = 0;
            //
            // AddButton
            //
            this.AddButton.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            this.AddButton.Location = new Point(239, 124);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new Size(50, 40);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "→";
            this.AddButton.UseVisualStyleBackColor = true;
            //
            // DestinationTreeView
            //
            this.DestinationTreeView.Dock = DockStyle.Fill;
            this.DestinationTreeView.HideSelection = false;
            this.DestinationTreeView.LabelEdit = true;
            this.DestinationTreeView.Location = new Point(295, 36);
            this.DestinationTreeView.Name = "DestinationTreeView";
            this.DestinationTreeView.Size = new Size(221, 216);
            this.DestinationTreeView.TabIndex = 8;
            //
            // SourceTreeView
            //
            this.SourceTreeView.Dock = DockStyle.Fill;
            this.SourceTreeView.HideSelection = false;
            this.SourceTreeView.Location = new Point(12, 36);
            this.SourceTreeView.Name = "SourceTreeView";
            this.SourceTreeView.Size = new Size(221, 216);
            this.SourceTreeView.TabIndex = 7;
            //
            // DestinationLabel
            //
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Dock = DockStyle.Fill;
            this.DestinationLabel.Location = new Point(295, 12);
            this.DestinationLabel.Margin = new Padding(3);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new Size(221, 18);
            this.DestinationLabel.TabIndex = 6;
            this.DestinationLabel.Text = "現在のコンテキストメニュー";
            this.DestinationLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // SourceLabel
            //
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Dock = DockStyle.Fill;
            this.SourceLabel.Location = new Point(12, 12);
            this.SourceLabel.Margin = new Padding(3);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new Size(221, 18);
            this.SourceLabel.TabIndex = 5;
            this.SourceLabel.Text = "追加可能なコンテキストメニュー";
            this.SourceLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // SubCommandPanel
            //
            this.SubCommandPanel.ColumnCount = 1;
            this.SubCommandPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.SubCommandPanel.Controls.Add(this.RemoveButton, 0, 3);
            this.SubCommandPanel.Controls.Add(this.RenameButton, 0, 4);
            this.SubCommandPanel.Controls.Add(this.NewCategoryButton, 0, 2);
            this.SubCommandPanel.Controls.Add(this.DownButton, 0, 1);
            this.SubCommandPanel.Controls.Add(this.UpButton, 0, 0);
            this.SubCommandPanel.Dock = DockStyle.Fill;
            this.SubCommandPanel.Location = new Point(519, 33);
            this.SubCommandPanel.Margin = new Padding(0);
            this.SubCommandPanel.Name = "SubCommandPanel";
            this.SubCommandPanel.RowCount = 6;
            this.SubCommandPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.SubCommandPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.SubCommandPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.SubCommandPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.SubCommandPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.SubCommandPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.SubCommandPanel.Size = new Size(106, 222);
            this.SubCommandPanel.TabIndex = 3;
            //
            // RemoveButton
            //
            this.RemoveButton.Dock = DockStyle.Fill;
            this.RemoveButton.Location = new Point(3, 111);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new Size(100, 30);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "削除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            //
            // RenameButton
            //
            this.RenameButton.Dock = DockStyle.Fill;
            this.RenameButton.Location = new Point(3, 147);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new Size(100, 30);
            this.RenameButton.TabIndex = 4;
            this.RenameButton.Text = "名前の変更";
            this.RenameButton.UseVisualStyleBackColor = true;
            //
            // NewCategoryButton
            //
            this.NewCategoryButton.Dock = DockStyle.Fill;
            this.NewCategoryButton.Location = new Point(3, 75);
            this.NewCategoryButton.Name = "NewCategoryButton";
            this.NewCategoryButton.Size = new Size(100, 30);
            this.NewCategoryButton.TabIndex = 3;
            this.NewCategoryButton.Text = "新しいカテゴリー";
            this.NewCategoryButton.UseVisualStyleBackColor = true;
            //
            // DownButton
            //
            this.DownButton.Dock = DockStyle.Fill;
            this.DownButton.Location = new Point(3, 39);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new Size(100, 30);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "下に移動";
            this.DownButton.UseVisualStyleBackColor = true;
            //
            // UpButton
            //
            this.UpButton.Dock = DockStyle.Fill;
            this.UpButton.Location = new Point(3, 3);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new Size(100, 30);
            this.UpButton.TabIndex = 1;
            this.UpButton.Text = "上に移動";
            this.UpButton.UseVisualStyleBackColor = true;
            //
            // FooterPanel
            //
            this.FooterPanel.BackColor = SystemColors.Control;
            this.FooterPanel.ColumnCount = 4;
            this.RootPanel.SetColumnSpan(this.FooterPanel, 6);
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.FooterPanel.Controls.Add(this.ExitButton, 2, 1);
            this.FooterPanel.Controls.Add(this.ApplyButton, 1, 1);
            this.FooterPanel.Dock = DockStyle.Fill;
            this.FooterPanel.Location = new Point(0, 267);
            this.FooterPanel.Margin = new Padding(0, 12, 0, 0);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.RowCount = 3;
            this.FooterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.FooterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.FooterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.FooterPanel.Size = new Size(634, 54);
            this.FooterPanel.TabIndex = 4;
            //
            // ExitButton
            //
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Dock = DockStyle.Fill;
            this.ExitButton.Location = new Point(522, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(100, 30);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // ApplyButton
            //
            this.ApplyButton.DialogResult = DialogResult.OK;
            this.ApplyButton.Dock = DockStyle.Fill;
            this.ApplyButton.Location = new Point(391, 12);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new Size(125, 30);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "OK";
            this.ApplyButton.UseVisualStyleBackColor = true;
            //
            // CustomizeWindow
            //
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(634, 321);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new Size(540, 320);
            this.Name = "CustomizeWindow";
            this.Text = "コンテキストメニューのカスタマイズ";
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            this.SubCommandPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private TableLayoutPanel SubCommandPanel;
        private TableLayoutPanel FooterPanel;
        private Button RenameButton;
        private Button NewCategoryButton;
        private Button DownButton;
        private Button UpButton;
        private Button ExitButton;
        private Button ApplyButton;
        private Button RemoveButton;
        private TreeView DestinationTreeView;
        private TreeView SourceTreeView;
        private Label DestinationLabel;
        private Label SourceLabel;
        private Button AddButton;
    }
}