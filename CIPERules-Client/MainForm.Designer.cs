namespace CIPERules_Client
{
    partial class MainForm
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
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.txt_discordWindowTitle = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txt_debugCaptchaResult = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_debugCaptchaDiscordID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.worker_debugCaptcha = new System.ComponentModel.BackgroundWorker();
            this.captchaHandler = new System.ComponentModel.BackgroundWorker();
            this.metroSetTabControl1.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\D4MP3N\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(685, 15);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage1);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 91);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.Size = new System.Drawing.Size(770, 344);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 1;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = null;
            this.metroSetTabControl1.ThemeName = null;
            this.metroSetTabControl1.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.Controls.Add(this.metroSetButton2);
            this.metroSetTabPage1.Controls.Add(this.txt_discordWindowTitle);
            this.metroSetTabPage1.Controls.Add(this.metroSetButton1);
            this.metroSetTabPage1.Controls.Add(this.metroSetPanel1);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(762, 298);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = null;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "Debug";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Location = new System.Drawing.Point(367, 107);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(373, 32);
            this.metroSetButton2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 3;
            this.metroSetButton2.Text = "test action";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            this.metroSetButton2.Click += new System.EventHandler(this.MetroSetButton2_Click);
            // 
            // txt_discordWindowTitle
            // 
            this.txt_discordWindowTitle.AutoCompleteCustomSource = null;
            this.txt_discordWindowTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_discordWindowTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_discordWindowTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_discordWindowTitle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_discordWindowTitle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_discordWindowTitle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_discordWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_discordWindowTitle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_discordWindowTitle.Image = null;
            this.txt_discordWindowTitle.Lines = null;
            this.txt_discordWindowTitle.Location = new System.Drawing.Point(367, 20);
            this.txt_discordWindowTitle.MaxLength = 32767;
            this.txt_discordWindowTitle.Multiline = false;
            this.txt_discordWindowTitle.Name = "txt_discordWindowTitle";
            this.txt_discordWindowTitle.ReadOnly = false;
            this.txt_discordWindowTitle.Size = new System.Drawing.Size(373, 30);
            this.txt_discordWindowTitle.Style = MetroSet_UI.Design.Style.Light;
            this.txt_discordWindowTitle.StyleManager = null;
            this.txt_discordWindowTitle.TabIndex = 2;
            this.txt_discordWindowTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_discordWindowTitle.ThemeAuthor = "Narwin";
            this.txt_discordWindowTitle.ThemeName = "MetroLite";
            this.txt_discordWindowTitle.UseSystemPasswordChar = false;
            this.txt_discordWindowTitle.WatermarkText = "";
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Location = new System.Drawing.Point(367, 56);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(373, 34);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 1;
            this.metroSetButton1.Text = "find discord";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.MetroSetButton1_Click);
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.metroSetLabel2);
            this.metroSetPanel1.Controls.Add(this.txt_debugCaptchaResult);
            this.metroSetPanel1.Controls.Add(this.txt_debugCaptchaDiscordID);
            this.metroSetPanel1.Controls.Add(this.metroSetLabel1);
            this.metroSetPanel1.Location = new System.Drawing.Point(16, 15);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(312, 156);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 0;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(126, 81);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(61, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 3;
            this.metroSetLabel2.Text = "Resultat";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // txt_debugCaptchaResult
            // 
            this.txt_debugCaptchaResult.AutoCompleteCustomSource = null;
            this.txt_debugCaptchaResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_debugCaptchaResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_debugCaptchaResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_debugCaptchaResult.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_debugCaptchaResult.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_debugCaptchaResult.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_debugCaptchaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_debugCaptchaResult.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_debugCaptchaResult.Image = null;
            this.txt_debugCaptchaResult.Lines = null;
            this.txt_debugCaptchaResult.Location = new System.Drawing.Point(89, 107);
            this.txt_debugCaptchaResult.MaxLength = 32767;
            this.txt_debugCaptchaResult.Multiline = false;
            this.txt_debugCaptchaResult.Name = "txt_debugCaptchaResult";
            this.txt_debugCaptchaResult.ReadOnly = true;
            this.txt_debugCaptchaResult.Size = new System.Drawing.Size(135, 30);
            this.txt_debugCaptchaResult.Style = MetroSet_UI.Design.Style.Light;
            this.txt_debugCaptchaResult.StyleManager = null;
            this.txt_debugCaptchaResult.TabIndex = 2;
            this.txt_debugCaptchaResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_debugCaptchaResult.ThemeAuthor = "Narwin";
            this.txt_debugCaptchaResult.ThemeName = "MetroLite";
            this.txt_debugCaptchaResult.UseSystemPasswordChar = false;
            this.txt_debugCaptchaResult.WatermarkText = "";
            // 
            // txt_debugCaptchaDiscordID
            // 
            this.txt_debugCaptchaDiscordID.AutoCompleteCustomSource = null;
            this.txt_debugCaptchaDiscordID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_debugCaptchaDiscordID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_debugCaptchaDiscordID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_debugCaptchaDiscordID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_debugCaptchaDiscordID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_debugCaptchaDiscordID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_debugCaptchaDiscordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_debugCaptchaDiscordID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_debugCaptchaDiscordID.Image = null;
            this.txt_debugCaptchaDiscordID.Lines = null;
            this.txt_debugCaptchaDiscordID.Location = new System.Drawing.Point(15, 41);
            this.txt_debugCaptchaDiscordID.MaxLength = 32767;
            this.txt_debugCaptchaDiscordID.Multiline = false;
            this.txt_debugCaptchaDiscordID.Name = "txt_debugCaptchaDiscordID";
            this.txt_debugCaptchaDiscordID.ReadOnly = false;
            this.txt_debugCaptchaDiscordID.Size = new System.Drawing.Size(283, 30);
            this.txt_debugCaptchaDiscordID.Style = MetroSet_UI.Design.Style.Light;
            this.txt_debugCaptchaDiscordID.StyleManager = null;
            this.txt_debugCaptchaDiscordID.TabIndex = 1;
            this.txt_debugCaptchaDiscordID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_debugCaptchaDiscordID.ThemeAuthor = "Narwin";
            this.txt_debugCaptchaDiscordID.ThemeName = "MetroLite";
            this.txt_debugCaptchaDiscordID.UseSystemPasswordChar = false;
            this.txt_debugCaptchaDiscordID.WatermarkText = "Discord ID";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(89, 15);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(135, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Real Time Captcha";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // worker_debugCaptcha
            // 
            this.worker_debugCaptcha.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_debugCaptcha_DoWork);
            // 
            // captchaHandler
            // 
            this.captchaHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CaptchaHandler_DoWork);
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "MainForm";
            this.StyleManager = this.styleManager1;
            this.Text = "CIPERules Client";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txt_debugCaptchaResult;
        private MetroSet_UI.Controls.MetroSetTextBox txt_debugCaptchaDiscordID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.ComponentModel.BackgroundWorker worker_debugCaptcha;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetTextBox txt_discordWindowTitle;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private System.ComponentModel.BackgroundWorker captchaHandler;
    }
}