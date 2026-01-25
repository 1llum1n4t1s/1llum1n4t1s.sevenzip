using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice
{
    partial class OverwriteWindow
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(OverwriteWindow));
            this.RootPanel = new TableLayoutPanel();
            this.IconPictureBox = new PictureBox();
            this.DescriptionLabel = new Label();
            this.ButtonsPanel = new FlowLayoutPanel();
            this.AlwaysRenameButton = new Button();
            this.AlwaysYesButton = new Button();
            this.YesButton = new Button();
            this.ExitButton = new Button();
            this.AlwaysNoButton = new Button();
            this.NoButton = new Button();
            this.RootPanel.SuspendLayout();
            ((ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 2;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RootPanel.Controls.Add(this.IconPictureBox, 0, 0);
            this.RootPanel.Controls.Add(this.DescriptionLabel, 1, 0);
            this.RootPanel.Controls.Add(this.ButtonsPanel, 0, 1);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 2;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            this.RootPanel.Size = new Size(484, 331);
            this.RootPanel.TabIndex = 0;
            //
            // IconPictureBox
            //
            this.IconPictureBox.Dock = DockStyle.Fill;
            this.IconPictureBox.Location = new Point(3, 3);
            this.IconPictureBox.Margin = new Padding(3, 3, 3, 120);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new Size(74, 118);
            this.IconPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            //
            // DescriptionLabel
            //
            this.DescriptionLabel.Dock = DockStyle.Fill;
            this.DescriptionLabel.Location = new Point(84, 20);
            this.DescriptionLabel.Margin = new Padding(4, 20, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new Size(396, 221);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "この場所には同じ名前のファイルが既に存在します。上書きしますか？\r\n\r\n現在のファイル\r\nD:\\Foo\\Bar\\Bas.txt\r\nサイズ : 12.3KB\r\n更新" +
    "日時 : 2017/07/10 23:55:55\r\n\r\n新しいファイル\r\nBas.txt\r\nサイズ : 34.5KB\r\n更新日時 : 2017/07/10 12" +
    ":12:12";
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.BackColor = SystemColors.Control;
            this.RootPanel.SetColumnSpan(this.ButtonsPanel, 2);
            this.ButtonsPanel.Controls.Add(this.AlwaysRenameButton);
            this.ButtonsPanel.Controls.Add(this.AlwaysYesButton);
            this.ButtonsPanel.Controls.Add(this.YesButton);
            this.ButtonsPanel.Controls.Add(this.ExitButton);
            this.ButtonsPanel.Controls.Add(this.AlwaysNoButton);
            this.ButtonsPanel.Controls.Add(this.NoButton);
            this.ButtonsPanel.Dock = DockStyle.Fill;
            this.ButtonsPanel.Location = new Point(0, 241);
            this.ButtonsPanel.Margin = new Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new Padding(0, 9, 9, 0);
            this.ButtonsPanel.RightToLeft = RightToLeft.Yes;
            this.ButtonsPanel.Size = new Size(484, 90);
            this.ButtonsPanel.TabIndex = 2;
            //
            // AlwaysRenameButton
            //
            this.AlwaysRenameButton.Location = new Point(347, 12);
            this.AlwaysRenameButton.Name = "AlwaysRenameButton";
            this.AlwaysRenameButton.Size = new Size(125, 30);
            this.AlwaysRenameButton.TabIndex = 4;
            this.AlwaysRenameButton.Text = "すべてリネーム";
            this.AlwaysRenameButton.UseVisualStyleBackColor = true;
            //
            // AlwaysYesButton
            //
            this.AlwaysYesButton.Location = new Point(216, 12);
            this.AlwaysYesButton.Name = "AlwaysYesButton";
            this.AlwaysYesButton.Size = new Size(125, 30);
            this.AlwaysYesButton.TabIndex = 2;
            this.AlwaysYesButton.Text = "すべてはい";
            this.AlwaysYesButton.UseVisualStyleBackColor = true;
            //
            // YesButton
            //
            this.ButtonsPanel.SetFlowBreak(this.YesButton, true);
            this.YesButton.Location = new Point(85, 12);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new Size(125, 30);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "はい";
            this.YesButton.UseVisualStyleBackColor = true;
            //
            // ExitButton
            //
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Location = new Point(347, 48);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(125, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // AlwaysNoButton
            //
            this.AlwaysNoButton.Location = new Point(216, 48);
            this.AlwaysNoButton.Name = "AlwaysNoButton";
            this.AlwaysNoButton.Size = new Size(125, 30);
            this.AlwaysNoButton.TabIndex = 3;
            this.AlwaysNoButton.Text = "すべていいえ";
            this.AlwaysNoButton.UseVisualStyleBackColor = true;
            //
            // NoButton
            //
            this.NoButton.Location = new Point(85, 48);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new Size(125, 30);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "いいえ";
            this.NoButton.UseVisualStyleBackColor = true;
            //
            // OverwriteWindow
            //
            this.AcceptButton = this.YesButton;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(484, 331);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(128)));
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverwriteWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "上書きの確認";
            this.RootPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private FlowLayoutPanel ButtonsPanel;
        private Button YesButton;
        private Button NoButton;
        private Button ExitButton;
        private Button AlwaysYesButton;
        private Button AlwaysNoButton;
        private Button AlwaysRenameButton;
        private PictureBox IconPictureBox;
        private Label DescriptionLabel;
    }
}