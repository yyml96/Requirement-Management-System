namespace _3.View
{
    partial class DependencyViewForm
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
            this.DependencytabControl = new System.Windows.Forms.TabControl();
            this.DependencyList = new System.Windows.Forms.TabPage();
            this.depDeletebutton = new System.Windows.Forms.Button();
            this.depEditbutton = new System.Windows.Forms.Button();
            this.depAddbutton = new System.Windows.Forms.Button();
            this.depdataGridView = new System.Windows.Forms.DataGridView();
            this.depSearchbutton = new System.Windows.Forms.Button();
            this.depSearchtextBox = new System.Windows.Forms.TextBox();
            this.DependencyDetail = new System.Windows.Forms.TabPage();
            this.dep_repcomboBox1 = new System.Windows.Forms.ComboBox();
            this.repselectioncomboBox = new System.Windows.Forms.ComboBox();
            this.dependencydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.depIdtextBox = new System.Windows.Forms.TextBox();
            this.depcancelbutton = new System.Windows.Forms.Button();
            this.depsavebutton = new System.Windows.Forms.Button();
            this.Created = new System.Windows.Forms.Label();
            this.dep_repselction = new System.Windows.Forms.Label();
            this.depNametextBox = new System.Windows.Forms.TextBox();
            this.DependencyName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dependency = new System.Windows.Forms.Label();
            this.DependencyCmd = new System.Windows.Forms.TabPage();
            this.cmdDepIDtextBox = new System.Windows.Forms.TextBox();
            this.cmdCreateddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdDeptextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDepUserIDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDepUserSelectioncomboBox = new System.Windows.Forms.ComboBox();
            this.cmdDepCancelbutton = new System.Windows.Forms.Button();
            this.cmdDepSavebutton = new System.Windows.Forms.Button();
            this.cmdProjectIDtextBox = new System.Windows.Forms.TextBox();
            this.cmd_depSelection = new System.Windows.Forms.Label();
            this.cmdProjectSelectioncomboBox1 = new System.Windows.Forms.ComboBox();
            this.DependencytabControl.SuspendLayout();
            this.DependencyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depdataGridView)).BeginInit();
            this.DependencyDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DependencyCmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // DependencytabControl
            // 
            this.DependencytabControl.Controls.Add(this.DependencyList);
            this.DependencytabControl.Controls.Add(this.DependencyDetail);
            this.DependencytabControl.Controls.Add(this.DependencyCmd);
            this.DependencytabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DependencytabControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DependencytabControl.Location = new System.Drawing.Point(0, 133);
            this.DependencytabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DependencytabControl.Name = "DependencytabControl";
            this.DependencytabControl.SelectedIndex = 0;
            this.DependencytabControl.Size = new System.Drawing.Size(1681, 948);
            this.DependencytabControl.TabIndex = 10;
            // 
            // DependencyList
            // 
            this.DependencyList.Controls.Add(this.depDeletebutton);
            this.DependencyList.Controls.Add(this.depEditbutton);
            this.DependencyList.Controls.Add(this.depAddbutton);
            this.DependencyList.Controls.Add(this.depdataGridView);
            this.DependencyList.Controls.Add(this.depSearchbutton);
            this.DependencyList.Controls.Add(this.depSearchtextBox);
            this.DependencyList.Location = new System.Drawing.Point(8, 50);
            this.DependencyList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DependencyList.Name = "DependencyList";
            this.DependencyList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DependencyList.Size = new System.Drawing.Size(1665, 890);
            this.DependencyList.TabIndex = 0;
            this.DependencyList.Text = "Dependency List";
            this.DependencyList.UseVisualStyleBackColor = true;
            // 
            // depDeletebutton
            // 
            this.depDeletebutton.Location = new System.Drawing.Point(1413, 365);
            this.depDeletebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depDeletebutton.Name = "depDeletebutton";
            this.depDeletebutton.Size = new System.Drawing.Size(172, 69);
            this.depDeletebutton.TabIndex = 5;
            this.depDeletebutton.Text = "Delete";
            this.depDeletebutton.UseVisualStyleBackColor = true;
            // 
            // depEditbutton
            // 
            this.depEditbutton.Location = new System.Drawing.Point(1413, 262);
            this.depEditbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depEditbutton.Name = "depEditbutton";
            this.depEditbutton.Size = new System.Drawing.Size(172, 69);
            this.depEditbutton.TabIndex = 4;
            this.depEditbutton.Text = "Edit";
            this.depEditbutton.UseVisualStyleBackColor = true;
            // 
            // depAddbutton
            // 
            this.depAddbutton.Location = new System.Drawing.Point(1413, 162);
            this.depAddbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depAddbutton.Name = "depAddbutton";
            this.depAddbutton.Size = new System.Drawing.Size(172, 69);
            this.depAddbutton.TabIndex = 3;
            this.depAddbutton.Text = "Add new";
            this.depAddbutton.UseVisualStyleBackColor = true;
            // 
            // depdataGridView
            // 
            this.depdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depdataGridView.Location = new System.Drawing.Point(30, 159);
            this.depdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depdataGridView.Name = "depdataGridView";
            this.depdataGridView.RowHeadersWidth = 82;
            this.depdataGridView.RowTemplate.Height = 24;
            this.depdataGridView.Size = new System.Drawing.Size(1354, 686);
            this.depdataGridView.TabIndex = 2;
            // 
            // depSearchbutton
            // 
            this.depSearchbutton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depSearchbutton.Location = new System.Drawing.Point(1413, 48);
            this.depSearchbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depSearchbutton.Name = "depSearchbutton";
            this.depSearchbutton.Size = new System.Drawing.Size(172, 69);
            this.depSearchbutton.TabIndex = 1;
            this.depSearchbutton.Text = "Search";
            this.depSearchbutton.UseVisualStyleBackColor = true;
            // 
            // depSearchtextBox
            // 
            this.depSearchtextBox.Location = new System.Drawing.Point(30, 48);
            this.depSearchtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depSearchtextBox.Name = "depSearchtextBox";
            this.depSearchtextBox.Size = new System.Drawing.Size(1354, 44);
            this.depSearchtextBox.TabIndex = 0;
            // 
            // DependencyDetail
            // 
            this.DependencyDetail.Controls.Add(this.dep_repcomboBox1);
            this.DependencyDetail.Controls.Add(this.repselectioncomboBox);
            this.DependencyDetail.Controls.Add(this.dependencydateTimePicker);
            this.DependencyDetail.Controls.Add(this.depIdtextBox);
            this.DependencyDetail.Controls.Add(this.depcancelbutton);
            this.DependencyDetail.Controls.Add(this.depsavebutton);
            this.DependencyDetail.Controls.Add(this.Created);
            this.DependencyDetail.Controls.Add(this.dep_repselction);
            this.DependencyDetail.Controls.Add(this.depNametextBox);
            this.DependencyDetail.Controls.Add(this.DependencyName);
            this.DependencyDetail.Location = new System.Drawing.Point(8, 50);
            this.DependencyDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DependencyDetail.Name = "DependencyDetail";
            this.DependencyDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DependencyDetail.Size = new System.Drawing.Size(1665, 890);
            this.DependencyDetail.TabIndex = 1;
            this.DependencyDetail.Text = "Dependency Detail";
            this.DependencyDetail.UseVisualStyleBackColor = true;
            // 
            // dep_repcomboBox1
            // 
            this.dep_repcomboBox1.FormattingEnabled = true;
            this.dep_repcomboBox1.Location = new System.Drawing.Point(689, 514);
            this.dep_repcomboBox1.Name = "dep_repcomboBox1";
            this.dep_repcomboBox1.Size = new System.Drawing.Size(439, 44);
            this.dep_repcomboBox1.TabIndex = 15;
            // 
            // repselectioncomboBox
            // 
            this.repselectioncomboBox.FormattingEnabled = true;
            this.repselectioncomboBox.Location = new System.Drawing.Point(124, 514);
            this.repselectioncomboBox.Name = "repselectioncomboBox";
            this.repselectioncomboBox.Size = new System.Drawing.Size(439, 44);
            this.repselectioncomboBox.TabIndex = 14;
            // 
            // dependencydateTimePicker
            // 
            this.dependencydateTimePicker.Location = new System.Drawing.Point(689, 323);
            this.dependencydateTimePicker.Name = "dependencydateTimePicker";
            this.dependencydateTimePicker.Size = new System.Drawing.Size(529, 44);
            this.dependencydateTimePicker.TabIndex = 13;
            // 
            // depIdtextBox
            // 
            this.depIdtextBox.Location = new System.Drawing.Point(124, 125);
            this.depIdtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depIdtextBox.Name = "depIdtextBox";
            this.depIdtextBox.Size = new System.Drawing.Size(182, 44);
            this.depIdtextBox.TabIndex = 12;
            this.depIdtextBox.Text = "0";
            // 
            // depcancelbutton
            // 
            this.depcancelbutton.Location = new System.Drawing.Point(519, 725);
            this.depcancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depcancelbutton.Name = "depcancelbutton";
            this.depcancelbutton.Size = new System.Drawing.Size(322, 128);
            this.depcancelbutton.TabIndex = 11;
            this.depcancelbutton.Text = "Cancel";
            this.depcancelbutton.UseVisualStyleBackColor = true;
            // 
            // depsavebutton
            // 
            this.depsavebutton.Location = new System.Drawing.Point(124, 725);
            this.depsavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depsavebutton.Name = "depsavebutton";
            this.depsavebutton.Size = new System.Drawing.Size(322, 128);
            this.depsavebutton.TabIndex = 10;
            this.depsavebutton.Text = "Save";
            this.depsavebutton.UseVisualStyleBackColor = true;
            // 
            // Created
            // 
            this.Created.AutoSize = true;
            this.Created.Location = new System.Drawing.Point(683, 239);
            this.Created.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(385, 36);
            this.Created.TabIndex = 8;
            this.Created.Text = "Dependency Created Date";
            // 
            // dep_repselction
            // 
            this.dep_repselction.AutoSize = true;
            this.dep_repselction.Location = new System.Drawing.Point(128, 430);
            this.dep_repselction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dep_repselction.Name = "dep_repselction";
            this.dep_repselction.Size = new System.Drawing.Size(292, 36);
            this.dep_repselction.TabIndex = 6;
            this.dep_repselction.Text = "Select Requirement";
            // 
            // depNametextBox
            // 
            this.depNametextBox.Location = new System.Drawing.Point(124, 326);
            this.depNametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depNametextBox.Name = "depNametextBox";
            this.depNametextBox.Size = new System.Drawing.Size(439, 44);
            this.depNametextBox.TabIndex = 3;
            // 
            // DependencyName
            // 
            this.DependencyName.AutoSize = true;
            this.DependencyName.Location = new System.Drawing.Point(128, 239);
            this.DependencyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DependencyName.Name = "DependencyName";
            this.DependencyName.Size = new System.Drawing.Size(283, 36);
            this.DependencyName.TabIndex = 2;
            this.DependencyName.Text = "Dependency Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dependency);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1681, 133);
            this.panel1.TabIndex = 9;
            // 
            // Dependency
            // 
            this.Dependency.AutoSize = true;
            this.Dependency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dependency.Location = new System.Drawing.Point(32, 34);
            this.Dependency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dependency.Name = "Dependency";
            this.Dependency.Size = new System.Drawing.Size(230, 42);
            this.Dependency.TabIndex = 0;
            this.Dependency.Text = "Dependency";
            // 
            // DependencyCmd
            // 
            this.DependencyCmd.Controls.Add(this.cmdDepIDtextBox);
            this.DependencyCmd.Controls.Add(this.cmdCreateddateTimePicker);
            this.DependencyCmd.Controls.Add(this.label4);
            this.DependencyCmd.Controls.Add(this.cmdDeptextBox);
            this.DependencyCmd.Controls.Add(this.label3);
            this.DependencyCmd.Controls.Add(this.cmdDepUserIDtextBox);
            this.DependencyCmd.Controls.Add(this.label2);
            this.DependencyCmd.Controls.Add(this.cmdDepUserSelectioncomboBox);
            this.DependencyCmd.Controls.Add(this.cmdDepCancelbutton);
            this.DependencyCmd.Controls.Add(this.cmdDepSavebutton);
            this.DependencyCmd.Controls.Add(this.cmdProjectIDtextBox);
            this.DependencyCmd.Controls.Add(this.cmd_depSelection);
            this.DependencyCmd.Controls.Add(this.cmdProjectSelectioncomboBox1);
            this.DependencyCmd.Location = new System.Drawing.Point(8, 50);
            this.DependencyCmd.Name = "DependencyCmd";
            this.DependencyCmd.Size = new System.Drawing.Size(1665, 890);
            this.DependencyCmd.TabIndex = 2;
            this.DependencyCmd.Text = "Dependency Comment";
            this.DependencyCmd.UseVisualStyleBackColor = true;
            // 
            // cmdDepIDtextBox
            // 
            this.cmdDepIDtextBox.Location = new System.Drawing.Point(846, 545);
            this.cmdDepIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDepIDtextBox.Name = "cmdDepIDtextBox";
            this.cmdDepIDtextBox.Size = new System.Drawing.Size(88, 44);
            this.cmdDepIDtextBox.TabIndex = 40;
            this.cmdDepIDtextBox.Text = "0";
            // 
            // cmdCreateddateTimePicker
            // 
            this.cmdCreateddateTimePicker.Location = new System.Drawing.Point(215, 545);
            this.cmdCreateddateTimePicker.Name = "cmdCreateddateTimePicker";
            this.cmdCreateddateTimePicker.Size = new System.Drawing.Size(534, 44);
            this.cmdCreateddateTimePicker.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Created Date";
            // 
            // cmdDeptextBox
            // 
            this.cmdDeptextBox.Location = new System.Drawing.Point(853, 362);
            this.cmdDeptextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDeptextBox.Name = "cmdDeptextBox";
            this.cmdDeptextBox.Size = new System.Drawing.Size(439, 44);
            this.cmdDeptextBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 36);
            this.label3.TabIndex = 36;
            this.label3.Text = "Comment";
            // 
            // cmdDepUserIDtextBox
            // 
            this.cmdDepUserIDtextBox.Location = new System.Drawing.Point(61, 362);
            this.cmdDepUserIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDepUserIDtextBox.Name = "cmdDepUserIDtextBox";
            this.cmdDepUserIDtextBox.Size = new System.Drawing.Size(94, 44);
            this.cmdDepUserIDtextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select User";
            // 
            // cmdDepUserSelectioncomboBox
            // 
            this.cmdDepUserSelectioncomboBox.FormattingEnabled = true;
            this.cmdDepUserSelectioncomboBox.Location = new System.Drawing.Point(215, 362);
            this.cmdDepUserSelectioncomboBox.Name = "cmdDepUserSelectioncomboBox";
            this.cmdDepUserSelectioncomboBox.Size = new System.Drawing.Size(379, 44);
            this.cmdDepUserSelectioncomboBox.TabIndex = 33;
            // 
            // cmdDepCancelbutton
            // 
            this.cmdDepCancelbutton.Location = new System.Drawing.Point(612, 697);
            this.cmdDepCancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDepCancelbutton.Name = "cmdDepCancelbutton";
            this.cmdDepCancelbutton.Size = new System.Drawing.Size(322, 128);
            this.cmdDepCancelbutton.TabIndex = 32;
            this.cmdDepCancelbutton.Text = "Cancel";
            this.cmdDepCancelbutton.UseVisualStyleBackColor = true;
            // 
            // cmdDepSavebutton
            // 
            this.cmdDepSavebutton.Location = new System.Drawing.Point(226, 697);
            this.cmdDepSavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDepSavebutton.Name = "cmdDepSavebutton";
            this.cmdDepSavebutton.Size = new System.Drawing.Size(322, 128);
            this.cmdDepSavebutton.TabIndex = 31;
            this.cmdDepSavebutton.Text = "Save";
            this.cmdDepSavebutton.UseVisualStyleBackColor = true;
            // 
            // cmdProjectIDtextBox
            // 
            this.cmdProjectIDtextBox.Location = new System.Drawing.Point(61, 165);
            this.cmdProjectIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdProjectIDtextBox.Name = "cmdProjectIDtextBox";
            this.cmdProjectIDtextBox.Size = new System.Drawing.Size(94, 44);
            this.cmdProjectIDtextBox.TabIndex = 29;
            // 
            // cmd_depSelection
            // 
            this.cmd_depSelection.AutoSize = true;
            this.cmd_depSelection.Location = new System.Drawing.Point(209, 84);
            this.cmd_depSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmd_depSelection.Name = "cmd_depSelection";
            this.cmd_depSelection.Size = new System.Drawing.Size(286, 36);
            this.cmd_depSelection.TabIndex = 27;
            this.cmd_depSelection.Text = "Select Dependency";
            // 
            // cmdProjectSelectioncomboBox1
            // 
            this.cmdProjectSelectioncomboBox1.FormattingEnabled = true;
            this.cmdProjectSelectioncomboBox1.Location = new System.Drawing.Point(215, 165);
            this.cmdProjectSelectioncomboBox1.Name = "cmdProjectSelectioncomboBox1";
            this.cmdProjectSelectioncomboBox1.Size = new System.Drawing.Size(379, 44);
            this.cmdProjectSelectioncomboBox1.TabIndex = 25;
            // 
            // DependencyViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 1081);
            this.Controls.Add(this.DependencytabControl);
            this.Controls.Add(this.panel1);
            this.Name = "DependencyViewForm";
            this.Text = "DependencyViewForm";
            this.DependencytabControl.ResumeLayout(false);
            this.DependencyList.ResumeLayout(false);
            this.DependencyList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depdataGridView)).EndInit();
            this.DependencyDetail.ResumeLayout(false);
            this.DependencyDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DependencyCmd.ResumeLayout(false);
            this.DependencyCmd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DependencytabControl;
        private System.Windows.Forms.TabPage DependencyList;
        private System.Windows.Forms.Button depDeletebutton;
        private System.Windows.Forms.Button depEditbutton;
        private System.Windows.Forms.Button depAddbutton;
        private System.Windows.Forms.DataGridView depdataGridView;
        private System.Windows.Forms.Button depSearchbutton;
        private System.Windows.Forms.TextBox depSearchtextBox;
        private System.Windows.Forms.TabPage DependencyDetail;
        private System.Windows.Forms.DateTimePicker dependencydateTimePicker;
        private System.Windows.Forms.TextBox depIdtextBox;
        private System.Windows.Forms.Button depcancelbutton;
        private System.Windows.Forms.Button depsavebutton;
        private System.Windows.Forms.Label Created;
        private System.Windows.Forms.Label dep_repselction;
        private System.Windows.Forms.TextBox depNametextBox;
        private System.Windows.Forms.Label DependencyName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Dependency;
        private System.Windows.Forms.ComboBox repselectioncomboBox;
        private System.Windows.Forms.ComboBox dep_repcomboBox1;
        private System.Windows.Forms.TabPage DependencyCmd;
        private System.Windows.Forms.TextBox cmdDepIDtextBox;
        private System.Windows.Forms.DateTimePicker cmdCreateddateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmdDeptextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmdDepUserIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdDepUserSelectioncomboBox;
        private System.Windows.Forms.Button cmdDepCancelbutton;
        private System.Windows.Forms.Button cmdDepSavebutton;
        private System.Windows.Forms.TextBox cmdProjectIDtextBox;
        private System.Windows.Forms.Label cmd_depSelection;
        private System.Windows.Forms.ComboBox cmdProjectSelectioncomboBox1;
    }
}