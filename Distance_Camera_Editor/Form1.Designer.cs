namespace Distance_Camera_Editor
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.modifyBtn = new MetroFramework.Controls.MetroButton();
            this.newValueComboBox = new MetroFramework.Controls.MetroComboBox();
            this.oldValueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newValueLabel = new MetroFramework.Controls.MetroLabel();
            this.oldValueLabel = new MetroFramework.Controls.MetroLabel();
            this.successPanel = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.infoToolTip = new MetroFramework.Components.MetroToolTip();
            this.settringsToolTip = new MetroFramework.Components.MetroToolTip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorPic = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.infoBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.successPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.errorPic);
            this.mainPanel.Controls.Add(this.modifyBtn);
            this.mainPanel.Controls.Add(this.newValueComboBox);
            this.mainPanel.Controls.Add(this.oldValueTextBox);
            this.mainPanel.Controls.Add(this.newValueLabel);
            this.mainPanel.Controls.Add(this.oldValueLabel);
            this.mainPanel.Location = new System.Drawing.Point(23, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(371, 153);
            this.mainPanel.TabIndex = 0;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(77, 111);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(223, 29);
            this.modifyBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.modifyBtn.TabIndex = 5;
            this.modifyBtn.Text = "MODIFY";
            this.modifyBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.modifyBtn.UseSelectable = true;
            this.modifyBtn.Click += new System.EventHandler(this.modufyBtn_Click);
            // 
            // newValueComboBox
            // 
            this.newValueComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.newValueComboBox.DisplayMember = "1134";
            this.newValueComboBox.FormattingEnabled = true;
            this.newValueComboBox.ItemHeight = 23;
            this.newValueComboBox.Items.AddRange(new object[] {
            "1134",
            "1180",
            "1250",
            "1300",
            "1350",
            "1400",
            "1550"});
            this.newValueComboBox.Location = new System.Drawing.Point(190, 62);
            this.newValueComboBox.Name = "newValueComboBox";
            this.newValueComboBox.Size = new System.Drawing.Size(110, 29);
            this.newValueComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.newValueComboBox.TabIndex = 3;
            this.newValueComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newValueComboBox.UseSelectable = true;
            // 
            // oldValueTextBox
            // 
            // 
            // 
            // 
            this.oldValueTextBox.CustomButton.Image = null;
            this.oldValueTextBox.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.oldValueTextBox.CustomButton.Name = "";
            this.oldValueTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.oldValueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldValueTextBox.CustomButton.TabIndex = 1;
            this.oldValueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldValueTextBox.CustomButton.UseSelectable = true;
            this.oldValueTextBox.CustomButton.Visible = false;
            this.oldValueTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.oldValueTextBox.Lines = new string[] {
        "1134"};
            this.oldValueTextBox.Location = new System.Drawing.Point(190, 27);
            this.oldValueTextBox.MaxLength = 4;
            this.oldValueTextBox.Name = "oldValueTextBox";
            this.oldValueTextBox.PasswordChar = '\0';
            this.oldValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldValueTextBox.SelectedText = "";
            this.oldValueTextBox.SelectionLength = 0;
            this.oldValueTextBox.SelectionStart = 0;
            this.oldValueTextBox.ShortcutsEnabled = true;
            this.oldValueTextBox.Size = new System.Drawing.Size(110, 29);
            this.oldValueTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldValueTextBox.TabIndex = 2;
            this.oldValueTextBox.Text = "1134";
            this.oldValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldValueTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.oldValueTextBox.UseSelectable = true;
            this.oldValueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldValueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.oldValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oldValueTextBox_KeyDown);
            this.oldValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldValueTextBox_KeyPress);
            // 
            // newValueLabel
            // 
            this.newValueLabel.AutoSize = true;
            this.newValueLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.newValueLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.newValueLabel.Location = new System.Drawing.Point(73, 62);
            this.newValueLabel.Name = "newValueLabel";
            this.newValueLabel.Size = new System.Drawing.Size(111, 25);
            this.newValueLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.newValueLabel.TabIndex = 1;
            this.newValueLabel.Text = "NEW VALUE:";
            this.newValueLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // oldValueLabel
            // 
            this.oldValueLabel.AutoSize = true;
            this.oldValueLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.oldValueLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.oldValueLabel.Location = new System.Drawing.Point(77, 27);
            this.oldValueLabel.Name = "oldValueLabel";
            this.oldValueLabel.Size = new System.Drawing.Size(107, 25);
            this.oldValueLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldValueLabel.TabIndex = 0;
            this.oldValueLabel.Text = "OLD VALUE:";
            this.oldValueLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // successPanel
            // 
            this.successPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.successPanel.Controls.Add(this.pictureBox1);
            this.successPanel.Controls.Add(this.metroLabel1);
            this.successPanel.Controls.Add(this.backButton);
            this.successPanel.Controls.Add(this.metroButton1);
            this.successPanel.Location = new System.Drawing.Point(23, 63);
            this.successPanel.Name = "successPanel";
            this.successPanel.Size = new System.Drawing.Size(368, 153);
            this.successPanel.TabIndex = 6;
            this.successPanel.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.metroLabel1.Location = new System.Drawing.Point(144, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "SUCCESS";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(101, 114);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(178, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "LAUNCH DOTA 2 AND CLOSE";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // infoToolTip
            // 
            this.infoToolTip.AutomaticDelay = 100;
            this.infoToolTip.AutoPopDelay = 1000;
            this.infoToolTip.InitialDelay = 100;
            this.infoToolTip.ReshowDelay = 20;
            this.infoToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.infoToolTip.StyleManager = null;
            this.infoToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // settringsToolTip
            // 
            this.settringsToolTip.AutomaticDelay = 100;
            this.settringsToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.settringsToolTip.StyleManager = null;
            this.settringsToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // errorPic
            // 
            this.errorPic.Image = global::Distance_Camera_Editor.Properties.Resources.icons8_delete_50;
            this.errorPic.Location = new System.Drawing.Point(300, 31);
            this.errorPic.Name = "errorPic";
            this.errorPic.Size = new System.Drawing.Size(20, 20);
            this.errorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPic.TabIndex = 10;
            this.errorPic.TabStop = false;
            this.errorPic.Visible = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = global::Distance_Camera_Editor.Properties.Resources.icons8_settings_50;
            this.settingsBtn.Location = new System.Drawing.Point(364, 215);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(30, 30);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.TabStop = false;
            this.settringsToolTip.SetToolTip(this.settingsBtn, "Settings");
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Image = global::Distance_Camera_Editor.Properties.Resources.icons8_info_50;
            this.infoBtn.Location = new System.Drawing.Point(23, 215);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(30, 30);
            this.infoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoBtn.TabIndex = 0;
            this.infoBtn.TabStop = false;
            this.infoToolTip.SetToolTip(this.infoBtn, "Info");
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Distance_Camera_Editor.Properties.Resources.icons8_ok_50;
            this.pictureBox1.Location = new System.Drawing.Point(161, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Distance_Camera_Editor.Properties.Resources.icons8_left_50;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.backButton.Location = new System.Drawing.Point(98, 114);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 29);
            this.backButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.backButton.TabIndex = 6;
            this.backButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusTextBox.Location = new System.Drawing.Point(89, 222);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(243, 14);
            this.statusTextBox.TabIndex = 7;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusTextBox.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 257);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.successPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Opacity = 0D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "DISTANCE CAMERA EDITOR";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.successPanel.ResumeLayout(false);
            this.successPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox infoBtn;
        private System.Windows.Forms.PictureBox settingsBtn;
        private MetroFramework.Controls.MetroComboBox newValueComboBox;
        private MetroFramework.Controls.MetroTextBox oldValueTextBox;
        private MetroFramework.Controls.MetroLabel newValueLabel;
        private MetroFramework.Controls.MetroLabel oldValueLabel;
        private MetroFramework.Controls.MetroButton modifyBtn;
        private System.Windows.Forms.Panel successPanel;
        private MetroFramework.Controls.MetroButton backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroToolTip infoToolTip;
        private MetroFramework.Components.MetroToolTip settringsToolTip;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox errorPic;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

