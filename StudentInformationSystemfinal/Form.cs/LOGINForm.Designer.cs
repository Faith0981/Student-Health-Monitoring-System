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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbeUserTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ALREADYHAVEANACCOUNT = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUserName
            // 
            this.teUserName.EditValue = "";
            this.teUserName.Location = new System.Drawing.Point(638, 172);
            this.teUserName.Margin = new System.Windows.Forms.Padding(2);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AdvancedModeOptions.Label = "UserName";
            this.teUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(222)))));
            this.teUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teUserName.Properties.Appearance.Options.UseBackColor = true;
            this.teUserName.Properties.Appearance.Options.UseFont = true;
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("teUserName.Properties.ContextImageOptions.Image")));
            this.teUserName.Properties.ContextImageOptions.ImageUri.Uri = "outlook%20inspired/miss";
            this.teUserName.Size = new System.Drawing.Size(285, 51);
            this.teUserName.TabIndex = 1;
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "";
            this.tePassword.Location = new System.Drawing.Point(638, 92);
            this.tePassword.Margin = new System.Windows.Forms.Padding(2);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AdvancedModeOptions.Label = "Password";
            this.tePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(222)))));
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tePassword.Properties.Appearance.Options.UseBackColor = true;
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tePassword.Properties.ContextImageOptions.Image")));
            this.tePassword.Properties.ContextImageOptions.ImageUri.Uri = "business%20objects/bo_security_permission";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(285, 51);
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
            this.LOGIN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(102)))));
            this.LOGIN.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Appearance.Options.UseBackColor = true;
            this.LOGIN.Appearance.Options.UseFont = true;
            this.LOGIN.Location = new System.Drawing.Point(690, 308);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(176, 45);
            this.LOGIN.TabIndex = 12;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 498);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbeUserTypes
            // 
            this.cbeUserTypes.Location = new System.Drawing.Point(638, 248);
            this.cbeUserTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cbeUserTypes.MenuManager = this.barManager1;
            this.cbeUserTypes.Name = "cbeUserTypes";
            this.cbeUserTypes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.cbeUserTypes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeUserTypes.Properties.Appearance.Options.UseBackColor = true;
            this.cbeUserTypes.Properties.Appearance.Options.UseFont = true;
            this.cbeUserTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeUserTypes.Properties.Items.AddRange(new object[] {
            "Administrator",
            "Nurse"});
            this.cbeUserTypes.Size = new System.Drawing.Size(285, 38);
            this.cbeUserTypes.TabIndex = 18;
            this.cbeUserTypes.SelectedIndexChanged += new System.EventHandler(this.cbeUserTypes_SelectedIndexChanged);
            // 
            // ALREADYHAVEANACCOUNT
            // 
            this.ALREADYHAVEANACCOUNT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALREADYHAVEANACCOUNT.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(74)))), ((int)(((byte)(55)))));
            this.ALREADYHAVEANACCOUNT.Appearance.Options.UseFont = true;
            this.ALREADYHAVEANACCOUNT.Appearance.Options.UseForeColor = true;
            this.ALREADYHAVEANACCOUNT.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.ALREADYHAVEANACCOUNT.AppearanceHovered.Options.UseBackColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseBackColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseBorderColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseForeColor = true;
            this.ALREADYHAVEANACCOUNT.Location = new System.Drawing.Point(581, 375);
            this.ALREADYHAVEANACCOUNT.Margin = new System.Windows.Forms.Padding(2);
            this.ALREADYHAVEANACCOUNT.Name = "ALREADYHAVEANACCOUNT";
            this.ALREADYHAVEANACCOUNT.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ALREADYHAVEANACCOUNT.Size = new System.Drawing.Size(199, 25);
            this.ALREADYHAVEANACCOUNT.TabIndex = 24;
            this.ALREADYHAVEANACCOUNT.Text = "Already Have an Account?";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(74)))), ((int)(((byte)(55)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(832, 375);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(116, 25);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "Forget Password";
            // 
            // LOGINForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 494);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ALREADYHAVEANACCOUNT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbeUserTypes);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.LOGIN);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cbeUserTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton ALREADYHAVEANACCOUNT;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

