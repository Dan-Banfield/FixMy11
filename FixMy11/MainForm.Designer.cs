namespace FixMy11
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Disable Diagnostic Data");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Disable Compatibility Telemetry");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Disable Telemetry");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Disable Windows Tips");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Disable Advertising");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Disable App Auto-Installs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Disable Background Apps");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Disable Feedback");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Disable Location Tracking");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Disable Suggested Content");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Disabled Tailored Experiences");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Privacy", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Disable Teams on Startup");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Bloatware", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Enable Full Context Menu");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Remove Fax Printer");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applySelectedFixesButton = new System.Windows.Forms.Button();
            this.sourceCodeLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.CheckBoxes = true;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(12, 80);
            this.treeView.Name = "treeView";
            treeNode1.Name = "disableDiagnosticDataNode";
            treeNode1.Text = "Disable Diagnostic Data";
            treeNode2.Name = "disableCompatibilityTelemetryNode";
            treeNode2.Text = "Disable Compatibility Telemetry";
            treeNode3.Name = "disableTelemetryNode";
            treeNode3.Text = "Disable Telemetry";
            treeNode4.Name = "disableWindowsTipsNode";
            treeNode4.Text = "Disable Windows Tips";
            treeNode5.Name = "disableAdvertising";
            treeNode5.Text = "Disable Advertising";
            treeNode6.Name = "disableAppAutoInstallsNode";
            treeNode6.Text = "Disable App Auto-Installs";
            treeNode7.Name = "disableBackgroundAppsNode";
            treeNode7.Text = "Disable Background Apps";
            treeNode8.Name = "disableFeedbackNode";
            treeNode8.Text = "Disable Feedback";
            treeNode9.Name = "disableLocationTrackingNode";
            treeNode9.Text = "Disable Location Tracking";
            treeNode10.Name = "disableSuggestedContentNode";
            treeNode10.Text = "Disable Suggested Content";
            treeNode11.Name = "disableTailoredExperiencesNode";
            treeNode11.Text = "Disabled Tailored Experiences";
            treeNode12.Name = "privacyNode";
            treeNode12.Text = "Privacy";
            treeNode13.Name = "disableTeamsOnStartupNode";
            treeNode13.Text = "Disable Teams on Startup";
            treeNode14.Name = "bloatwareNode";
            treeNode14.Text = "Bloatware";
            treeNode15.Name = "enableFullContextMenuNode";
            treeNode15.Text = "Enable Full Context Menu";
            treeNode16.Name = "removeFaxPrinterNode";
            treeNode16.Text = "Remove Fax Printer";
            treeNode17.Name = "systemNode";
            treeNode17.Text = "System";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode14,
            treeNode17});
            this.treeView.Size = new System.Drawing.Size(427, 375);
            this.treeView.TabIndex = 0;
            this.treeView.TabStop = false;
            this.treeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCheck);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(78, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(89, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "FixMy11";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FixMy11.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // applySelectedFixesButton
            // 
            this.applySelectedFixesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applySelectedFixesButton.Location = new System.Drawing.Point(12, 461);
            this.applySelectedFixesButton.Name = "applySelectedFixesButton";
            this.applySelectedFixesButton.Size = new System.Drawing.Size(427, 51);
            this.applySelectedFixesButton.TabIndex = 3;
            this.applySelectedFixesButton.TabStop = false;
            this.applySelectedFixesButton.Text = "Apply Selected Fixes";
            this.applySelectedFixesButton.UseVisualStyleBackColor = true;
            // 
            // sourceCodeLinkLabel
            // 
            this.sourceCodeLinkLabel.AutoSize = true;
            this.sourceCodeLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceCodeLinkLabel.Location = new System.Drawing.Point(341, 43);
            this.sourceCodeLinkLabel.Name = "sourceCodeLinkLabel";
            this.sourceCodeLinkLabel.Size = new System.Drawing.Size(98, 21);
            this.sourceCodeLinkLabel.TabIndex = 4;
            this.sourceCodeLinkLabel.TabStop = true;
            this.sourceCodeLinkLabel.Text = "Source Code";
            this.sourceCodeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceCodeLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 519);
            this.Controls.Add(this.sourceCodeLinkLabel);
            this.Controls.Add(this.applySelectedFixesButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.treeView);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixMy11";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button applySelectedFixesButton;
        private System.Windows.Forms.LinkLabel sourceCodeLinkLabel;
    }
}

