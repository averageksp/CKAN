namespace CKAN.GUI
{
    partial class NewUpdateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new SingleAssemblyComponentResourceManager(typeof(NewUpdateDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ReleaseNotesTextbox = new System.Windows.Forms.RichTextBox();
            this.InstallUpdateButton = new System.Windows.Forms.Button();
            this.CancelUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            resources.ApplyResources(this.label1, "label1");
            //
            // VersionLabel
            //
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(68, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            //
            // ReleaseNotesTextbox
            //
            this.ReleaseNotesTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseNotesTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.ReleaseNotesTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReleaseNotesTextbox.Location = new System.Drawing.Point(12, 25);
            this.ReleaseNotesTextbox.Name = "ReleaseNotesTextbox";
            this.ReleaseNotesTextbox.ReadOnly = true;
            this.ReleaseNotesTextbox.Size = new System.Drawing.Size(402, 246);
            this.ReleaseNotesTextbox.TabIndex = 3;
            this.ReleaseNotesTextbox.Text = "";
            //
            // InstallUpdateButton
            //
            this.InstallUpdateButton.AutoSize = true;
            this.InstallUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.InstallUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallUpdateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InstallUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallUpdateButton.Location = new System.Drawing.Point(314, 277);
            this.InstallUpdateButton.Name = "InstallUpdateButton";
            this.InstallUpdateButton.Size = new System.Drawing.Size(100, 23);
            this.InstallUpdateButton.TabIndex = 4;
            this.InstallUpdateButton.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.InstallUpdateButton, "InstallUpdateButton");
            //
            // CancelUpdateButton
            //
            this.CancelUpdateButton.AutoSize = true;
            this.CancelUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.CancelUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelUpdateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelUpdateButton.Location = new System.Drawing.Point(208, 277);
            this.CancelUpdateButton.Name = "CancelUpdateButton";
            this.CancelUpdateButton.Size = new System.Drawing.Size(100, 23);
            this.CancelUpdateButton.TabIndex = 5;
            this.CancelUpdateButton.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.CancelUpdateButton, "CancelUpdateButton");
            //
            // NewUpdateDialog
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.CancelUpdateButton);
            this.Controls.Add(this.InstallUpdateButton);
            this.Controls.Add(this.ReleaseNotesTextbox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.label1);
            this.Icon = EmbeddedImages.AppIcon;
            this.MinimumSize = new System.Drawing.Size(354, 245);
            this.Name = "NewUpdateDialog";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.RichTextBox ReleaseNotesTextbox;
        private System.Windows.Forms.Button InstallUpdateButton;
        private System.Windows.Forms.Button CancelUpdateButton;
    }
}
