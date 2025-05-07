    namespace StudentInformationSystemfinal
{
    partial class LOGINForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINForm));
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.LOGIN = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbeUserTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ALREADYHAVEANACCOUNT = new DevExpress.XtraEditors.SimpleButton();
            this.CREATEANACCOUNT = new DevExpress.XtraEditors.SimpleButton();
            this.FORGOTPASSWORD = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(570, 111);
            this.teUserName.Margin = new System.Windows.Forms.Padding(2);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AdvancedModeOptions.Label = "UserName";
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("teUserName.Properties.ContextImageOptions.Image")));
            this.teUserName.Properties.ContextImageOptions.ImageUri.Uri = "outlook%20inspired/miss";
            this.teUserName.Size = new System.Drawing.Size(285, 38);
            this.teUserName.TabIndex = 1;
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "";
            this.tePassword.Location = new System.Drawing.Point(570, 171);
            this.tePassword.Margin = new System.Windows.Forms.Padding(2);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AdvancedModeOptions.Label = "Password";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tePassword.Properties.ContextImageOptions.Image")));
            this.tePassword.Properties.ContextImageOptions.ImageUri.Uri = "business%20objects/bo_security_permission";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(285, 40);
            this.tePassword.TabIndex = 2;
            this.tePassword.EditValueChanged += new System.EventHandler(this.tePassword_EditValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(992, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 494);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(992, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(992, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
            // 
            // LOGIN
            // 
            this.LOGIN.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Appearance.Options.UseFont = true;
            this.LOGIN.Location = new System.Drawing.Point(615, 291);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(176, 45);
            this.LOGIN.TabIndex = 12;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbeUserTypes);
            this.panelControl1.Controls.Add(this.ALREADYHAVEANACCOUNT);
            this.panelControl1.Controls.Add(this.CREATEANACCOUNT);
            this.panelControl1.Controls.Add(this.FORGOTPASSWORD);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.LOGIN);
            this.panelControl1.Controls.Add(this.tePassword);
            this.panelControl1.Controls.Add(this.teUserName);
            this.panelControl1.Location = new System.Drawing.Point(-2, -10);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1203, 509);
            this.panelControl1.TabIndex = 17;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelControl1.Location = new System.Drawing.Point(941, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 32);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "X";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // cbeUserTypes
            // 
            this.cbeUserTypes.Location = new System.Drawing.Point(570, 242);
            this.cbeUserTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cbeUserTypes.MenuManager = this.barManager1;
            this.cbeUserTypes.Name = "cbeUserTypes";
            this.cbeUserTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeUserTypes.Properties.Items.AddRange(new object[] {
            "Administrator",
            "Nurse"});
            this.cbeUserTypes.Size = new System.Drawing.Size(285, 34);
            this.cbeUserTypes.TabIndex = 18;
            // 
            // ALREADYHAVEANACCOUNT
            // 
            this.ALREADYHAVEANACCOUNT.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseBackColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseBorderColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseForeColor = true;
            this.ALREADYHAVEANACCOUNT.Location = new System.Drawing.Point(552, 397);
            this.ALREADYHAVEANACCOUNT.Margin = new System.Windows.Forms.Padding(2);
            this.ALREADYHAVEANACCOUNT.Name = "ALREADYHAVEANACCOUNT";
            this.ALREADYHAVEANACCOUNT.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ALREADYHAVEANACCOUNT.Size = new System.Drawing.Size(157, 25);
            this.ALREADYHAVEANACCOUNT.TabIndex = 17;
            this.ALREADYHAVEANACCOUNT.Text = "Already Have an Account?";
            // 
            // CREATEANACCOUNT
            // 
            this.CREATEANACCOUNT.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CREATEANACCOUNT.AppearancePressed.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.CREATEANACCOUNT.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.CREATEANACCOUNT.AppearancePressed.Options.UseBackColor = true;
            this.CREATEANACCOUNT.AppearancePressed.Options.UseBorderColor = true;
            this.CREATEANACCOUNT.AppearancePressed.Options.UseForeColor = true;
            this.CREATEANACCOUNT.Location = new System.Drawing.Point(698, 397);
            this.CREATEANACCOUNT.Margin = new System.Windows.Forms.Padding(2);
            this.CREATEANACCOUNT.Name = "CREATEANACCOUNT";
            this.CREATEANACCOUNT.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.CREATEANACCOUNT.Size = new System.Drawing.Size(157, 25);
            this.CREATEANACCOUNT.TabIndex = 16;
            this.CREATEANACCOUNT.Text = "Sign Up";
            this.CREATEANACCOUNT.Click += new System.EventHandler(this.CREATEANACCOUNT_Click);
            // 
            // FORGOTPASSWORD
            // 
            this.FORGOTPASSWORD.Appearance.ForeColor = System.Drawing.Color.Black;
            this.FORGOTPASSWORD.Appearance.Options.UseForeColor = true;
            this.FORGOTPASSWORD.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FORGOTPASSWORD.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.FORGOTPASSWORD.AppearancePressed.Options.UseBackColor = true;
            this.FORGOTPASSWORD.AppearancePressed.Options.UseForeColor = true;
            this.FORGOTPASSWORD.Location = new System.Drawing.Point(643, 352);
            this.FORGOTPASSWORD.Margin = new System.Windows.Forms.Padding(2);
            this.FORGOTPASSWORD.Name = "FORGOTPASSWORD";
            this.FORGOTPASSWORD.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.FORGOTPASSWORD.Size = new System.Drawing.Size(108, 26);
            this.FORGOTPASSWORD.TabIndex = 14;
            this.FORGOTPASSWORD.Text = "Forgot Password?";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 4);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(487, 508);
            this.pictureEdit1.TabIndex = 13;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelControl2.Location = new System.Drawing.Point(912, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 51);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "-";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // LOGINForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 494);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LOGINForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT HEALTH MONITORING SYSTEM";
            this.Load += new System.EventHandler(this.StudentInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion  
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton LOGIN;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton FORGOTPASSWORD;
        private DevExpress.XtraEditors.SimpleButton CREATEANACCOUNT;
        private DevExpress.XtraEditors.SimpleButton ALREADYHAVEANACCOUNT;
        private DevExpress.XtraEditors.ComboBoxEdit cbeUserTypes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

