namespace StudentInformationSystemfinal.Form.cs
{
    partial class PatientObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientObject));
            this.PATIENT1 = new DevExpress.XtraEditors.LabelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.EDIT = new DevExpress.XtraEditors.SimpleButton();
            this.DELETE = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ADDPATIENT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PATIENT1
            // 
            this.PATIENT1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATIENT1.Appearance.Options.UseFont = true;
            this.PATIENT1.Location = new System.Drawing.Point(14, 28);
            this.PATIENT1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PATIENT1.Name = "PATIENT1";
            this.PATIENT1.Size = new System.Drawing.Size(56, 22);
            this.PATIENT1.TabIndex = 1;
            this.PATIENT1.Text = "Patient";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(7, 63);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.AutoHeight = false;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(780, 43);
            this.searchControl1.TabIndex = 2;
            // 
            // EDIT
            // 
            this.EDIT.Appearance.BackColor = System.Drawing.Color.White;
            this.EDIT.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.EDIT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.Appearance.Options.UseBackColor = true;
            this.EDIT.Appearance.Options.UseBorderColor = true;
            this.EDIT.Appearance.Options.UseFont = true;
            this.EDIT.AppearancePressed.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EDIT.AppearancePressed.BorderColor = System.Drawing.Color.AliceBlue;
            this.EDIT.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.AppearancePressed.Options.UseBackColor = true;
            this.EDIT.AppearancePressed.Options.UseBorderColor = true;
            this.EDIT.AppearancePressed.Options.UseFont = true;
            this.EDIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EDIT.ImageOptions.Image")));
            this.EDIT.Location = new System.Drawing.Point(820, 65);
            this.EDIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(59, 40);
            this.EDIT.TabIndex = 4;
            this.EDIT.Text = "Edit";
            // 
            // DELETE
            // 
            this.DELETE.Appearance.BackColor = System.Drawing.Color.White;
            this.DELETE.Appearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.DELETE.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Appearance.Options.UseBackColor = true;
            this.DELETE.Appearance.Options.UseBorderColor = true;
            this.DELETE.Appearance.Options.UseFont = true;
            this.DELETE.AppearancePressed.BackColor = System.Drawing.Color.SeaGreen;
            this.DELETE.AppearancePressed.BorderColor = System.Drawing.Color.AliceBlue;
            this.DELETE.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.AppearancePressed.Options.UseBackColor = true;
            this.DELETE.AppearancePressed.Options.UseBorderColor = true;
            this.DELETE.AppearancePressed.Options.UseFont = true;
            this.DELETE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.ImageOptions.Image")));
            this.DELETE.Location = new System.Drawing.Point(899, 65);
            this.DELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(74, 41);
            this.DELETE.TabIndex = 5;
            this.DELETE.Text = "Delete";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(7, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1385, 838);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 224;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 467;
            // 
            // ADDPATIENT
            // 
            this.ADDPATIENT.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ADDPATIENT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDPATIENT.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.ADDPATIENT.Appearance.Options.UseBackColor = true;
            this.ADDPATIENT.Appearance.Options.UseFont = true;
            this.ADDPATIENT.Appearance.Options.UseForeColor = true;
            this.ADDPATIENT.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.ADDPATIENT.AppearancePressed.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ADDPATIENT.AppearancePressed.Options.UseBorderColor = true;
            this.ADDPATIENT.AppearancePressed.Options.UseForeColor = true;
            this.ADDPATIENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADDPATIENT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ADDPATIENT.ImageOptions.Image")));
            this.ADDPATIENT.Location = new System.Drawing.Point(995, 65);
            this.ADDPATIENT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ADDPATIENT.Name = "ADDPATIENT";
            this.ADDPATIENT.Size = new System.Drawing.Size(264, 41);
            this.ADDPATIENT.TabIndex = 6;
            this.ADDPATIENT.Text = "Add Patient";
            this.ADDPATIENT.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ADDPATIENT.Click += new System.EventHandler(this.ADDPATIENT_Click);
            // 
            // PatientObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 678);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ADDPATIENT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.PATIENT1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.PatientObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl PATIENT1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton EDIT;
        private DevExpress.XtraEditors.SimpleButton DELETE;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton ADDPATIENT;
    }
}