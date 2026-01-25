using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice
{
    partial class PasswordSettingWindow
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PasswordSettingWindow));
            this.RootPanel = new TableLayoutPanel();
            this.ButtonsPanel = new FlowLayoutPanel();
            this.ExitButton = new Button();
            this.ExecuteButton = new Button();
            this.ShowPasswordCheckBox = new CheckBox();
            this.ConfirmTextBox = new TextBox();
            this.PasswordTextBox = new TextBox();
            this.DescriptionLabel = new Label();
            this.IconPictureBox = new PictureBox();
            this.RootPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 2;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RootPanel.Controls.Add(this.ButtonsPanel, 0, 5);
            this.RootPanel.Controls.Add(this.ShowPasswordCheckBox, 1, 3);
            this.RootPanel.Controls.Add(this.ConfirmTextBox, 1, 2);
            this.RootPanel.Controls.Add(this.PasswordTextBox, 1, 1);
            this.RootPanel.Controls.Add(this.DescriptionLabel, 1, 0);
            this.RootPanel.Controls.Add(this.IconPictureBox, 0, 0);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Margin = new Padding(3, 4, 3, 4);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 6;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            this.RootPanel.Size = new Size(384, 201);
            this.RootPanel.TabIndex = 0;
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.BackColor = SystemColors.Control;
            this.RootPanel.SetColumnSpan(this.ButtonsPanel, 2);
            this.ButtonsPanel.Controls.Add(this.ExitButton);
            this.ButtonsPanel.Controls.Add(this.ExecuteButton);
            this.ButtonsPanel.Dock = DockStyle.Fill;
            this.ButtonsPanel.Location = new Point(0, 145);
            this.ButtonsPanel.Margin = new Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new Padding(0, 9, 9, 0);
            this.ButtonsPanel.RightToLeft = RightToLeft.Yes;
            this.ButtonsPanel.Size = new Size(384, 56);
            this.ButtonsPanel.TabIndex = 6;
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
            this.ExecuteButton.Enabled = false;
            this.ExecuteButton.Location = new Point(141, 12);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new Size(125, 30);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "OK";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            //
            // ShowPasswordCheckBox
            //
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Dock = DockStyle.Fill;
            this.ShowPasswordCheckBox.Location = new Point(83, 101);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new Size(298, 20);
            this.ShowPasswordCheckBox.TabIndex = 4;
            this.ShowPasswordCheckBox.Text = "パスワードを表示する";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            //
            // ConfirmTextBox
            //
            this.ConfirmTextBox.Dock = DockStyle.Fill;
            this.ConfirmTextBox.Location = new Point(83, 73);
            this.ConfirmTextBox.Margin = new Padding(3, 4, 23, 4);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new Size(278, 23);
            this.ConfirmTextBox.TabIndex = 3;
            this.ConfirmTextBox.UseSystemPasswordChar = true;
            //
            // PasswordTextBox
            //
            this.PasswordTextBox.Dock = DockStyle.Fill;
            this.PasswordTextBox.Location = new Point(83, 44);
            this.PasswordTextBox.Margin = new Padding(3, 4, 23, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new Size(278, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            //
            // DescriptionLabel
            //
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = DockStyle.Fill;
            this.DescriptionLabel.Location = new Point(83, 0);
            this.DescriptionLabel.Margin = new Padding(3, 0, 3, 5);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new Size(298, 35);
            this.DescriptionLabel.TabIndex = 100;
            this.DescriptionLabel.Text = "パスワードを設定して下さい。";
            this.DescriptionLabel.TextAlign = ContentAlignment.BottomLeft;
            //
            // IconPictureBox
            //
            this.IconPictureBox.Dock = DockStyle.Fill;
            this.IconPictureBox.Location = new Point(3, 4);
            this.IconPictureBox.Margin = new Padding(3, 4, 3, 30);
            this.IconPictureBox.Name = "IconPictureBox";
            this.RootPanel.SetRowSpan(this.IconPictureBox, 4);
            this.IconPictureBox.Size = new Size(74, 90);
            this.IconPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            this.IconPictureBox.TabIndex = 1;
            this.IconPictureBox.TabStop = false;
            //
            // PasswordSettingWindow
            //
            this.AcceptButton = this.ExecuteButton;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(384, 201);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(128)));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordSettingWindow";
            this.ShowInTaskbar = false;
            this.Text = "パスワードの設定 - CubeICE";
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private PictureBox IconPictureBox;
        private Label DescriptionLabel;
        private TextBox PasswordTextBox;
        private TextBox ConfirmTextBox;
        private CheckBox ShowPasswordCheckBox;
        private FlowLayoutPanel ButtonsPanel;
        private Button ExitButton;
        private Button ExecuteButton;
    }
}