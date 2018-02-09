namespace Distance_Camera_Editor
{
    partial class settingsForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.steamPathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.applyBtn = new MetroFramework.Controls.MetroButton();
            this.browseBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "PATH TO STEAM FOLDER:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // steamPathTextBox
            // 
            // 
            // 
            // 
            this.steamPathTextBox.CustomButton.Image = null;
            this.steamPathTextBox.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.steamPathTextBox.CustomButton.Name = "";
            this.steamPathTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.steamPathTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.steamPathTextBox.CustomButton.TabIndex = 1;
            this.steamPathTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.steamPathTextBox.CustomButton.UseSelectable = true;
            this.steamPathTextBox.CustomButton.Visible = false;
            this.steamPathTextBox.Lines = new string[0];
            this.steamPathTextBox.Location = new System.Drawing.Point(23, 86);
            this.steamPathTextBox.MaxLength = 32767;
            this.steamPathTextBox.Name = "steamPathTextBox";
            this.steamPathTextBox.PasswordChar = '\0';
            this.steamPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.steamPathTextBox.SelectedText = "";
            this.steamPathTextBox.SelectionLength = 0;
            this.steamPathTextBox.SelectionStart = 0;
            this.steamPathTextBox.ShortcutsEnabled = true;
            this.steamPathTextBox.Size = new System.Drawing.Size(286, 23);
            this.steamPathTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.steamPathTextBox.TabIndex = 1;
            this.steamPathTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.steamPathTextBox.UseSelectable = true;
            this.steamPathTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.steamPathTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(315, 115);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "APPLY";
            this.applyBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.applyBtn.UseSelectable = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(315, 86);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.browseBtn.TabIndex = 3;
            this.browseBtn.Text = "BROWSE...";
            this.browseBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.browseBtn.UseSelectable = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 153);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.steamPathTextBox);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.Opacity = 0D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SETTINGS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox steamPathTextBox;
        private MetroFramework.Controls.MetroButton applyBtn;
        private MetroFramework.Controls.MetroButton browseBtn;
    }
}