using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice
{
    partial class CompressSettingWindow
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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CompressSettingWindow));
            this.RootPanel = new TableLayoutPanel();
            this.GeneralGroupBox = new GroupBox();
            this.GeneralPanel = new TableLayoutPanel();
            this.ThreadLabel = new Label();
            this.CompressionMethodComboBox = new ComboBox();
            this.MethodLabel = new Label();
            this.CompressionLevelComboBox = new ComboBox();
            this.LevelLabel = new Label();
            this.FormatLabel = new Label();
            this.FormatComboBox = new ComboBox();
            this.ThreadNumeric = new NumericUpDown();
            this.EncryptionGroupBox = new GroupBox();
            this.EncryptionWrapperPanel = new TableLayoutPanel();
            this.EncryptionCheckBox = new CheckBox();
            this.EncryptionPanel = new TableLayoutPanel();
            this.EncryptionMethodComboBox = new ComboBox();
            this.EncryptionLabel = new Label();
            this.ConfirmTextBox = new TextBox();
            this.ConfirmLabel = new Label();
            this.PasswordLabel = new Label();
            this.PasswordTextBox = new TextBox();
            this.ShowPasswordCheckBox = new CheckBox();
            this.ButtonsPanel = new FlowLayoutPanel();
            this.ExitButton = new Button();
            this.ExecuteButton = new Button();
            this.DestinationGroupBox = new GroupBox();
            this.DestinationPanel = new TableLayoutPanel();
            this.DestinationTextBox = new TextBox();
            this.DestinationButton = new Button();
            this.PathToolTip = new ToolTip(this.components);
            this.RootPanel.SuspendLayout();
            this.GeneralGroupBox.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            ((ISupportInitialize)(this.ThreadNumeric)).BeginInit();
            this.EncryptionGroupBox.SuspendLayout();
            this.EncryptionWrapperPanel.SuspendLayout();
            this.EncryptionPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DestinationGroupBox.SuspendLayout();
            this.DestinationPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 1;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RootPanel.Controls.Add(this.GeneralGroupBox, 0, 1);
            this.RootPanel.Controls.Add(this.EncryptionGroupBox, 0, 2);
            this.RootPanel.Controls.Add(this.ButtonsPanel, 0, 4);
            this.RootPanel.Controls.Add(this.DestinationGroupBox, 0, 0);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 5;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            this.RootPanel.Size = new Size(384, 471);
            this.RootPanel.TabIndex = 0;
            //
            // GeneralGroupBox
            //
            this.GeneralGroupBox.Controls.Add(this.GeneralPanel);
            this.GeneralGroupBox.Dock = DockStyle.Fill;
            this.GeneralGroupBox.Location = new Point(12, 67);
            this.GeneralGroupBox.Margin = new Padding(12, 3, 12, 3);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Padding = new Padding(8, 3, 8, 8);
            this.GeneralGroupBox.Size = new Size(360, 144);
            this.GeneralGroupBox.TabIndex = 4;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "詳細";
            //
            // GeneralPanel
            //
            this.GeneralPanel.ColumnCount = 2;
            this.GeneralPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            this.GeneralPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.GeneralPanel.Controls.Add(this.ThreadLabel, 0, 3);
            this.GeneralPanel.Controls.Add(this.CompressionMethodComboBox, 1, 2);
            this.GeneralPanel.Controls.Add(this.MethodLabel, 0, 2);
            this.GeneralPanel.Controls.Add(this.CompressionLevelComboBox, 1, 1);
            this.GeneralPanel.Controls.Add(this.LevelLabel, 0, 1);
            this.GeneralPanel.Controls.Add(this.FormatLabel, 0, 0);
            this.GeneralPanel.Controls.Add(this.FormatComboBox, 1, 0);
            this.GeneralPanel.Controls.Add(this.ThreadNumeric, 1, 3);
            this.GeneralPanel.Dock = DockStyle.Fill;
            this.GeneralPanel.Location = new Point(8, 19);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.RowCount = 4;
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.GeneralPanel.Size = new Size(344, 117);
            this.GeneralPanel.TabIndex = 0;
            //
            // ThreadLabel
            //
            this.ThreadLabel.AutoSize = true;
            this.ThreadLabel.Dock = DockStyle.Fill;
            this.ThreadLabel.Location = new Point(3, 90);
            this.ThreadLabel.Margin = new Padding(3);
            this.ThreadLabel.Name = "ThreadLabel";
            this.ThreadLabel.Size = new Size(94, 24);
            this.ThreadLabel.TabIndex = 104;
            this.ThreadLabel.Text = "スレッド数";
            this.ThreadLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // CompressionMethodComboBox
            //
            this.CompressionMethodComboBox.Dock = DockStyle.Fill;
            this.CompressionMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CompressionMethodComboBox.FormattingEnabled = true;
            this.CompressionMethodComboBox.Location = new Point(103, 61);
            this.CompressionMethodComboBox.Name = "CompressionMethodComboBox";
            this.CompressionMethodComboBox.Size = new Size(238, 23);
            this.CompressionMethodComboBox.TabIndex = 2;
            //
            // MethodLabel
            //
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Dock = DockStyle.Fill;
            this.MethodLabel.Location = new Point(3, 61);
            this.MethodLabel.Margin = new Padding(3);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new Size(94, 23);
            this.MethodLabel.TabIndex = 103;
            this.MethodLabel.Text = "圧縮方法";
            this.MethodLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // CompressionLevelComboBox
            //
            this.CompressionLevelComboBox.Dock = DockStyle.Fill;
            this.CompressionLevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CompressionLevelComboBox.FormattingEnabled = true;
            this.CompressionLevelComboBox.Location = new Point(103, 32);
            this.CompressionLevelComboBox.Name = "CompressionLevelComboBox";
            this.CompressionLevelComboBox.Size = new Size(238, 23);
            this.CompressionLevelComboBox.TabIndex = 1;
            //
            // LevelLabel
            //
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Dock = DockStyle.Fill;
            this.LevelLabel.Location = new Point(3, 32);
            this.LevelLabel.Margin = new Padding(3);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new Size(94, 23);
            this.LevelLabel.TabIndex = 102;
            this.LevelLabel.Text = "圧縮レベル";
            this.LevelLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // FormatLabel
            //
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Dock = DockStyle.Fill;
            this.FormatLabel.Location = new Point(3, 3);
            this.FormatLabel.Margin = new Padding(3);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new Size(94, 23);
            this.FormatLabel.TabIndex = 101;
            this.FormatLabel.Text = "ファイル形式";
            this.FormatLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // FormatComboBox
            //
            this.FormatComboBox.Dock = DockStyle.Fill;
            this.FormatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Location = new Point(103, 3);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new Size(238, 23);
            this.FormatComboBox.TabIndex = 0;
            //
            // ThreadNumeric
            //
            this.ThreadNumeric.Dock = DockStyle.Fill;
            this.ThreadNumeric.Location = new Point(103, 90);
            this.ThreadNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadNumeric.Name = "ThreadNumeric";
            this.ThreadNumeric.Size = new Size(238, 23);
            this.ThreadNumeric.TabIndex = 3;
            this.ThreadNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // EncryptionGroupBox
            //
            this.EncryptionGroupBox.Controls.Add(this.EncryptionWrapperPanel);
            this.EncryptionGroupBox.Dock = DockStyle.Fill;
            this.EncryptionGroupBox.Location = new Point(12, 217);
            this.EncryptionGroupBox.Margin = new Padding(12, 3, 12, 3);
            this.EncryptionGroupBox.Name = "EncryptionGroupBox";
            this.EncryptionGroupBox.Padding = new Padding(8, 3, 8, 8);
            this.EncryptionGroupBox.Size = new Size(360, 174);
            this.EncryptionGroupBox.TabIndex = 5;
            this.EncryptionGroupBox.TabStop = false;
            this.EncryptionGroupBox.Text = "暗号化";
            //
            // EncryptionWrapperPanel
            //
            this.EncryptionWrapperPanel.ColumnCount = 1;
            this.EncryptionWrapperPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.EncryptionWrapperPanel.Controls.Add(this.EncryptionCheckBox, 0, 0);
            this.EncryptionWrapperPanel.Controls.Add(this.EncryptionPanel, 0, 1);
            this.EncryptionWrapperPanel.Dock = DockStyle.Fill;
            this.EncryptionWrapperPanel.Location = new Point(8, 19);
            this.EncryptionWrapperPanel.Name = "EncryptionWrapperPanel";
            this.EncryptionWrapperPanel.RowCount = 2;
            this.EncryptionWrapperPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.EncryptionWrapperPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.EncryptionWrapperPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.EncryptionWrapperPanel.Size = new Size(344, 147);
            this.EncryptionWrapperPanel.TabIndex = 0;
            //
            // EncryptionCheckBox
            //
            this.EncryptionCheckBox.AutoSize = true;
            this.EncryptionCheckBox.Dock = DockStyle.Fill;
            this.EncryptionCheckBox.Location = new Point(3, 3);
            this.EncryptionCheckBox.Name = "EncryptionCheckBox";
            this.EncryptionCheckBox.Size = new Size(338, 23);
            this.EncryptionCheckBox.TabIndex = 0;
            this.EncryptionCheckBox.Text = "パスワードを設定する";
            this.EncryptionCheckBox.UseVisualStyleBackColor = true;
            //
            // EncryptionPanel
            //
            this.EncryptionPanel.ColumnCount = 2;
            this.EncryptionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            this.EncryptionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.EncryptionPanel.Controls.Add(this.EncryptionMethodComboBox, 1, 3);
            this.EncryptionPanel.Controls.Add(this.EncryptionLabel, 0, 3);
            this.EncryptionPanel.Controls.Add(this.ConfirmTextBox, 1, 1);
            this.EncryptionPanel.Controls.Add(this.ConfirmLabel, 0, 1);
            this.EncryptionPanel.Controls.Add(this.PasswordLabel, 0, 0);
            this.EncryptionPanel.Controls.Add(this.PasswordTextBox, 1, 0);
            this.EncryptionPanel.Controls.Add(this.ShowPasswordCheckBox, 1, 2);
            this.EncryptionPanel.Dock = DockStyle.Fill;
            this.EncryptionPanel.Location = new Point(0, 29);
            this.EncryptionPanel.Margin = new Padding(0);
            this.EncryptionPanel.Name = "EncryptionPanel";
            this.EncryptionPanel.RowCount = 4;
            this.EncryptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.EncryptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.EncryptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.EncryptionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.EncryptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.EncryptionPanel.Size = new Size(344, 118);
            this.EncryptionPanel.TabIndex = 1;
            //
            // EncryptionMethodComboBox
            //
            this.EncryptionMethodComboBox.Dock = DockStyle.Fill;
            this.EncryptionMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.EncryptionMethodComboBox.FormattingEnabled = true;
            this.EncryptionMethodComboBox.Location = new Point(103, 90);
            this.EncryptionMethodComboBox.Name = "EncryptionMethodComboBox";
            this.EncryptionMethodComboBox.Size = new Size(238, 23);
            this.EncryptionMethodComboBox.TabIndex = 4;
            //
            // EncryptionLabel
            //
            this.EncryptionLabel.AutoSize = true;
            this.EncryptionLabel.Dock = DockStyle.Fill;
            this.EncryptionLabel.Location = new Point(3, 90);
            this.EncryptionLabel.Margin = new Padding(3);
            this.EncryptionLabel.Name = "EncryptionLabel";
            this.EncryptionLabel.Size = new Size(94, 25);
            this.EncryptionLabel.TabIndex = 107;
            this.EncryptionLabel.Text = "暗号化方法";
            this.EncryptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // ConfirmTextBox
            //
            this.ConfirmTextBox.Dock = DockStyle.Fill;
            this.ConfirmTextBox.Location = new Point(103, 32);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new Size(238, 23);
            this.ConfirmTextBox.TabIndex = 1;
            this.ConfirmTextBox.UseSystemPasswordChar = true;
            //
            // ConfirmLabel
            //
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Dock = DockStyle.Fill;
            this.ConfirmLabel.Location = new Point(3, 32);
            this.ConfirmLabel.Margin = new Padding(3);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.EncryptionPanel.SetRowSpan(this.ConfirmLabel, 2);
            this.ConfirmLabel.Size = new Size(94, 52);
            this.ConfirmLabel.TabIndex = 106;
            this.ConfirmLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // PasswordLabel
            //
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = DockStyle.Fill;
            this.PasswordLabel.Location = new Point(3, 3);
            this.PasswordLabel.Margin = new Padding(3);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new Size(94, 23);
            this.PasswordLabel.TabIndex = 105;
            this.PasswordLabel.Text = "パスワード";
            this.PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // PasswordTextBox
            //
            this.PasswordTextBox.Dock = DockStyle.Fill;
            this.PasswordTextBox.Location = new Point(103, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new Size(238, 23);
            this.PasswordTextBox.TabIndex = 0;
            //
            // ShowPasswordCheckBox
            //
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Dock = DockStyle.Fill;
            this.ShowPasswordCheckBox.Location = new Point(103, 61);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new Size(238, 23);
            this.ShowPasswordCheckBox.TabIndex = 2;
            this.ShowPasswordCheckBox.Text = "パスワードを表示する";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.BackColor = SystemColors.Control;
            this.ButtonsPanel.Controls.Add(this.ExitButton);
            this.ButtonsPanel.Controls.Add(this.ExecuteButton);
            this.ButtonsPanel.Dock = DockStyle.Fill;
            this.ButtonsPanel.Location = new Point(0, 417);
            this.ButtonsPanel.Margin = new Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new Padding(0, 9, 9, 0);
            this.ButtonsPanel.RightToLeft = RightToLeft.Yes;
            this.ButtonsPanel.Size = new Size(384, 54);
            this.ButtonsPanel.TabIndex = 3;
            //
            // ExitButton
            //
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Location = new Point(272, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(100, 30);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // ExecuteButton
            //
            this.ExecuteButton.DialogResult = DialogResult.OK;
            this.ExecuteButton.Location = new Point(141, 12);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new Size(125, 30);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "OK";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            //
            // DestinationGroupBox
            //
            this.DestinationGroupBox.Controls.Add(this.DestinationPanel);
            this.DestinationGroupBox.Dock = DockStyle.Fill;
            this.DestinationGroupBox.Location = new Point(12, 3);
            this.DestinationGroupBox.Margin = new Padding(12, 3, 12, 3);
            this.DestinationGroupBox.Name = "DestinationGroupBox";
            this.DestinationGroupBox.Padding = new Padding(8, 3, 8, 8);
            this.DestinationGroupBox.Size = new Size(360, 58);
            this.DestinationGroupBox.TabIndex = 6;
            this.DestinationGroupBox.TabStop = false;
            this.DestinationGroupBox.Text = "保存先";
            //
            // DestinationPanel
            //
            this.DestinationPanel.ColumnCount = 2;
            this.DestinationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.DestinationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            this.DestinationPanel.Controls.Add(this.DestinationTextBox, 0, 0);
            this.DestinationPanel.Controls.Add(this.DestinationButton, 1, 0);
            this.DestinationPanel.Dock = DockStyle.Fill;
            this.DestinationPanel.Location = new Point(8, 19);
            this.DestinationPanel.Name = "DestinationPanel";
            this.DestinationPanel.RowCount = 1;
            this.DestinationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.DestinationPanel.Size = new Size(344, 31);
            this.DestinationPanel.TabIndex = 0;
            //
            // DestinationTextBox
            //
            this.DestinationTextBox.Dock = DockStyle.Fill;
            this.DestinationTextBox.Location = new Point(3, 4);
            this.DestinationTextBox.Margin = new Padding(3, 4, 3, 3);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new Size(278, 23);
            this.DestinationTextBox.TabIndex = 103;
            //
            // DestinationButton
            //
            this.DestinationButton.Dock = DockStyle.Fill;
            this.DestinationButton.Location = new Point(287, 3);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new Size(54, 25);
            this.DestinationButton.TabIndex = 104;
            this.DestinationButton.Text = "...";
            this.DestinationButton.UseVisualStyleBackColor = true;
            //
            // CompressSettingWindow
            //
            this.AcceptButton = this.ExecuteButton;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.ClientSize = new Size(384, 471);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(128)));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new Size(350, 500);
            this.Name = "CompressSettingWindow";
            this.ShowInTaskbar = false;
            this.Text = "CubeICE 圧縮設定";
            this.RootPanel.ResumeLayout(false);
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            ((ISupportInitialize)(this.ThreadNumeric)).EndInit();
            this.EncryptionGroupBox.ResumeLayout(false);
            this.EncryptionWrapperPanel.ResumeLayout(false);
            this.EncryptionWrapperPanel.PerformLayout();
            this.EncryptionPanel.ResumeLayout(false);
            this.EncryptionPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.DestinationGroupBox.ResumeLayout(false);
            this.DestinationPanel.ResumeLayout(false);
            this.DestinationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private TableLayoutPanel DestinationPanel;
        private TableLayoutPanel GeneralPanel;
        private TableLayoutPanel EncryptionWrapperPanel;
        private TableLayoutPanel EncryptionPanel;
        private FlowLayoutPanel ButtonsPanel;
        private GroupBox DestinationGroupBox;
        private GroupBox GeneralGroupBox;
        private GroupBox EncryptionGroupBox;
        private TextBox DestinationTextBox;
        private ComboBox FormatComboBox;
        private ComboBox CompressionLevelComboBox;
        private ComboBox CompressionMethodComboBox;
        private ComboBox EncryptionMethodComboBox;
        private CheckBox EncryptionCheckBox;
        private CheckBox ShowPasswordCheckBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmTextBox;
        private NumericUpDown ThreadNumeric;
        private Label FormatLabel;
        private Label LevelLabel;
        private Label MethodLabel;
        private Label ThreadLabel;
        private Label EncryptionLabel;
        private Label PasswordLabel;
        private Label ConfirmLabel;
        private Button ExitButton;
        private Button ExecuteButton;
        private Button DestinationButton;
        private ToolTip PathToolTip;
    }
}