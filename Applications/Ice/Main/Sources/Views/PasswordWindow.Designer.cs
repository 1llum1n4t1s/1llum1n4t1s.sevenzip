using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice
{
    partial class PasswordWindow
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PasswordWindow));
            this.RootPanel = new TableLayoutPanel();
            this.IconPictureBox = new PictureBox();
            this.DescriptionLabel = new Label();
            this.PasswordTextBox = new TextBox();
            this.VisibleCheckBox = new CheckBox();
            this.ButtonsPanel = new FlowLayoutPanel();
            this.ExitButton = new Button();
            this.ExecButton = new Button();
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
            this.RootPanel.Controls.Add(this.PasswordTextBox, 1, 1);
            this.RootPanel.Controls.Add(this.VisibleCheckBox, 1, 2);
            this.RootPanel.Controls.Add(this.ButtonsPanel, 0, 4);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 5;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            this.RootPanel.Size = new Size(384, 171);
            this.RootPanel.TabIndex = 0;
            //
            // IconPictureBox
            //
            this.IconPictureBox.Dock = DockStyle.Fill;
            this.IconPictureBox.Location = new Point(3, 3);
            this.IconPictureBox.Name = "IconPictureBox";
            this.RootPanel.SetRowSpan(this.IconPictureBox, 3);
            this.IconPictureBox.Size = new Size(74, 89);
            this.IconPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            //
            // DescriptionLabel
            //
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = DockStyle.Fill;
            this.DescriptionLabel.Location = new Point(83, 0);
            this.DescriptionLabel.Margin = new Padding(3, 0, 3, 4);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new Size(298, 36);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "パスワードを入力して下さい。";
            this.DescriptionLabel.TextAlign = ContentAlignment.BottomLeft;
            //
            // PasswordTextBox
            //
            this.PasswordTextBox.Dock = DockStyle.Fill;
            this.PasswordTextBox.Location = new Point(83, 43);
            this.PasswordTextBox.Margin = new Padding(3, 3, 20, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new Size(281, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            //
            // VisibleCheckBox
            //
            this.VisibleCheckBox.AutoSize = true;
            this.VisibleCheckBox.Dock = DockStyle.Fill;
            this.VisibleCheckBox.Location = new Point(83, 72);
            this.VisibleCheckBox.Name = "VisibleCheckBox";
            this.VisibleCheckBox.Size = new Size(298, 20);
            this.VisibleCheckBox.TabIndex = 3;
            this.VisibleCheckBox.Text = "パスワードを表示する";
            this.VisibleCheckBox.UseVisualStyleBackColor = true;
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.BackColor = SystemColors.Control;
            this.RootPanel.SetColumnSpan(this.ButtonsPanel, 2);
            this.ButtonsPanel.Controls.Add(this.ExitButton);
            this.ButtonsPanel.Controls.Add(this.ExecButton);
            this.ButtonsPanel.Dock = DockStyle.Fill;
            this.ButtonsPanel.Location = new Point(0, 115);
            this.ButtonsPanel.Margin = new Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new Padding(0, 9, 9, 0);
            this.ButtonsPanel.RightToLeft = RightToLeft.Yes;
            this.ButtonsPanel.Size = new Size(384, 56);
            this.ButtonsPanel.TabIndex = 4;
            //
            // ExitButton
            //
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Location = new Point(272, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(100, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // ExecButton
            //
            this.ExecButton.DialogResult = DialogResult.OK;
            this.ExecButton.Enabled = false;
            this.ExecButton.Location = new Point(141, 12);
            this.ExecButton.Name = "ExecButton";
            this.ExecButton.Size = new Size(125, 30);
            this.ExecButton.TabIndex = 1;
            this.ExecButton.Text = "OK";
            this.ExecButton.UseVisualStyleBackColor = true;
            //
            // PasswordWindow
            //
            this.AcceptButton = this.ExecButton;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(384, 171);
            this.Controls.Add(this.RootPanel);
            this.DoubleBuffered = true;
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(128)));
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordWindow";
            this.ShowInTaskbar = false;
            this.Text = "パスワードの入力 - CubeICE";
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            ((ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private PictureBox IconPictureBox;
        private Label DescriptionLabel;
        private TextBox PasswordTextBox;
        private CheckBox VisibleCheckBox;
        private FlowLayoutPanel ButtonsPanel;
        private Button ExitButton;
        private Button ExecButton;
    }
}