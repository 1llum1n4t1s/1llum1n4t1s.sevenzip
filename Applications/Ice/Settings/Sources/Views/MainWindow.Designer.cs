using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice.Settings
{
    partial class MainWindow
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));
            this.RootPanel = new TableLayoutPanel();
            this.SettingTabControl = new TabControl();
            this.GeneralTabPage = new TabPage();
            this.GeneralPanel = new TableLayoutPanel();
            this.ShortcutGroupBox = new GroupBox();
            this.ShortcutPanel = new TableLayoutPanel();
            this.ShortcutCompressCheckBox = new CheckBox();
            this.ShortcutCompressComboBox = new ComboBox();
            this.ShortcutExtractCheckBox = new CheckBox();
            this.ShortcutSettingsCheckBox = new CheckBox();
            this.ContextGroupBox = new GroupBox();
            this.ContextPanel = new TableLayoutPanel();
            this.ContextPresetPanel = new TableLayoutPanel();
            this.ContextExtractPanel = new FlowLayoutPanel();
            this.ContextExtractCheckBox = new CheckBox();
            this.ContextCompressCheckBox = new CheckBox();
            this.ContextCompressPanel = new FlowLayoutPanel();
            this.ContextButtonPanel = new TableLayoutPanel();
            this.ContextResetButton = new Button();
            this.ContextCustomizeButton = new Button();
            this.AssociateGroupBox = new GroupBox();
            this.AssociatePanel = new TableLayoutPanel();
            this.AssociateMenuPanel = new FlowLayoutPanel();
            this.AssociateButtonPanel = new TableLayoutPanel();
            this.AssociateClearButton = new Button();
            this.AssociateAllButton = new Button();
            this.AssociateIconButton = new Button();
            this.CompressTabPage = new TabPage();
            this.CompressPanel = new TableLayoutPanel();
            this.CompressOptionGroupBox = new GroupBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.CompressFilterCheckBox = new CheckBox();
            this.CompressUtf8CheckBox = new CheckBox();
            this.CompressOverwriteCheckBox = new CheckBox();
            this.CompressOpenCheckBox = new CheckBox();
            this.CompressOpenSmartCheckBox = new CheckBox();
            this.CompressLevelLabel = new Label();
            this.CompressLevelComboBox = new ComboBox();
            this.CompressSaveGroupBox = new GroupBox();
            this.CompressSavePanel = new TableLayoutPanel();
            this.CompressSaveRadioButton = new RadioButton();
            this.CompressSaveTextBox = new TextBox();
            this.CompressSaveButton = new Button();
            this.CompressSaveSourceRadioButton = new RadioButton();
            this.CompressSaveQueryRadioButton = new RadioButton();
            this.ExtractTabPage = new TabPage();
            this.ExtractPanel = new TableLayoutPanel();
            this.ExtractOptionGroupBox = new GroupBox();
            this.ExtractOptionPanel = new TableLayoutPanel();
            this.ExtractZoneCheckBox = new CheckBox();
            this.ExtractDeleteCheckBox = new CheckBox();
            this.ExtractOpenSmartCheckBox = new CheckBox();
            this.ExtractOpenCheckBox = new CheckBox();
            this.ExtractFilterCheckBox = new CheckBox();
            this.ExtractCreateSmartCheckBox = new CheckBox();
            this.ExtractCreateCheckBox = new CheckBox();
            this.ExtractBurstCheckBox = new CheckBox();
            this.ExtractSaveGroupBox = new GroupBox();
            this.ExtractSavePanel = new TableLayoutPanel();
            this.ExtractSaveRadioButton = new RadioButton();
            this.ExtractSaveTextBox = new TextBox();
            this.ExtractSaveButton = new Button();
            this.ExtractSaveSourceRadioButton = new RadioButton();
            this.ExtractSaveQueryRadioButton = new RadioButton();
            this.MiscTabPage = new TabPage();
            this.MiscPanel = new TableLayoutPanel();
            this.MiscOptionGroupBox = new GroupBox();
            this.MiscOptionPanel = new TableLayoutPanel();
            this.ToolTipCheckBox = new CheckBox();
            this.ToolTipLabel = new Label();
            this.ToolTipNumeric = new NumericUpDown();
            this.IoHandlerLabel = new Label();
            this.IoHandlerComboBox = new ComboBox();
            this.TempLabel = new Label();
            this.TempTextBox = new TextBox();
            this.TempButton = new Button();
            this.UpdateCheckBox = new CheckBox();
            this.FilterGroupBox = new GroupBox();
            this.FilterPanel = new TableLayoutPanel();
            this.FilterTextBox = new TextBox();
            this.FilterLabel = new Label();
            this.VersionTabPage = new TabPage();
            this.FooterPanel = new TableLayoutPanel();
            this.ApplyButton = new Button();
            this.ExitButton = new Button();
            this.ExecuteButton = new Button();
            this.AssociateHelpButton = new Button();
            this.RootPanel.SuspendLayout();
            this.SettingTabControl.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.ShortcutGroupBox.SuspendLayout();
            this.ShortcutPanel.SuspendLayout();
            this.ContextGroupBox.SuspendLayout();
            this.ContextPanel.SuspendLayout();
            this.ContextPresetPanel.SuspendLayout();
            this.ContextButtonPanel.SuspendLayout();
            this.AssociateGroupBox.SuspendLayout();
            this.AssociatePanel.SuspendLayout();
            this.AssociateButtonPanel.SuspendLayout();
            this.CompressTabPage.SuspendLayout();
            this.CompressPanel.SuspendLayout();
            this.CompressOptionGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CompressSaveGroupBox.SuspendLayout();
            this.CompressSavePanel.SuspendLayout();
            this.ExtractTabPage.SuspendLayout();
            this.ExtractPanel.SuspendLayout();
            this.ExtractOptionGroupBox.SuspendLayout();
            this.ExtractOptionPanel.SuspendLayout();
            this.ExtractSaveGroupBox.SuspendLayout();
            this.ExtractSavePanel.SuspendLayout();
            this.MiscTabPage.SuspendLayout();
            this.MiscPanel.SuspendLayout();
            this.MiscOptionGroupBox.SuspendLayout();
            this.MiscOptionPanel.SuspendLayout();
            ((ISupportInitialize)(this.ToolTipNumeric)).BeginInit();
            this.FilterGroupBox.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 1;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RootPanel.Controls.Add(this.SettingTabControl, 0, 0);
            this.RootPanel.Controls.Add(this.FooterPanel, 0, 1);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 2;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            this.RootPanel.Size = new Size(538, 644);
            this.RootPanel.TabIndex = 0;
            //
            // SettingTabControl
            //
            this.SettingTabControl.Controls.Add(this.GeneralTabPage);
            this.SettingTabControl.Controls.Add(this.CompressTabPage);
            this.SettingTabControl.Controls.Add(this.ExtractTabPage);
            this.SettingTabControl.Controls.Add(this.MiscTabPage);
            this.SettingTabControl.Controls.Add(this.VersionTabPage);
            this.SettingTabControl.Dock = DockStyle.Fill;
            this.SettingTabControl.Location = new Point(9, 9);
            this.SettingTabControl.Margin = new Padding(9);
            this.SettingTabControl.Name = "SettingTabControl";
            this.SettingTabControl.SelectedIndex = 0;
            this.SettingTabControl.Size = new Size(520, 572);
            this.SettingTabControl.TabIndex = 2;
            //
            // GeneralTabPage
            //
            this.GeneralTabPage.AutoScroll = true;
            this.GeneralTabPage.Controls.Add(this.GeneralPanel);
            this.GeneralTabPage.Location = new Point(4, 24);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Size = new Size(512, 544);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "一般";
            this.GeneralTabPage.UseVisualStyleBackColor = true;
            //
            // GeneralPanel
            //
            this.GeneralPanel.ColumnCount = 3;
            this.GeneralPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.GeneralPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.GeneralPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.GeneralPanel.Controls.Add(this.ShortcutGroupBox, 1, 3);
            this.GeneralPanel.Controls.Add(this.ContextGroupBox, 1, 2);
            this.GeneralPanel.Controls.Add(this.AssociateGroupBox, 1, 1);
            this.GeneralPanel.Dock = DockStyle.Top;
            this.GeneralPanel.Location = new Point(0, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.RowCount = 5;
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 286F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            this.GeneralPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.GeneralPanel.Size = new Size(512, 544);
            this.GeneralPanel.TabIndex = 0;
            //
            // ShortcutGroupBox
            //
            this.ShortcutGroupBox.Controls.Add(this.ShortcutPanel);
            this.ShortcutGroupBox.Dock = DockStyle.Fill;
            this.ShortcutGroupBox.Location = new Point(9, 481);
            this.ShortcutGroupBox.Name = "ShortcutGroupBox";
            this.ShortcutGroupBox.Padding = new Padding(9, 3, 9, 6);
            this.ShortcutGroupBox.Size = new Size(494, 54);
            this.ShortcutGroupBox.TabIndex = 3;
            this.ShortcutGroupBox.TabStop = false;
            this.ShortcutGroupBox.Text = "デスクトップに作成するショートカット";
            //
            // ShortcutPanel
            //
            this.ShortcutPanel.ColumnCount = 6;
            this.ShortcutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            this.ShortcutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            this.ShortcutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            this.ShortcutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            this.ShortcutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            this.ShortcutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ShortcutPanel.Controls.Add(this.ShortcutCompressCheckBox, 0, 0);
            this.ShortcutPanel.Controls.Add(this.ShortcutCompressComboBox, 1, 0);
            this.ShortcutPanel.Controls.Add(this.ShortcutExtractCheckBox, 3, 0);
            this.ShortcutPanel.Controls.Add(this.ShortcutSettingsCheckBox, 4, 0);
            this.ShortcutPanel.Dock = DockStyle.Fill;
            this.ShortcutPanel.Location = new Point(9, 19);
            this.ShortcutPanel.Name = "ShortcutPanel";
            this.ShortcutPanel.RowCount = 1;
            this.ShortcutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ShortcutPanel.Size = new Size(476, 29);
            this.ShortcutPanel.TabIndex = 0;
            //
            // ShortcutCompressCheckBox
            //
            this.ShortcutCompressCheckBox.Dock = DockStyle.Fill;
            this.ShortcutCompressCheckBox.Location = new Point(3, 3);
            this.ShortcutCompressCheckBox.Name = "ShortcutCompressCheckBox";
            this.ShortcutCompressCheckBox.Size = new Size(64, 23);
            this.ShortcutCompressCheckBox.TabIndex = 0;
            this.ShortcutCompressCheckBox.Text = "圧縮";
            this.ShortcutCompressCheckBox.UseVisualStyleBackColor = true;
            //
            // ShortcutCompressComboBox
            //
            this.ShortcutCompressComboBox.Dock = DockStyle.Fill;
            this.ShortcutCompressComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ShortcutCompressComboBox.Enabled = false;
            this.ShortcutCompressComboBox.FormattingEnabled = true;
            this.ShortcutCompressComboBox.Location = new Point(73, 3);
            this.ShortcutCompressComboBox.Name = "ShortcutCompressComboBox";
            this.ShortcutCompressComboBox.Size = new Size(114, 23);
            this.ShortcutCompressComboBox.TabIndex = 1;
            //
            // ShortcutExtractCheckBox
            //
            this.ShortcutExtractCheckBox.Dock = DockStyle.Fill;
            this.ShortcutExtractCheckBox.Location = new Point(243, 3);
            this.ShortcutExtractCheckBox.Name = "ShortcutExtractCheckBox";
            this.ShortcutExtractCheckBox.Size = new Size(94, 23);
            this.ShortcutExtractCheckBox.TabIndex = 2;
            this.ShortcutExtractCheckBox.Text = "解凍";
            this.ShortcutExtractCheckBox.UseVisualStyleBackColor = true;
            //
            // ShortcutSettingsCheckBox
            //
            this.ShortcutSettingsCheckBox.Dock = DockStyle.Fill;
            this.ShortcutSettingsCheckBox.Location = new Point(343, 3);
            this.ShortcutSettingsCheckBox.Name = "ShortcutSettingsCheckBox";
            this.ShortcutSettingsCheckBox.Size = new Size(94, 23);
            this.ShortcutSettingsCheckBox.TabIndex = 3;
            this.ShortcutSettingsCheckBox.Text = "設定";
            this.ShortcutSettingsCheckBox.UseVisualStyleBackColor = true;
            //
            // ContextGroupBox
            //
            this.ContextGroupBox.Controls.Add(this.ContextPanel);
            this.ContextGroupBox.Dock = DockStyle.Fill;
            this.ContextGroupBox.Location = new Point(9, 195);
            this.ContextGroupBox.Name = "ContextGroupBox";
            this.ContextGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.ContextGroupBox.Size = new Size(494, 280);
            this.ContextGroupBox.TabIndex = 2;
            this.ContextGroupBox.TabStop = false;
            this.ContextGroupBox.Text = "コンテキストメニュー";
            //
            // ContextPanel
            //
            this.ContextPanel.ColumnCount = 1;
            this.ContextPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ContextPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.ContextPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.ContextPanel.Controls.Add(this.ContextPresetPanel, 0, 0);
            this.ContextPanel.Controls.Add(this.ContextButtonPanel, 0, 1);
            this.ContextPanel.Dock = DockStyle.Fill;
            this.ContextPanel.Location = new Point(9, 19);
            this.ContextPanel.Name = "ContextPanel";
            this.ContextPanel.RowCount = 2;
            this.ContextPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ContextPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            this.ContextPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.ContextPanel.Size = new Size(476, 258);
            this.ContextPanel.TabIndex = 0;
            //
            // ContextPresetPanel
            //
            this.ContextPresetPanel.ColumnCount = 2;
            this.ContextPresetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.ContextPresetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.ContextPresetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.ContextPresetPanel.Controls.Add(this.ContextExtractPanel, 1, 1);
            this.ContextPresetPanel.Controls.Add(this.ContextExtractCheckBox, 1, 0);
            this.ContextPresetPanel.Controls.Add(this.ContextCompressCheckBox, 0, 0);
            this.ContextPresetPanel.Controls.Add(this.ContextCompressPanel, 0, 1);
            this.ContextPresetPanel.Dock = DockStyle.Fill;
            this.ContextPresetPanel.Location = new Point(0, 0);
            this.ContextPresetPanel.Margin = new Padding(0);
            this.ContextPresetPanel.Name = "ContextPresetPanel";
            this.ContextPresetPanel.RowCount = 2;
            this.ContextPresetPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.ContextPresetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ContextPresetPanel.Size = new Size(476, 227);
            this.ContextPresetPanel.TabIndex = 0;
            //
            // ContextExtractPanel
            //
            this.ContextExtractPanel.Dock = DockStyle.Fill;
            this.ContextExtractPanel.Enabled = false;
            this.ContextExtractPanel.FlowDirection = FlowDirection.TopDown;
            this.ContextExtractPanel.Location = new Point(258, 24);
            this.ContextExtractPanel.Margin = new Padding(20, 0, 0, 0);
            this.ContextExtractPanel.Name = "ContextExtractPanel";
            this.ContextExtractPanel.Size = new Size(218, 203);
            this.ContextExtractPanel.TabIndex = 3;
            //
            // ContextExtractCheckBox
            //
            this.ContextExtractCheckBox.AutoSize = true;
            this.ContextExtractCheckBox.Dock = DockStyle.Fill;
            this.ContextExtractCheckBox.Location = new Point(241, 3);
            this.ContextExtractCheckBox.Name = "ContextExtractCheckBox";
            this.ContextExtractCheckBox.Size = new Size(232, 18);
            this.ContextExtractCheckBox.TabIndex = 2;
            this.ContextExtractCheckBox.Text = "解凍";
            this.ContextExtractCheckBox.UseVisualStyleBackColor = true;
            //
            // ContextCompressCheckBox
            //
            this.ContextCompressCheckBox.AutoSize = true;
            this.ContextCompressCheckBox.Dock = DockStyle.Fill;
            this.ContextCompressCheckBox.Location = new Point(3, 3);
            this.ContextCompressCheckBox.Name = "ContextCompressCheckBox";
            this.ContextCompressCheckBox.Size = new Size(232, 18);
            this.ContextCompressCheckBox.TabIndex = 0;
            this.ContextCompressCheckBox.Text = "圧縮";
            this.ContextCompressCheckBox.UseVisualStyleBackColor = true;
            //
            // ContextCompressPanel
            //
            this.ContextCompressPanel.Dock = DockStyle.Fill;
            this.ContextCompressPanel.Enabled = false;
            this.ContextCompressPanel.FlowDirection = FlowDirection.TopDown;
            this.ContextCompressPanel.Location = new Point(20, 24);
            this.ContextCompressPanel.Margin = new Padding(20, 0, 0, 0);
            this.ContextCompressPanel.Name = "ContextCompressPanel";
            this.ContextCompressPanel.Size = new Size(218, 203);
            this.ContextCompressPanel.TabIndex = 1;
            //
            // ContextButtonPanel
            //
            this.ContextButtonPanel.ColumnCount = 3;
            this.ContextButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ContextButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.ContextButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.ContextButtonPanel.Controls.Add(this.ContextResetButton, 2, 0);
            this.ContextButtonPanel.Controls.Add(this.ContextCustomizeButton, 1, 0);
            this.ContextButtonPanel.Dock = DockStyle.Fill;
            this.ContextButtonPanel.Location = new Point(0, 227);
            this.ContextButtonPanel.Margin = new Padding(0);
            this.ContextButtonPanel.Name = "ContextButtonPanel";
            this.ContextButtonPanel.RowCount = 1;
            this.ContextButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ContextButtonPanel.Size = new Size(476, 31);
            this.ContextButtonPanel.TabIndex = 4;
            //
            // ContextResetButton
            //
            this.ContextResetButton.Dock = DockStyle.Fill;
            this.ContextResetButton.Location = new Point(373, 3);
            this.ContextResetButton.Name = "ContextResetButton";
            this.ContextResetButton.Size = new Size(100, 25);
            this.ContextResetButton.TabIndex = 1;
            this.ContextResetButton.Text = "リセット";
            this.ContextResetButton.UseVisualStyleBackColor = true;
            //
            // ContextCustomizeButton
            //
            this.ContextCustomizeButton.Dock = DockStyle.Fill;
            this.ContextCustomizeButton.Location = new Point(267, 3);
            this.ContextCustomizeButton.Name = "ContextCustomizeButton";
            this.ContextCustomizeButton.Size = new Size(100, 25);
            this.ContextCustomizeButton.TabIndex = 0;
            this.ContextCustomizeButton.Text = "カスタマイズ";
            this.ContextCustomizeButton.UseVisualStyleBackColor = true;
            //
            // AssociateGroupBox
            //
            this.AssociateGroupBox.Controls.Add(this.AssociatePanel);
            this.AssociateGroupBox.Dock = DockStyle.Fill;
            this.AssociateGroupBox.Location = new Point(9, 9);
            this.AssociateGroupBox.Name = "AssociateGroupBox";
            this.AssociateGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.AssociateGroupBox.Size = new Size(494, 180);
            this.AssociateGroupBox.TabIndex = 1;
            this.AssociateGroupBox.TabStop = false;
            this.AssociateGroupBox.Text = "ファイルの関連付け";
            //
            // AssociatePanel
            //
            this.AssociatePanel.ColumnCount = 1;
            this.AssociatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.AssociatePanel.Controls.Add(this.AssociateMenuPanel, 0, 0);
            this.AssociatePanel.Controls.Add(this.AssociateButtonPanel, 0, 1);
            this.AssociatePanel.Dock = DockStyle.Fill;
            this.AssociatePanel.Location = new Point(9, 19);
            this.AssociatePanel.Name = "AssociatePanel";
            this.AssociatePanel.RowCount = 2;
            this.AssociatePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.AssociatePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            this.AssociatePanel.Size = new Size(476, 158);
            this.AssociatePanel.TabIndex = 0;
            //
            // AssociateMenuPanel
            //
            this.AssociateMenuPanel.Dock = DockStyle.Fill;
            this.AssociateMenuPanel.Location = new Point(0, 0);
            this.AssociateMenuPanel.Margin = new Padding(0);
            this.AssociateMenuPanel.Name = "AssociateMenuPanel";
            this.AssociateMenuPanel.Size = new Size(476, 127);
            this.AssociateMenuPanel.TabIndex = 0;
            //
            // AssociateButtonPanel
            //
            this.AssociateButtonPanel.ColumnCount = 5;
            this.AssociateButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.AssociateButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.AssociateButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.AssociateButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.AssociateButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.AssociateButtonPanel.Controls.Add(this.AssociateHelpButton, 4, 0);
            this.AssociateButtonPanel.Controls.Add(this.AssociateClearButton, 3, 0);
            this.AssociateButtonPanel.Controls.Add(this.AssociateAllButton, 2, 0);
            this.AssociateButtonPanel.Controls.Add(this.AssociateIconButton, 1, 0);
            this.AssociateButtonPanel.Dock = DockStyle.Fill;
            this.AssociateButtonPanel.Location = new Point(0, 127);
            this.AssociateButtonPanel.Margin = new Padding(0);
            this.AssociateButtonPanel.Name = "AssociateButtonPanel";
            this.AssociateButtonPanel.RowCount = 1;
            this.AssociateButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.AssociateButtonPanel.Size = new Size(476, 31);
            this.AssociateButtonPanel.TabIndex = 1;
            //
            // AssociateClearButton
            //
            this.AssociateClearButton.Dock = DockStyle.Fill;
            this.AssociateClearButton.Location = new Point(267, 3);
            this.AssociateClearButton.Name = "AssociateClearButton";
            this.AssociateClearButton.Size = new Size(100, 25);
            this.AssociateClearButton.TabIndex = 2;
            this.AssociateClearButton.Text = "すべて解除";
            this.AssociateClearButton.UseVisualStyleBackColor = true;
            //
            // AssociateAllButton
            //
            this.AssociateAllButton.Dock = DockStyle.Fill;
            this.AssociateAllButton.Location = new Point(161, 3);
            this.AssociateAllButton.Name = "AssociateAllButton";
            this.AssociateAllButton.Size = new Size(100, 25);
            this.AssociateAllButton.TabIndex = 1;
            this.AssociateAllButton.Text = "すべて選択";
            this.AssociateAllButton.UseVisualStyleBackColor = true;
            //
            // AssociateIconButton
            //
            this.AssociateIconButton.Dock = DockStyle.Fill;
            this.AssociateIconButton.Location = new Point(55, 3);
            this.AssociateIconButton.Name = "AssociateIconButton";
            this.AssociateIconButton.Size = new Size(100, 25);
            this.AssociateIconButton.TabIndex = 0;
            this.AssociateIconButton.Text = "アイコンの変更";
            this.AssociateIconButton.UseVisualStyleBackColor = true;
            //
            // CompressTabPage
            //
            this.CompressTabPage.AutoScroll = true;
            this.CompressTabPage.Controls.Add(this.CompressPanel);
            this.CompressTabPage.Location = new Point(4, 28);
            this.CompressTabPage.Name = "CompressTabPage";
            this.CompressTabPage.Size = new Size(512, 540);
            this.CompressTabPage.TabIndex = 1;
            this.CompressTabPage.Text = "圧縮";
            this.CompressTabPage.UseVisualStyleBackColor = true;
            //
            // CompressPanel
            //
            this.CompressPanel.ColumnCount = 3;
            this.CompressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.CompressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.CompressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.CompressPanel.Controls.Add(this.CompressOptionGroupBox, 1, 2);
            this.CompressPanel.Controls.Add(this.CompressSaveGroupBox, 1, 1);
            this.CompressPanel.Dock = DockStyle.Top;
            this.CompressPanel.Location = new Point(0, 0);
            this.CompressPanel.Name = "CompressPanel";
            this.CompressPanel.RowCount = 4;
            this.CompressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.CompressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            this.CompressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            this.CompressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.CompressPanel.Size = new Size(512, 362);
            this.CompressPanel.TabIndex = 0;
            //
            // CompressOptionGroupBox
            //
            this.CompressOptionGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.CompressOptionGroupBox.Dock = DockStyle.Fill;
            this.CompressOptionGroupBox.Location = new Point(9, 159);
            this.CompressOptionGroupBox.Name = "CompressOptionGroupBox";
            this.CompressOptionGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.CompressOptionGroupBox.Size = new Size(494, 194);
            this.CompressOptionGroupBox.TabIndex = 2;
            this.CompressOptionGroupBox.TabStop = false;
            this.CompressOptionGroupBox.Text = "オプション";
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CompressFilterCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CompressUtf8CheckBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CompressOverwriteCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CompressOpenCheckBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CompressOpenSmartCheckBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CompressLevelLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CompressLevelComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(9, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(476, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // CompressFilterCheckBox
            //
            this.CompressFilterCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CompressFilterCheckBox, 2);
            this.CompressFilterCheckBox.Dock = DockStyle.Fill;
            this.CompressFilterCheckBox.Location = new Point(3, 31);
            this.CompressFilterCheckBox.Name = "CompressFilterCheckBox";
            this.CompressFilterCheckBox.Size = new Size(470, 20);
            this.CompressFilterCheckBox.TabIndex = 2;
            this.CompressFilterCheckBox.Text = "ファイルのフィルタリングを行う（フィルタリング設定は詳細へ）";
            this.CompressFilterCheckBox.UseVisualStyleBackColor = true;
            //
            // CompressUtf8CheckBox
            //
            this.CompressUtf8CheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CompressUtf8CheckBox, 2);
            this.CompressUtf8CheckBox.Dock = DockStyle.Fill;
            this.CompressUtf8CheckBox.Location = new Point(3, 57);
            this.CompressUtf8CheckBox.Name = "CompressUtf8CheckBox";
            this.CompressUtf8CheckBox.Size = new Size(470, 20);
            this.CompressUtf8CheckBox.TabIndex = 3;
            this.CompressUtf8CheckBox.Text = "ファイル名を UTF-8 に変換する";
            this.CompressUtf8CheckBox.UseVisualStyleBackColor = true;
            //
            // CompressOverwriteCheckBox
            //
            this.CompressOverwriteCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CompressOverwriteCheckBox, 2);
            this.CompressOverwriteCheckBox.Dock = DockStyle.Fill;
            this.CompressOverwriteCheckBox.Location = new Point(3, 83);
            this.CompressOverwriteCheckBox.Name = "CompressOverwriteCheckBox";
            this.CompressOverwriteCheckBox.Size = new Size(470, 20);
            this.CompressOverwriteCheckBox.TabIndex = 4;
            this.CompressOverwriteCheckBox.Text = "同名の圧縮ファイルが存在する時にダイアログを表示する";
            this.CompressOverwriteCheckBox.UseVisualStyleBackColor = true;
            //
            // CompressOpenCheckBox
            //
            this.CompressOpenCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CompressOpenCheckBox, 2);
            this.CompressOpenCheckBox.Dock = DockStyle.Fill;
            this.CompressOpenCheckBox.Location = new Point(3, 109);
            this.CompressOpenCheckBox.Name = "CompressOpenCheckBox";
            this.CompressOpenCheckBox.Size = new Size(470, 20);
            this.CompressOpenCheckBox.TabIndex = 5;
            this.CompressOpenCheckBox.Text = "圧縮後に保存先フォルダーを開く";
            this.CompressOpenCheckBox.UseVisualStyleBackColor = true;
            //
            // CompressOpenSmartCheckBox
            //
            this.CompressOpenSmartCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CompressOpenSmartCheckBox, 2);
            this.CompressOpenSmartCheckBox.Dock = DockStyle.Fill;
            this.CompressOpenSmartCheckBox.Enabled = false;
            this.CompressOpenSmartCheckBox.Location = new Point(20, 135);
            this.CompressOpenSmartCheckBox.Margin = new Padding(20, 3, 3, 3);
            this.CompressOpenSmartCheckBox.Name = "CompressOpenSmartCheckBox";
            this.CompressOpenSmartCheckBox.Size = new Size(453, 20);
            this.CompressOpenSmartCheckBox.TabIndex = 6;
            this.CompressOpenSmartCheckBox.Text = "デスクトップの場合は開かない";
            this.CompressOpenSmartCheckBox.UseVisualStyleBackColor = true;
            //
            // CompressLevelLabel
            //
            this.CompressLevelLabel.AutoSize = true;
            this.CompressLevelLabel.Dock = DockStyle.Fill;
            this.CompressLevelLabel.Location = new Point(3, 3);
            this.CompressLevelLabel.Margin = new Padding(3);
            this.CompressLevelLabel.Name = "CompressLevelLabel";
            this.CompressLevelLabel.Size = new Size(74, 22);
            this.CompressLevelLabel.TabIndex = 0;
            this.CompressLevelLabel.Text = "圧縮レベル";
            this.CompressLevelLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // CompressLevelComboBox
            //
            this.CompressLevelComboBox.Dock = DockStyle.Fill;
            this.CompressLevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CompressLevelComboBox.FormattingEnabled = true;
            this.CompressLevelComboBox.Location = new Point(83, 3);
            this.CompressLevelComboBox.Name = "CompressLevelComboBox";
            this.CompressLevelComboBox.Size = new Size(390, 23);
            this.CompressLevelComboBox.TabIndex = 1;
            //
            // CompressSaveGroupBox
            //
            this.CompressSaveGroupBox.Controls.Add(this.CompressSavePanel);
            this.CompressSaveGroupBox.Dock = DockStyle.Fill;
            this.CompressSaveGroupBox.Location = new Point(9, 9);
            this.CompressSaveGroupBox.Name = "CompressSaveGroupBox";
            this.CompressSaveGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.CompressSaveGroupBox.Size = new Size(494, 144);
            this.CompressSaveGroupBox.TabIndex = 1;
            this.CompressSaveGroupBox.TabStop = false;
            this.CompressSaveGroupBox.Text = "保存場所";
            //
            // CompressSavePanel
            //
            this.CompressSavePanel.ColumnCount = 2;
            this.CompressSavePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.CompressSavePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            this.CompressSavePanel.Controls.Add(this.CompressSaveRadioButton, 0, 0);
            this.CompressSavePanel.Controls.Add(this.CompressSaveTextBox, 0, 1);
            this.CompressSavePanel.Controls.Add(this.CompressSaveButton, 1, 1);
            this.CompressSavePanel.Controls.Add(this.CompressSaveSourceRadioButton, 0, 2);
            this.CompressSavePanel.Controls.Add(this.CompressSaveQueryRadioButton, 0, 3);
            this.CompressSavePanel.Dock = DockStyle.Fill;
            this.CompressSavePanel.Location = new Point(9, 19);
            this.CompressSavePanel.Name = "CompressSavePanel";
            this.CompressSavePanel.RowCount = 5;
            this.CompressSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.CompressSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.CompressSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.CompressSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.CompressSavePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.CompressSavePanel.Size = new Size(476, 122);
            this.CompressSavePanel.TabIndex = 0;
            //
            // CompressSaveRadioButton
            //
            this.CompressSaveRadioButton.AutoSize = true;
            this.CompressSaveRadioButton.Checked = true;
            this.CompressSavePanel.SetColumnSpan(this.CompressSaveRadioButton, 2);
            this.CompressSaveRadioButton.Dock = DockStyle.Fill;
            this.CompressSaveRadioButton.Location = new Point(3, 3);
            this.CompressSaveRadioButton.Name = "CompressSaveRadioButton";
            this.CompressSaveRadioButton.Size = new Size(470, 20);
            this.CompressSaveRadioButton.TabIndex = 0;
            this.CompressSaveRadioButton.TabStop = true;
            this.CompressSaveRadioButton.Text = "指定したフォルダー（省略時はデスクトップ）";
            this.CompressSaveRadioButton.UseVisualStyleBackColor = true;
            //
            // CompressSaveTextBox
            //
            this.CompressSaveTextBox.Dock = DockStyle.Fill;
            this.CompressSaveTextBox.Location = new Point(20, 29);
            this.CompressSaveTextBox.Margin = new Padding(20, 3, 3, 3);
            this.CompressSaveTextBox.Name = "CompressSaveTextBox";
            this.CompressSaveTextBox.Size = new Size(393, 23);
            this.CompressSaveTextBox.TabIndex = 1;
            //
            // CompressSaveButton
            //
            this.CompressSaveButton.Dock = DockStyle.Fill;
            this.CompressSaveButton.Location = new Point(419, 28);
            this.CompressSaveButton.Margin = new Padding(3, 2, 3, 1);
            this.CompressSaveButton.Name = "CompressSaveButton";
            this.CompressSaveButton.Size = new Size(54, 25);
            this.CompressSaveButton.TabIndex = 2;
            this.CompressSaveButton.Text = "...";
            this.CompressSaveButton.UseVisualStyleBackColor = true;
            //
            // CompressSaveSourceRadioButton
            //
            this.CompressSaveSourceRadioButton.AutoSize = true;
            this.CompressSavePanel.SetColumnSpan(this.CompressSaveSourceRadioButton, 2);
            this.CompressSaveSourceRadioButton.Dock = DockStyle.Fill;
            this.CompressSaveSourceRadioButton.Location = new Point(3, 57);
            this.CompressSaveSourceRadioButton.Name = "CompressSaveSourceRadioButton";
            this.CompressSaveSourceRadioButton.Size = new Size(470, 20);
            this.CompressSaveSourceRadioButton.TabIndex = 3;
            this.CompressSaveSourceRadioButton.Text = "元のファイルと同じフォルダー";
            this.CompressSaveSourceRadioButton.UseVisualStyleBackColor = true;
            //
            // CompressSaveQueryRadioButton
            //
            this.CompressSaveQueryRadioButton.AutoSize = true;
            this.CompressSavePanel.SetColumnSpan(this.CompressSaveQueryRadioButton, 2);
            this.CompressSaveQueryRadioButton.Dock = DockStyle.Fill;
            this.CompressSaveQueryRadioButton.Location = new Point(3, 83);
            this.CompressSaveQueryRadioButton.Name = "CompressSaveQueryRadioButton";
            this.CompressSaveQueryRadioButton.Size = new Size(470, 20);
            this.CompressSaveQueryRadioButton.TabIndex = 4;
            this.CompressSaveQueryRadioButton.Text = "実行時に指定する";
            this.CompressSaveQueryRadioButton.UseVisualStyleBackColor = true;
            //
            // ExtractTabPage
            //
            this.ExtractTabPage.AutoScroll = true;
            this.ExtractTabPage.Controls.Add(this.ExtractPanel);
            this.ExtractTabPage.Location = new Point(4, 28);
            this.ExtractTabPage.Name = "ExtractTabPage";
            this.ExtractTabPage.Size = new Size(512, 540);
            this.ExtractTabPage.TabIndex = 2;
            this.ExtractTabPage.Text = "解凍";
            this.ExtractTabPage.UseVisualStyleBackColor = true;
            //
            // ExtractPanel
            //
            this.ExtractPanel.ColumnCount = 3;
            this.ExtractPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.ExtractPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ExtractPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.ExtractPanel.Controls.Add(this.ExtractOptionGroupBox, 1, 2);
            this.ExtractPanel.Controls.Add(this.ExtractSaveGroupBox, 1, 1);
            this.ExtractPanel.Dock = DockStyle.Top;
            this.ExtractPanel.Location = new Point(0, 0);
            this.ExtractPanel.Name = "ExtractPanel";
            this.ExtractPanel.RowCount = 4;
            this.ExtractPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.ExtractPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            this.ExtractPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 246F));
            this.ExtractPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.ExtractPanel.Size = new Size(512, 408);
            this.ExtractPanel.TabIndex = 0;
            //
            // ExtractOptionGroupBox
            //
            this.ExtractOptionGroupBox.Controls.Add(this.ExtractOptionPanel);
            this.ExtractOptionGroupBox.Dock = DockStyle.Fill;
            this.ExtractOptionGroupBox.Location = new Point(9, 159);
            this.ExtractOptionGroupBox.Name = "ExtractOptionGroupBox";
            this.ExtractOptionGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.ExtractOptionGroupBox.Size = new Size(494, 240);
            this.ExtractOptionGroupBox.TabIndex = 1;
            this.ExtractOptionGroupBox.TabStop = false;
            this.ExtractOptionGroupBox.Text = "オプション";
            //
            // ExtractOptionPanel
            //
            this.ExtractOptionPanel.ColumnCount = 1;
            this.ExtractOptionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ExtractOptionPanel.Controls.Add(this.ExtractZoneCheckBox, 0, 4);
            this.ExtractOptionPanel.Controls.Add(this.ExtractDeleteCheckBox, 0, 7);
            this.ExtractOptionPanel.Controls.Add(this.ExtractOpenSmartCheckBox, 0, 6);
            this.ExtractOptionPanel.Controls.Add(this.ExtractOpenCheckBox, 0, 5);
            this.ExtractOptionPanel.Controls.Add(this.ExtractFilterCheckBox, 0, 3);
            this.ExtractOptionPanel.Controls.Add(this.ExtractCreateSmartCheckBox, 0, 2);
            this.ExtractOptionPanel.Controls.Add(this.ExtractCreateCheckBox, 0, 1);
            this.ExtractOptionPanel.Controls.Add(this.ExtractBurstCheckBox, 0, 0);
            this.ExtractOptionPanel.Dock = DockStyle.Fill;
            this.ExtractOptionPanel.Location = new Point(9, 19);
            this.ExtractOptionPanel.Name = "ExtractOptionPanel";
            this.ExtractOptionPanel.RowCount = 9;
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractOptionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ExtractOptionPanel.Size = new Size(476, 218);
            this.ExtractOptionPanel.TabIndex = 0;
            //
            // ExtractZoneCheckBox
            //
            this.ExtractZoneCheckBox.AutoSize = true;
            this.ExtractZoneCheckBox.Dock = DockStyle.Fill;
            this.ExtractZoneCheckBox.Location = new Point(3, 107);
            this.ExtractZoneCheckBox.Name = "ExtractZoneCheckBox";
            this.ExtractZoneCheckBox.Size = new Size(470, 20);
            this.ExtractZoneCheckBox.TabIndex = 4;
            this.ExtractZoneCheckBox.Text = "ZoneID を伝搬する (Mark of the Web)";
            this.ExtractZoneCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractDeleteCheckBox
            //
            this.ExtractDeleteCheckBox.AutoSize = true;
            this.ExtractDeleteCheckBox.Dock = DockStyle.Fill;
            this.ExtractDeleteCheckBox.Location = new Point(3, 185);
            this.ExtractDeleteCheckBox.Name = "ExtractDeleteCheckBox";
            this.ExtractDeleteCheckBox.Size = new Size(470, 20);
            this.ExtractDeleteCheckBox.TabIndex = 7;
            this.ExtractDeleteCheckBox.Text = "解凍後に元のファイルを削除する";
            this.ExtractDeleteCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractOpenSmartCheckBox
            //
            this.ExtractOpenSmartCheckBox.AutoSize = true;
            this.ExtractOpenSmartCheckBox.Dock = DockStyle.Fill;
            this.ExtractOpenSmartCheckBox.Enabled = false;
            this.ExtractOpenSmartCheckBox.Location = new Point(20, 159);
            this.ExtractOpenSmartCheckBox.Margin = new Padding(20, 3, 3, 3);
            this.ExtractOpenSmartCheckBox.Name = "ExtractOpenSmartCheckBox";
            this.ExtractOpenSmartCheckBox.Size = new Size(453, 20);
            this.ExtractOpenSmartCheckBox.TabIndex = 6;
            this.ExtractOpenSmartCheckBox.Text = "デスクトップの場合は開かない";
            this.ExtractOpenSmartCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractOpenCheckBox
            //
            this.ExtractOpenCheckBox.AutoSize = true;
            this.ExtractOpenCheckBox.Dock = DockStyle.Fill;
            this.ExtractOpenCheckBox.Location = new Point(3, 133);
            this.ExtractOpenCheckBox.Name = "ExtractOpenCheckBox";
            this.ExtractOpenCheckBox.Size = new Size(470, 20);
            this.ExtractOpenCheckBox.TabIndex = 5;
            this.ExtractOpenCheckBox.Text = "解凍後に保存先フォルダーを開く";
            this.ExtractOpenCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractFilterCheckBox
            //
            this.ExtractFilterCheckBox.AutoSize = true;
            this.ExtractFilterCheckBox.Dock = DockStyle.Fill;
            this.ExtractFilterCheckBox.Location = new Point(3, 81);
            this.ExtractFilterCheckBox.Name = "ExtractFilterCheckBox";
            this.ExtractFilterCheckBox.Size = new Size(470, 20);
            this.ExtractFilterCheckBox.TabIndex = 3;
            this.ExtractFilterCheckBox.Text = "ファイルのフィルタリングを行う（フィルタリング設定は詳細へ）";
            this.ExtractFilterCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractCreateSmartCheckBox
            //
            this.ExtractCreateSmartCheckBox.AutoSize = true;
            this.ExtractCreateSmartCheckBox.Dock = DockStyle.Fill;
            this.ExtractCreateSmartCheckBox.Enabled = false;
            this.ExtractCreateSmartCheckBox.Location = new Point(20, 55);
            this.ExtractCreateSmartCheckBox.Margin = new Padding(20, 3, 3, 3);
            this.ExtractCreateSmartCheckBox.Name = "ExtractCreateSmartCheckBox";
            this.ExtractCreateSmartCheckBox.Size = new Size(453, 20);
            this.ExtractCreateSmartCheckBox.TabIndex = 2;
            this.ExtractCreateSmartCheckBox.Text = "単一フォルダーの場合は作成しない";
            this.ExtractCreateSmartCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractCreateCheckBox
            //
            this.ExtractCreateCheckBox.AutoSize = true;
            this.ExtractCreateCheckBox.Dock = DockStyle.Fill;
            this.ExtractCreateCheckBox.Location = new Point(3, 29);
            this.ExtractCreateCheckBox.Name = "ExtractCreateCheckBox";
            this.ExtractCreateCheckBox.Size = new Size(470, 20);
            this.ExtractCreateCheckBox.TabIndex = 1;
            this.ExtractCreateCheckBox.Text = "フォルダーを自動的に作成する";
            this.ExtractCreateCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractBurstCheckBox
            //
            this.ExtractBurstCheckBox.AutoSize = true;
            this.ExtractBurstCheckBox.Dock = DockStyle.Fill;
            this.ExtractBurstCheckBox.Location = new Point(3, 3);
            this.ExtractBurstCheckBox.Name = "ExtractBurstCheckBox";
            this.ExtractBurstCheckBox.Size = new Size(470, 20);
            this.ExtractBurstCheckBox.TabIndex = 0;
            this.ExtractBurstCheckBox.Text = "複数の圧縮ファイルを同時に解凍する";
            this.ExtractBurstCheckBox.UseVisualStyleBackColor = true;
            //
            // ExtractSaveGroupBox
            //
            this.ExtractSaveGroupBox.Controls.Add(this.ExtractSavePanel);
            this.ExtractSaveGroupBox.Dock = DockStyle.Fill;
            this.ExtractSaveGroupBox.Location = new Point(9, 9);
            this.ExtractSaveGroupBox.Name = "ExtractSaveGroupBox";
            this.ExtractSaveGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.ExtractSaveGroupBox.Size = new Size(494, 144);
            this.ExtractSaveGroupBox.TabIndex = 0;
            this.ExtractSaveGroupBox.TabStop = false;
            this.ExtractSaveGroupBox.Text = "保存場所";
            //
            // ExtractSavePanel
            //
            this.ExtractSavePanel.ColumnCount = 2;
            this.ExtractSavePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ExtractSavePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            this.ExtractSavePanel.Controls.Add(this.ExtractSaveRadioButton, 0, 0);
            this.ExtractSavePanel.Controls.Add(this.ExtractSaveTextBox, 0, 1);
            this.ExtractSavePanel.Controls.Add(this.ExtractSaveButton, 1, 1);
            this.ExtractSavePanel.Controls.Add(this.ExtractSaveSourceRadioButton, 0, 2);
            this.ExtractSavePanel.Controls.Add(this.ExtractSaveQueryRadioButton, 0, 3);
            this.ExtractSavePanel.Dock = DockStyle.Fill;
            this.ExtractSavePanel.Location = new Point(9, 19);
            this.ExtractSavePanel.Name = "ExtractSavePanel";
            this.ExtractSavePanel.RowCount = 5;
            this.ExtractSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.ExtractSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractSavePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.ExtractSavePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.ExtractSavePanel.Size = new Size(476, 122);
            this.ExtractSavePanel.TabIndex = 0;
            //
            // ExtractSaveRadioButton
            //
            this.ExtractSaveRadioButton.AutoSize = true;
            this.ExtractSaveRadioButton.Checked = true;
            this.ExtractSavePanel.SetColumnSpan(this.ExtractSaveRadioButton, 2);
            this.ExtractSaveRadioButton.Dock = DockStyle.Fill;
            this.ExtractSaveRadioButton.Location = new Point(3, 3);
            this.ExtractSaveRadioButton.Name = "ExtractSaveRadioButton";
            this.ExtractSaveRadioButton.Size = new Size(470, 20);
            this.ExtractSaveRadioButton.TabIndex = 0;
            this.ExtractSaveRadioButton.TabStop = true;
            this.ExtractSaveRadioButton.Text = "指定したフォルダー（省略時はデスクトップ）";
            this.ExtractSaveRadioButton.UseVisualStyleBackColor = true;
            //
            // ExtractSaveTextBox
            //
            this.ExtractSaveTextBox.Dock = DockStyle.Fill;
            this.ExtractSaveTextBox.Location = new Point(20, 29);
            this.ExtractSaveTextBox.Margin = new Padding(20, 3, 3, 3);
            this.ExtractSaveTextBox.Name = "ExtractSaveTextBox";
            this.ExtractSaveTextBox.Size = new Size(393, 23);
            this.ExtractSaveTextBox.TabIndex = 1;
            //
            // ExtractSaveButton
            //
            this.ExtractSaveButton.Dock = DockStyle.Fill;
            this.ExtractSaveButton.Location = new Point(419, 28);
            this.ExtractSaveButton.Margin = new Padding(3, 2, 3, 1);
            this.ExtractSaveButton.Name = "ExtractSaveButton";
            this.ExtractSaveButton.Size = new Size(54, 25);
            this.ExtractSaveButton.TabIndex = 2;
            this.ExtractSaveButton.Text = "...";
            this.ExtractSaveButton.UseVisualStyleBackColor = true;
            //
            // ExtractSaveSourceRadioButton
            //
            this.ExtractSaveSourceRadioButton.AutoSize = true;
            this.ExtractSavePanel.SetColumnSpan(this.ExtractSaveSourceRadioButton, 2);
            this.ExtractSaveSourceRadioButton.Dock = DockStyle.Fill;
            this.ExtractSaveSourceRadioButton.Location = new Point(3, 57);
            this.ExtractSaveSourceRadioButton.Name = "ExtractSaveSourceRadioButton";
            this.ExtractSaveSourceRadioButton.Size = new Size(470, 20);
            this.ExtractSaveSourceRadioButton.TabIndex = 3;
            this.ExtractSaveSourceRadioButton.Text = "元のファイルと同じフォルダー";
            this.ExtractSaveSourceRadioButton.UseVisualStyleBackColor = true;
            //
            // ExtractSaveQueryRadioButton
            //
            this.ExtractSaveQueryRadioButton.AutoSize = true;
            this.ExtractSavePanel.SetColumnSpan(this.ExtractSaveQueryRadioButton, 2);
            this.ExtractSaveQueryRadioButton.Dock = DockStyle.Fill;
            this.ExtractSaveQueryRadioButton.Location = new Point(3, 83);
            this.ExtractSaveQueryRadioButton.Name = "ExtractSaveQueryRadioButton";
            this.ExtractSaveQueryRadioButton.Size = new Size(470, 20);
            this.ExtractSaveQueryRadioButton.TabIndex = 4;
            this.ExtractSaveQueryRadioButton.Text = "実行時に指定する";
            this.ExtractSaveQueryRadioButton.UseVisualStyleBackColor = true;
            //
            // MiscTabPage
            //
            this.MiscTabPage.AutoScroll = true;
            this.MiscTabPage.Controls.Add(this.MiscPanel);
            this.MiscTabPage.Location = new Point(4, 28);
            this.MiscTabPage.Name = "MiscTabPage";
            this.MiscTabPage.Size = new Size(512, 540);
            this.MiscTabPage.TabIndex = 3;
            this.MiscTabPage.Text = "詳細";
            this.MiscTabPage.UseVisualStyleBackColor = true;
            //
            // MiscPanel
            //
            this.MiscPanel.ColumnCount = 3;
            this.MiscPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.MiscPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.MiscPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            this.MiscPanel.Controls.Add(this.MiscOptionGroupBox, 1, 2);
            this.MiscPanel.Controls.Add(this.FilterGroupBox, 1, 1);
            this.MiscPanel.Dock = DockStyle.Top;
            this.MiscPanel.Location = new Point(0, 0);
            this.MiscPanel.Name = "MiscPanel";
            this.MiscPanel.RowCount = 4;
            this.MiscPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.MiscPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            this.MiscPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            this.MiscPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            this.MiscPanel.Size = new Size(512, 442);
            this.MiscPanel.TabIndex = 0;
            //
            // MiscOptionGroupBox
            //
            this.MiscOptionGroupBox.Controls.Add(this.MiscOptionPanel);
            this.MiscOptionGroupBox.Dock = DockStyle.Fill;
            this.MiscOptionGroupBox.Location = new Point(9, 259);
            this.MiscOptionGroupBox.Name = "MiscOptionGroupBox";
            this.MiscOptionGroupBox.Padding = new Padding(8, 3, 8, 3);
            this.MiscOptionGroupBox.Size = new Size(494, 174);
            this.MiscOptionGroupBox.TabIndex = 2;
            this.MiscOptionGroupBox.TabStop = false;
            this.MiscOptionGroupBox.Text = "その他";
            //
            // MiscOptionPanel
            //
            this.MiscOptionPanel.ColumnCount = 3;
            this.MiscOptionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            this.MiscOptionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.MiscOptionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            this.MiscOptionPanel.Controls.Add(this.ToolTipCheckBox, 0, 0);
            this.MiscOptionPanel.Controls.Add(this.ToolTipLabel, 0, 1);
            this.MiscOptionPanel.Controls.Add(this.ToolTipNumeric, 1, 1);
            this.MiscOptionPanel.Controls.Add(this.IoHandlerLabel, 0, 2);
            this.MiscOptionPanel.Controls.Add(this.IoHandlerComboBox, 1, 2);
            this.MiscOptionPanel.Controls.Add(this.TempLabel, 0, 3);
            this.MiscOptionPanel.Controls.Add(this.TempTextBox, 1, 3);
            this.MiscOptionPanel.Controls.Add(this.TempButton, 2, 3);
            this.MiscOptionPanel.Controls.Add(this.UpdateCheckBox, 0, 4);
            this.MiscOptionPanel.Dock = DockStyle.Fill;
            this.MiscOptionPanel.Location = new Point(8, 19);
            this.MiscOptionPanel.Name = "MiscOptionPanel";
            this.MiscOptionPanel.RowCount = 6;
            this.MiscOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.MiscOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.MiscOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.MiscOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.MiscOptionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.MiscOptionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.MiscOptionPanel.Size = new Size(478, 152);
            this.MiscOptionPanel.TabIndex = 0;
            //
            // ToolTipCheckBox
            //
            this.ToolTipCheckBox.AutoSize = true;
            this.MiscOptionPanel.SetColumnSpan(this.ToolTipCheckBox, 3);
            this.ToolTipCheckBox.Dock = DockStyle.Fill;
            this.ToolTipCheckBox.Location = new Point(3, 3);
            this.ToolTipCheckBox.Name = "ToolTipCheckBox";
            this.ToolTipCheckBox.Size = new Size(472, 20);
            this.ToolTipCheckBox.TabIndex = 0;
            this.ToolTipCheckBox.Text = "圧縮ファイルのツールチップにファイル一覧を表示する";
            this.ToolTipCheckBox.UseVisualStyleBackColor = true;
            //
            // ToolTipLabel
            //
            this.ToolTipLabel.AutoSize = true;
            this.ToolTipLabel.Dock = DockStyle.Fill;
            this.ToolTipLabel.Location = new Point(20, 29);
            this.ToolTipLabel.Margin = new Padding(20, 3, 3, 3);
            this.ToolTipLabel.Name = "ToolTipLabel";
            this.ToolTipLabel.Size = new Size(97, 22);
            this.ToolTipLabel.TabIndex = 1;
            this.ToolTipLabel.Text = "最大表示件数";
            this.ToolTipLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // ToolTipNumeric
            //
            this.ToolTipNumeric.Dock = DockStyle.Left;
            this.ToolTipNumeric.Enabled = false;
            this.ToolTipNumeric.Location = new Point(123, 29);
            this.ToolTipNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ToolTipNumeric.Name = "ToolTipNumeric";
            this.ToolTipNumeric.Size = new Size(100, 23);
            this.ToolTipNumeric.TabIndex = 2;
            //
            // IoHandlerLabel
            //
            this.IoHandlerLabel.AutoSize = true;
            this.IoHandlerLabel.Dock = DockStyle.Fill;
            this.IoHandlerLabel.Location = new Point(3, 57);
            this.IoHandlerLabel.Margin = new Padding(3);
            this.IoHandlerLabel.Name = "IoHandlerLabel";
            this.IoHandlerLabel.Size = new Size(114, 22);
            this.IoHandlerLabel.TabIndex = 3;
            this.IoHandlerLabel.Text = "ファイル操作方法";
            this.IoHandlerLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // IoHandlerComboBox
            //
            this.IoHandlerComboBox.Dock = DockStyle.Left;
            this.IoHandlerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.IoHandlerComboBox.FormattingEnabled = true;
            this.IoHandlerComboBox.Location = new Point(123, 57);
            this.IoHandlerComboBox.Name = "IoHandlerComboBox";
            this.IoHandlerComboBox.Size = new Size(100, 23);
            this.IoHandlerComboBox.TabIndex = 4;
            //
            // TempLabel
            //
            this.TempLabel.AutoSize = true;
            this.TempLabel.Dock = DockStyle.Fill;
            this.TempLabel.Location = new Point(3, 85);
            this.TempLabel.Margin = new Padding(3);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new Size(114, 22);
            this.TempLabel.TabIndex = 5;
            this.TempLabel.Text = "作業フォルダー";
            this.TempLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // TempTextBox
            //
            this.TempTextBox.Dock = DockStyle.Fill;
            this.TempTextBox.Location = new Point(123, 85);
            this.TempTextBox.Name = "TempTextBox";
            this.TempTextBox.Size = new Size(286, 23);
            this.TempTextBox.TabIndex = 6;
            //
            // TempButton
            //
            this.TempButton.Dock = DockStyle.Fill;
            this.TempButton.Location = new Point(415, 84);
            this.TempButton.Margin = new Padding(3, 2, 3, 1);
            this.TempButton.Name = "TempButton";
            this.TempButton.Size = new Size(60, 25);
            this.TempButton.TabIndex = 7;
            this.TempButton.Text = "...";
            this.TempButton.UseVisualStyleBackColor = true;
            //
            // UpdateCheckBox
            //
            this.UpdateCheckBox.AutoSize = true;
            this.MiscOptionPanel.SetColumnSpan(this.UpdateCheckBox, 3);
            this.UpdateCheckBox.Dock = DockStyle.Fill;
            this.UpdateCheckBox.Location = new Point(3, 113);
            this.UpdateCheckBox.Name = "UpdateCheckBox";
            this.UpdateCheckBox.Size = new Size(472, 20);
            this.UpdateCheckBox.TabIndex = 8;
            this.UpdateCheckBox.Text = "コンピューターの起動時にアップデートを確認する";
            this.UpdateCheckBox.UseVisualStyleBackColor = true;
            //
            // FilterGroupBox
            //
            this.FilterGroupBox.Controls.Add(this.FilterPanel);
            this.FilterGroupBox.Dock = DockStyle.Fill;
            this.FilterGroupBox.Location = new Point(9, 9);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Padding = new Padding(9, 3, 9, 3);
            this.FilterGroupBox.Size = new Size(494, 244);
            this.FilterGroupBox.TabIndex = 1;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "フィルタリング";
            //
            // FilterPanel
            //
            this.FilterPanel.ColumnCount = 1;
            this.FilterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.FilterPanel.Controls.Add(this.FilterTextBox, 0, 1);
            this.FilterPanel.Controls.Add(this.FilterLabel, 0, 0);
            this.FilterPanel.Dock = DockStyle.Fill;
            this.FilterPanel.Location = new Point(9, 19);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.RowCount = 3;
            this.FilterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.FilterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.FilterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.FilterPanel.Size = new Size(476, 222);
            this.FilterPanel.TabIndex = 0;
            //
            // FilterTextBox
            //
            this.FilterTextBox.Dock = DockStyle.Fill;
            this.FilterTextBox.Location = new Point(3, 39);
            this.FilterTextBox.Multiline = true;
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.ScrollBars = ScrollBars.Vertical;
            this.FilterTextBox.Size = new Size(470, 171);
            this.FilterTextBox.TabIndex = 1;
            this.FilterTextBox.WordWrap = false;
            //
            // FilterLabel
            //
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Dock = DockStyle.Fill;
            this.FilterLabel.Location = new Point(3, 3);
            this.FilterLabel.Margin = new Padding(3);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new Size(470, 30);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "圧縮または解凍時にフィルタリング（除外）するファイル名を記述します。\r\n1 行に 1 つずつ記述して下さい。";
            //
            // VersionTabPage
            //
            this.VersionTabPage.Location = new Point(4, 28);
            this.VersionTabPage.Name = "VersionTabPage";
            this.VersionTabPage.Size = new Size(512, 540);
            this.VersionTabPage.TabIndex = 4;
            this.VersionTabPage.Text = "バージョン情報";
            this.VersionTabPage.UseVisualStyleBackColor = true;
            //
            // FooterPanel
            //
            this.FooterPanel.ColumnCount = 5;
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            this.FooterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            this.FooterPanel.Controls.Add(this.ApplyButton, 3, 1);
            this.FooterPanel.Controls.Add(this.ExitButton, 2, 1);
            this.FooterPanel.Controls.Add(this.ExecuteButton, 1, 1);
            this.FooterPanel.Dock = DockStyle.Fill;
            this.FooterPanel.Location = new Point(0, 590);
            this.FooterPanel.Margin = new Padding(0);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.RowCount = 3;
            this.FooterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.FooterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.FooterPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            this.FooterPanel.Size = new Size(538, 54);
            this.FooterPanel.TabIndex = 3;
            //
            // ApplyButton
            //
            this.ApplyButton.DialogResult = DialogResult.OK;
            this.ApplyButton.Dock = DockStyle.Fill;
            this.ApplyButton.Location = new Point(426, 12);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new Size(100, 30);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "適用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            //
            // ExitButton
            //
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Dock = DockStyle.Fill;
            this.ExitButton.Location = new Point(320, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(100, 30);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // ExecuteButton
            //
            this.ExecuteButton.DialogResult = DialogResult.OK;
            this.ExecuteButton.Dock = DockStyle.Fill;
            this.ExecuteButton.Location = new Point(189, 12);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new Size(125, 30);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "OK";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            //
            // AssociateHelpButton
            //
            this.AssociateHelpButton.Dock = DockStyle.Fill;
            this.AssociateHelpButton.Location = new Point(373, 3);
            this.AssociateHelpButton.Name = "AssociateHelpButton";
            this.AssociateHelpButton.Size = new Size(100, 25);
            this.AssociateHelpButton.TabIndex = 3;
            this.AssociateHelpButton.Text = "ヘルプ";
            this.AssociateHelpButton.UseVisualStyleBackColor = true;
            //
            // MainWindow
            //
            this.AutoScaleMode = AutoScaleMode.None;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(538, 644);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(128)));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new Size(560, 700);
            this.MinimumSize = new Size(560, 250);
            this.Name = "MainWindow";
            this.Text = "CubeICE 設定";
            this.RootPanel.ResumeLayout(false);
            this.SettingTabControl.ResumeLayout(false);
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.ShortcutGroupBox.ResumeLayout(false);
            this.ShortcutPanel.ResumeLayout(false);
            this.ContextGroupBox.ResumeLayout(false);
            this.ContextPanel.ResumeLayout(false);
            this.ContextPresetPanel.ResumeLayout(false);
            this.ContextPresetPanel.PerformLayout();
            this.ContextButtonPanel.ResumeLayout(false);
            this.AssociateGroupBox.ResumeLayout(false);
            this.AssociatePanel.ResumeLayout(false);
            this.AssociateButtonPanel.ResumeLayout(false);
            this.CompressTabPage.ResumeLayout(false);
            this.CompressPanel.ResumeLayout(false);
            this.CompressOptionGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CompressSaveGroupBox.ResumeLayout(false);
            this.CompressSavePanel.ResumeLayout(false);
            this.CompressSavePanel.PerformLayout();
            this.ExtractTabPage.ResumeLayout(false);
            this.ExtractPanel.ResumeLayout(false);
            this.ExtractOptionGroupBox.ResumeLayout(false);
            this.ExtractOptionPanel.ResumeLayout(false);
            this.ExtractOptionPanel.PerformLayout();
            this.ExtractSaveGroupBox.ResumeLayout(false);
            this.ExtractSavePanel.ResumeLayout(false);
            this.ExtractSavePanel.PerformLayout();
            this.MiscTabPage.ResumeLayout(false);
            this.MiscPanel.ResumeLayout(false);
            this.MiscOptionGroupBox.ResumeLayout(false);
            this.MiscOptionPanel.ResumeLayout(false);
            this.MiscOptionPanel.PerformLayout();
            ((ISupportInitialize)(this.ToolTipNumeric)).EndInit();
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private TabControl SettingTabControl;
        private TabPage GeneralTabPage;
        private TabPage CompressTabPage;
        private TabPage ExtractTabPage;
        private TabPage MiscTabPage;
        private TabPage VersionTabPage;
        private TableLayoutPanel GeneralPanel;
        private GroupBox ContextGroupBox;
        private TableLayoutPanel ContextPanel;
        private TableLayoutPanel ContextPresetPanel;
        private FlowLayoutPanel ContextExtractPanel;
        private CheckBox ContextExtractCheckBox;
        private CheckBox ContextCompressCheckBox;
        private FlowLayoutPanel ContextCompressPanel;
        private GroupBox AssociateGroupBox;
        private TableLayoutPanel AssociatePanel;
        private FlowLayoutPanel AssociateMenuPanel;
        private GroupBox ShortcutGroupBox;
        private TableLayoutPanel CompressPanel;
        private GroupBox CompressSaveGroupBox;
        private TableLayoutPanel CompressSavePanel;
        private RadioButton CompressSaveRadioButton;
        private TextBox CompressSaveTextBox;
        private Button CompressSaveButton;
        private RadioButton CompressSaveSourceRadioButton;
        private RadioButton CompressSaveQueryRadioButton;
        private GroupBox CompressOptionGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox CompressFilterCheckBox;
        private CheckBox CompressUtf8CheckBox;
        private CheckBox CompressOverwriteCheckBox;
        private CheckBox CompressOpenCheckBox;
        private CheckBox CompressOpenSmartCheckBox;
        private Label CompressLevelLabel;
        private ComboBox CompressLevelComboBox;
        private TableLayoutPanel ExtractPanel;
        private GroupBox ExtractSaveGroupBox;
        private GroupBox ExtractOptionGroupBox;
        private TableLayoutPanel ExtractSavePanel;
        private RadioButton ExtractSaveRadioButton;
        private TextBox ExtractSaveTextBox;
        private Button ExtractSaveButton;
        private RadioButton ExtractSaveSourceRadioButton;
        private RadioButton ExtractSaveQueryRadioButton;
        private TableLayoutPanel ExtractOptionPanel;
        private CheckBox ExtractDeleteCheckBox;
        private CheckBox ExtractOpenSmartCheckBox;
        private CheckBox ExtractOpenCheckBox;
        private CheckBox ExtractFilterCheckBox;
        private CheckBox ExtractCreateSmartCheckBox;
        private CheckBox ExtractCreateCheckBox;
        private CheckBox ExtractBurstCheckBox;
        private TableLayoutPanel MiscPanel;
        private GroupBox FilterGroupBox;
        private GroupBox MiscOptionGroupBox;
        private TableLayoutPanel MiscOptionPanel;
        private CheckBox ToolTipCheckBox;
        private Label ToolTipLabel;
        private NumericUpDown ToolTipNumeric;
        private Label IoHandlerLabel;
        private ComboBox IoHandlerComboBox;
        private Label TempLabel;
        private TextBox TempTextBox;
        private Button TempButton;
        private CheckBox UpdateCheckBox;
        private TableLayoutPanel FilterPanel;
        private Label FilterLabel;
        private TextBox FilterTextBox;
        private TableLayoutPanel FooterPanel;
        private Button ApplyButton;
        private Button ExitButton;
        private Button ExecuteButton;
        private TableLayoutPanel AssociateButtonPanel;
        private Button AssociateClearButton;
        private Button AssociateAllButton;
        private Button AssociateIconButton;
        private TableLayoutPanel ContextButtonPanel;
        private Button ContextResetButton;
        private Button ContextCustomizeButton;
        private TableLayoutPanel ShortcutPanel;
        private CheckBox ShortcutCompressCheckBox;
        private ComboBox ShortcutCompressComboBox;
        private CheckBox ShortcutExtractCheckBox;
        private CheckBox ShortcutSettingsCheckBox;
        private CheckBox ExtractZoneCheckBox;
        private Button AssociateHelpButton;
    }
}

