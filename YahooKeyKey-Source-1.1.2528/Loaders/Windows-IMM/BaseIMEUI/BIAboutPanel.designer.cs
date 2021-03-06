// [AUTO_HEADER]

namespace BaseIMEUI
{
    
    partial class BIAboutPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIAboutPanel));
			this.u_linkHomepage = new System.Windows.Forms.LinkLabel();
			this.u_linkAgreement = new System.Windows.Forms.LinkLabel();
			this.u_linkPrivacy = new System.Windows.Forms.LinkLabel();
			this.u_desc = new System.Windows.Forms.Label();
			this.u_feedback = new System.Windows.Forms.Button();
			this.u_version = new System.Windows.Forms.Label();
			this.u_pictureLogo = new System.Windows.Forms.PictureBox();
			this.u_databaseVersion = new System.Windows.Forms.Label();
			this.u_wordCountGroup = new System.Windows.Forms.GroupBox();
			this.u_wordCountTotalCountLabel = new System.Windows.Forms.Label();
			this.u_wordCountThisWeekCountLabel = new System.Windows.Forms.Label();
			this.u_wordCountTodayCountLabel = new System.Windows.Forms.Label();
			this.u_wordCountEnableCheckBox = new System.Windows.Forms.CheckBox();
			this.u_wordCountClearButton = new System.Windows.Forms.Button();
			this.u_wordCountTotalLabel = new System.Windows.Forms.Label();
			this.u_wordCountThisWeekLabel = new System.Windows.Forms.Label();
			this.u_wordCountTodayLabel = new System.Windows.Forms.Label();
			this.u_wordCountMessageLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.u_pictureLogo)).BeginInit();
			this.u_wordCountGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// u_linkHomepage
			// 
			resources.ApplyResources(this.u_linkHomepage, "u_linkHomepage");
			this.u_linkHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.u_linkHomepage.Name = "u_linkHomepage";
			this.u_linkHomepage.TabStop = true;
			this.u_linkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.u_linkHomepage_LinkClicked);
			// 
			// u_linkAgreement
			// 
			resources.ApplyResources(this.u_linkAgreement, "u_linkAgreement");
			this.u_linkAgreement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.u_linkAgreement.Name = "u_linkAgreement";
			this.u_linkAgreement.TabStop = true;
			this.u_linkAgreement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.u_linkAgreement_LinkClicked);
			// 
			// u_linkPrivacy
			// 
			resources.ApplyResources(this.u_linkPrivacy, "u_linkPrivacy");
			this.u_linkPrivacy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.u_linkPrivacy.Name = "u_linkPrivacy";
			this.u_linkPrivacy.TabStop = true;
			this.u_linkPrivacy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.u_linkPrivacy_LinkClicked);
			// 
			// u_desc
			// 
			resources.ApplyResources(this.u_desc, "u_desc");
			this.u_desc.Name = "u_desc";
			// 
			// u_feedback
			// 
			resources.ApplyResources(this.u_feedback, "u_feedback");
			this.u_feedback.Name = "u_feedback";
			this.u_feedback.UseVisualStyleBackColor = true;
			this.u_feedback.Click += new System.EventHandler(this.u_feedback_Click);
			// 
			// u_version
			// 
			resources.ApplyResources(this.u_version, "u_version");
			this.u_version.Name = "u_version";
			// 
			// u_pictureLogo
			// 
			this.u_pictureLogo.InitialImage = null;
			resources.ApplyResources(this.u_pictureLogo, "u_pictureLogo");
			this.u_pictureLogo.Name = "u_pictureLogo";
			this.u_pictureLogo.TabStop = false;
			// 
			// u_databaseVersion
			// 
			resources.ApplyResources(this.u_databaseVersion, "u_databaseVersion");
			this.u_databaseVersion.Name = "u_databaseVersion";
			// 
			// u_wordCountGroup
			// 
			this.u_wordCountGroup.Controls.Add(this.u_wordCountTotalCountLabel);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountThisWeekCountLabel);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountTodayCountLabel);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountEnableCheckBox);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountClearButton);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountTotalLabel);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountThisWeekLabel);
			this.u_wordCountGroup.Controls.Add(this.u_wordCountTodayLabel);
			resources.ApplyResources(this.u_wordCountGroup, "u_wordCountGroup");
			this.u_wordCountGroup.Name = "u_wordCountGroup";
			this.u_wordCountGroup.TabStop = false;
			// 
			// u_wordCountTotalCountLabel
			// 
			resources.ApplyResources(this.u_wordCountTotalCountLabel, "u_wordCountTotalCountLabel");
			this.u_wordCountTotalCountLabel.Name = "u_wordCountTotalCountLabel";
			// 
			// u_wordCountThisWeekCountLabel
			// 
			resources.ApplyResources(this.u_wordCountThisWeekCountLabel, "u_wordCountThisWeekCountLabel");
			this.u_wordCountThisWeekCountLabel.Name = "u_wordCountThisWeekCountLabel";
			// 
			// u_wordCountTodayCountLabel
			// 
			resources.ApplyResources(this.u_wordCountTodayCountLabel, "u_wordCountTodayCountLabel");
			this.u_wordCountTodayCountLabel.Name = "u_wordCountTodayCountLabel";
			// 
			// u_wordCountEnableCheckBox
			// 
			resources.ApplyResources(this.u_wordCountEnableCheckBox, "u_wordCountEnableCheckBox");
			this.u_wordCountEnableCheckBox.Name = "u_wordCountEnableCheckBox";
			this.u_wordCountEnableCheckBox.UseVisualStyleBackColor = true;
			this.u_wordCountEnableCheckBox.CheckedChanged += new System.EventHandler(this.u_wordCountEnableCheckBox_CheckedChanged);
			// 
			// u_wordCountClearButton
			// 
			resources.ApplyResources(this.u_wordCountClearButton, "u_wordCountClearButton");
			this.u_wordCountClearButton.Name = "u_wordCountClearButton";
			this.u_wordCountClearButton.UseVisualStyleBackColor = true;
			this.u_wordCountClearButton.Click += new System.EventHandler(this.ClearWordCount);
			// 
			// u_wordCountTotalLabel
			// 
			resources.ApplyResources(this.u_wordCountTotalLabel, "u_wordCountTotalLabel");
			this.u_wordCountTotalLabel.Name = "u_wordCountTotalLabel";
			// 
			// u_wordCountThisWeekLabel
			// 
			resources.ApplyResources(this.u_wordCountThisWeekLabel, "u_wordCountThisWeekLabel");
			this.u_wordCountThisWeekLabel.Name = "u_wordCountThisWeekLabel";
			// 
			// u_wordCountTodayLabel
			// 
			resources.ApplyResources(this.u_wordCountTodayLabel, "u_wordCountTodayLabel");
			this.u_wordCountTodayLabel.Name = "u_wordCountTodayLabel";
			// 
			// u_wordCountMessageLabel
			// 
			resources.ApplyResources(this.u_wordCountMessageLabel, "u_wordCountMessageLabel");
			this.u_wordCountMessageLabel.Name = "u_wordCountMessageLabel";
			// 
			// BIAboutPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.u_wordCountMessageLabel);
			this.Controls.Add(this.u_wordCountGroup);
			this.Controls.Add(this.u_databaseVersion);
			this.Controls.Add(this.u_version);
			this.Controls.Add(this.u_feedback);
			this.Controls.Add(this.u_desc);
			this.Controls.Add(this.u_pictureLogo);
			this.Controls.Add(this.u_linkPrivacy);
			this.Controls.Add(this.u_linkAgreement);
			this.Controls.Add(this.u_linkHomepage);
			this.Name = "BIAboutPanel";
			resources.ApplyResources(this, "$this");
			((System.ComponentModel.ISupportInitialize)(this.u_pictureLogo)).EndInit();
			this.u_wordCountGroup.ResumeLayout(false);
			this.u_wordCountGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel u_linkHomepage;
        private System.Windows.Forms.LinkLabel u_linkAgreement;
        private System.Windows.Forms.LinkLabel u_linkPrivacy;
        private System.Windows.Forms.PictureBox u_pictureLogo;
        private System.Windows.Forms.Label u_desc;
        private System.Windows.Forms.Button u_feedback;
        private System.Windows.Forms.Label u_version;
        private System.Windows.Forms.Label u_databaseVersion;
        private System.Windows.Forms.GroupBox u_wordCountGroup;
        private System.Windows.Forms.CheckBox u_wordCountEnableCheckBox;
        private System.Windows.Forms.Button u_wordCountClearButton;
        private System.Windows.Forms.Label u_wordCountTotalLabel;
        private System.Windows.Forms.Label u_wordCountThisWeekLabel;
        private System.Windows.Forms.Label u_wordCountTodayLabel;
        private System.Windows.Forms.Label u_wordCountTotalCountLabel;
        private System.Windows.Forms.Label u_wordCountThisWeekCountLabel;
        private System.Windows.Forms.Label u_wordCountTodayCountLabel;
        private System.Windows.Forms.Label u_wordCountMessageLabel;
    }
}
