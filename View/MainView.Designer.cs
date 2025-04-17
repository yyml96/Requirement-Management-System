namespace _3.View
{
    partial class MainView
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
            this.btnUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnRequirement = new System.Windows.Forms.Button();
            this.btnDependency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(58, 46);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(199, 104);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(307, 46);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(199, 104);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "Project";
            this.btnProject.UseVisualStyleBackColor = true;
            // 
            // btnRequirement
            // 
            this.btnRequirement.Location = new System.Drawing.Point(58, 196);
            this.btnRequirement.Name = "btnRequirement";
            this.btnRequirement.Size = new System.Drawing.Size(199, 104);
            this.btnRequirement.TabIndex = 3;
            this.btnRequirement.Text = "Requirement";
            this.btnRequirement.UseVisualStyleBackColor = true;
            // 
            // btnDependency
            // 
            this.btnDependency.Location = new System.Drawing.Point(307, 196);
            this.btnDependency.Name = "btnDependency";
            this.btnDependency.Size = new System.Drawing.Size(199, 104);
            this.btnDependency.TabIndex = 4;
            this.btnDependency.Text = "Dependency";
            this.btnDependency.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 578);
            this.Controls.Add(this.btnDependency);
            this.Controls.Add(this.btnRequirement);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUser);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnRequirement;
        private System.Windows.Forms.Button btnDependency;
    }
}