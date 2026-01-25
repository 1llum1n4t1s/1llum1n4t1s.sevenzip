using Cube.FileSystem.SevenZip.Ice.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Cube.FileSystem.SevenZip.Ice
{
    partial class ProgressWindow
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ProgressWindow));
            this.RootPanel = new TableLayoutPanel();
            this.RemainLabel = new Label();
            this.CountLabel = new Label();
            this.MainProgressBar = new ProgressBar();
            this.ElapseLabel = new Label();
            this.StatusLabel = new Label();
            this.HeaderPictureBox = new PictureBox();
            this.ButtonsPanel = new FlowLayoutPanel();
            this.SuspendButton = new Button();
            this.ExitButton = new Button();
            this.RootPanel.SuspendLayout();
            ((ISupportInitialize)(this.HeaderPictureBox)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // RootPanel
            //
            this.RootPanel.ColumnCount = 2;
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.RootPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.RootPanel.Controls.Add(this.RemainLabel, 1, 3);
            this.RootPanel.Controls.Add(this.CountLabel, 0, 1);
            this.RootPanel.Controls.Add(this.MainProgressBar, 0, 2);
            this.RootPanel.Controls.Add(this.ElapseLabel, 0, 3);
            this.RootPanel.Controls.Add(this.StatusLabel, 0, 4);
            this.RootPanel.Controls.Add(this.HeaderPictureBox, 0, 0);
            this.RootPanel.Controls.Add(this.ButtonsPanel, 0, 5);
            this.RootPanel.Dock = DockStyle.Fill;
            this.RootPanel.Location = new Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 6;
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.RootPanel.Size = new Size(434, 214);
            this.RootPanel.TabIndex = 0;
            //
            // RemainLabel
            //
            this.RemainLabel.AutoSize = true;
            this.RemainLabel.Dock = DockStyle.Fill;
            this.RemainLabel.Location = new Point(229, 91);
            this.RemainLabel.Margin = new Padding(12, 3, 12, 3);
            this.RemainLabel.Name = "RemainLabel";
            this.RemainLabel.Size = new Size(193, 18);
            this.RemainLabel.TabIndex = 4;
            this.RemainLabel.Text = "残り時間 : 23:55:55";
            this.RemainLabel.TextAlign = ContentAlignment.TopRight;
            this.RemainLabel.Visible = false;
            //
            // CountLabel
            //
            this.CountLabel.AutoSize = true;
            this.RootPanel.SetColumnSpan(this.CountLabel, 2);
            this.CountLabel.Dock = DockStyle.Fill;
            this.CountLabel.Location = new Point(12, 43);
            this.CountLabel.Margin = new Padding(12, 3, 12, 3);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new Size(410, 18);
            this.CountLabel.TabIndex = 1;
            this.CountLabel.Text = "ファイル数 : 669 / 796";
            this.CountLabel.TextAlign = ContentAlignment.BottomRight;
            //
            // MainProgressBar
            //
            this.RootPanel.SetColumnSpan(this.MainProgressBar, 2);
            this.MainProgressBar.Dock = DockStyle.Fill;
            this.MainProgressBar.Location = new Point(14, 67);
            this.MainProgressBar.Margin = new Padding(14, 3, 14, 3);
            this.MainProgressBar.MarqueeAnimationSpeed = 50;
            this.MainProgressBar.Maximum = 1000;
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new Size(406, 18);
            this.MainProgressBar.Step = 1;
            this.MainProgressBar.Style = ProgressBarStyle.Marquee;
            this.MainProgressBar.TabIndex = 2;
            //
            // ElapseLabel
            //
            this.ElapseLabel.AutoSize = true;
            this.ElapseLabel.Dock = DockStyle.Fill;
            this.ElapseLabel.Location = new Point(12, 91);
            this.ElapseLabel.Margin = new Padding(12, 3, 12, 3);
            this.ElapseLabel.Name = "ElapseLabel";
            this.ElapseLabel.Size = new Size(193, 18);
            this.ElapseLabel.TabIndex = 3;
            this.ElapseLabel.Text = "経過時間 : 23:55:55";
            //
            // StatusLabel
            //
            this.StatusLabel.AutoEllipsis = true;
            this.StatusLabel.AutoSize = true;
            this.RootPanel.SetColumnSpan(this.StatusLabel, 2);
            this.StatusLabel.Dock = DockStyle.Fill;
            this.StatusLabel.Location = new Point(12, 115);
            this.StatusLabel.Margin = new Padding(12, 3, 12, 3);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new Size(410, 42);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "ファイル圧縮・解凍処理の準備中です...";
            //
            // HeaderPictureBox
            //
            this.RootPanel.SetColumnSpan(this.HeaderPictureBox, 2);
            this.HeaderPictureBox.Dock = DockStyle.Fill;
            this.HeaderPictureBox.Image = Resources.Hero;
            this.HeaderPictureBox.Location = new Point(0, 0);
            this.HeaderPictureBox.Margin = new Padding(0);
            this.HeaderPictureBox.Name = "HeaderPictureBox";
            this.HeaderPictureBox.Size = new Size(434, 40);
            this.HeaderPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            this.HeaderPictureBox.TabIndex = 5;
            this.HeaderPictureBox.TabStop = false;
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.BackColor = SystemColors.Control;
            this.RootPanel.SetColumnSpan(this.ButtonsPanel, 2);
            this.ButtonsPanel.Controls.Add(this.SuspendButton);
            this.ButtonsPanel.Controls.Add(this.ExitButton);
            this.ButtonsPanel.Dock = DockStyle.Fill;
            this.ButtonsPanel.Location = new Point(0, 160);
            this.ButtonsPanel.Margin = new Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new Padding(0, 9, 0, 0);
            this.ButtonsPanel.Size = new Size(434, 54);
            this.ButtonsPanel.TabIndex = 0;
            //
            // SuspendButton
            //
            this.SuspendButton.Anchor = AnchorStyles.Top;
            this.SuspendButton.Enabled = false;
            this.SuspendButton.Location = new Point(60, 12);
            this.SuspendButton.Margin = new Padding(60, 3, 3, 3);
            this.SuspendButton.Name = "SuspendButton";
            this.SuspendButton.Size = new Size(125, 30);
            this.SuspendButton.TabIndex = 1;
            this.SuspendButton.Text = "一時停止";
            this.SuspendButton.UseVisualStyleBackColor = true;
            //
            // ExitButton
            //
            this.ExitButton.Anchor = AnchorStyles.Top;
            this.ExitButton.DialogResult = DialogResult.Cancel;
            this.ExitButton.Location = new Point(248, 12);
            this.ExitButton.Margin = new Padding(60, 3, 3, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(125, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "キャンセル";
            this.ExitButton.UseVisualStyleBackColor = true;
            //
            // ProgressWindow
            //
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.Window;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new Size(434, 214);
            this.Controls.Add(this.RootPanel);
            this.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(128)));
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgressWindow";
            this.Text = "CubeICE";
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            ((ISupportInitialize)(this.HeaderPictureBox)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RootPanel;
        private FlowLayoutPanel ButtonsPanel;
        private Button ExitButton;
        private Button SuspendButton;
        private ProgressBar MainProgressBar;
        private PictureBox HeaderPictureBox;
        private Label CountLabel;
        private Label ElapseLabel;
        private Label RemainLabel;
        private Label StatusLabel;
    }
}
