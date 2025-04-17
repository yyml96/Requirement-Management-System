namespace _3.View
{
    partial class RequirementViewForm
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
            this.ReqtabControl = new System.Windows.Forms.TabControl();
            this.ReqList = new System.Windows.Forms.TabPage();
            this.reqDeletebutton = new System.Windows.Forms.Button();
            this.reqEditbutton = new System.Windows.Forms.Button();
            this.reqAddbutton = new System.Windows.Forms.Button();
            this.ReqdataGridView = new System.Windows.Forms.DataGridView();
            this.reqSearchbutton = new System.Windows.Forms.Button();
            this.reqSearchtextBox = new System.Windows.Forms.TextBox();
            this.ReqDetail = new System.Windows.Forms.TabPage();
            this.req_projectIDtextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectselectcomboBox1 = new System.Windows.Forms.ComboBox();
            this.reqcreateddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reqStatuscomboBox1 = new System.Windows.Forms.ComboBox();
            this.reqUpdateddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reqIdtextBox1 = new System.Windows.Forms.TextBox();
            this.reqcancelbutton = new System.Windows.Forms.Button();
            this.reqsavebutton = new System.Windows.Forms.Button();
            this.req_updated_at = new System.Windows.Forms.Label();
            this.reqVersiontextBox = new System.Windows.Forms.TextBox();
            this.req_version = new System.Windows.Forms.Label();
            this.req_status = new System.Windows.Forms.Label();
            this.reqNametextBox = new System.Windows.Forms.TextBox();
            this.req_name = new System.Windows.Forms.Label();
            this.ReqCmd = new System.Windows.Forms.TabPage();
            this.cmdReqCancelbutton = new System.Windows.Forms.Button();
            this.cmdReqSavebutton = new System.Windows.Forms.Button();
            this.cmdReqIDtextBox = new System.Windows.Forms.TextBox();
            this.cmdProjectIDtextBox = new System.Windows.Forms.TextBox();
            this.reqSelection = new System.Windows.Forms.Label();
            this.cmd_projectSelection = new System.Windows.Forms.Label();
            this.cmdReqSelectioncomboBox2 = new System.Windows.Forms.ComboBox();
            this.cmdProjectSelectioncomboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Requirement = new System.Windows.Forms.Label();
            this.reqCommentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdUserSelectioncomboBox = new System.Windows.Forms.ComboBox();
            this.cmdUserIDtextBox = new System.Windows.Forms.TextBox();
            this.cmdReqtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCreateddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdIDtextBox = new System.Windows.Forms.TextBox();
            this.ReqtabControl.SuspendLayout();
            this.ReqList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqdataGridView)).BeginInit();
            this.ReqDetail.SuspendLayout();
            this.ReqCmd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReqtabControl
            // 
            this.ReqtabControl.Controls.Add(this.ReqList);
            this.ReqtabControl.Controls.Add(this.ReqDetail);
            this.ReqtabControl.Controls.Add(this.ReqCmd);
            this.ReqtabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReqtabControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqtabControl.Location = new System.Drawing.Point(0, 133);
            this.ReqtabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReqtabControl.Name = "ReqtabControl";
            this.ReqtabControl.SelectedIndex = 0;
            this.ReqtabControl.Size = new System.Drawing.Size(1648, 963);
            this.ReqtabControl.TabIndex = 8;
            // 
            // ReqList
            // 
            this.ReqList.Controls.Add(this.reqCommentButton);
            this.ReqList.Controls.Add(this.reqDeletebutton);
            this.ReqList.Controls.Add(this.reqEditbutton);
            this.ReqList.Controls.Add(this.reqAddbutton);
            this.ReqList.Controls.Add(this.ReqdataGridView);
            this.ReqList.Controls.Add(this.reqSearchbutton);
            this.ReqList.Controls.Add(this.reqSearchtextBox);
            this.ReqList.Location = new System.Drawing.Point(8, 50);
            this.ReqList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReqList.Name = "ReqList";
            this.ReqList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReqList.Size = new System.Drawing.Size(1632, 905);
            this.ReqList.TabIndex = 0;
            this.ReqList.Text = "Requirement List";
            this.ReqList.UseVisualStyleBackColor = true;
            // 
            // reqDeletebutton
            // 
            this.reqDeletebutton.Location = new System.Drawing.Point(1413, 365);
            this.reqDeletebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqDeletebutton.Name = "reqDeletebutton";
            this.reqDeletebutton.Size = new System.Drawing.Size(172, 69);
            this.reqDeletebutton.TabIndex = 5;
            this.reqDeletebutton.Text = "Delete";
            this.reqDeletebutton.UseVisualStyleBackColor = true;
            // 
            // reqEditbutton
            // 
            this.reqEditbutton.Location = new System.Drawing.Point(1413, 262);
            this.reqEditbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqEditbutton.Name = "reqEditbutton";
            this.reqEditbutton.Size = new System.Drawing.Size(172, 69);
            this.reqEditbutton.TabIndex = 4;
            this.reqEditbutton.Text = "Edit";
            this.reqEditbutton.UseVisualStyleBackColor = true;
            // 
            // reqAddbutton
            // 
            this.reqAddbutton.Location = new System.Drawing.Point(1413, 162);
            this.reqAddbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqAddbutton.Name = "reqAddbutton";
            this.reqAddbutton.Size = new System.Drawing.Size(172, 69);
            this.reqAddbutton.TabIndex = 3;
            this.reqAddbutton.Text = "Add new";
            this.reqAddbutton.UseVisualStyleBackColor = true;
            // 
            // ReqdataGridView
            // 
            this.ReqdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReqdataGridView.Location = new System.Drawing.Point(30, 159);
            this.ReqdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReqdataGridView.Name = "ReqdataGridView";
            this.ReqdataGridView.RowHeadersWidth = 82;
            this.ReqdataGridView.RowTemplate.Height = 24;
            this.ReqdataGridView.Size = new System.Drawing.Size(1354, 686);
            this.ReqdataGridView.TabIndex = 2;
            // 
            // reqSearchbutton
            // 
            this.reqSearchbutton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqSearchbutton.Location = new System.Drawing.Point(1413, 48);
            this.reqSearchbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqSearchbutton.Name = "reqSearchbutton";
            this.reqSearchbutton.Size = new System.Drawing.Size(172, 69);
            this.reqSearchbutton.TabIndex = 1;
            this.reqSearchbutton.Text = "Search";
            this.reqSearchbutton.UseVisualStyleBackColor = true;
            // 
            // reqSearchtextBox
            // 
            this.reqSearchtextBox.Location = new System.Drawing.Point(30, 48);
            this.reqSearchtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqSearchtextBox.Name = "reqSearchtextBox";
            this.reqSearchtextBox.Size = new System.Drawing.Size(1354, 44);
            this.reqSearchtextBox.TabIndex = 0;
            // 
            // ReqDetail
            // 
            this.ReqDetail.Controls.Add(this.req_projectIDtextBox1);
            this.ReqDetail.Controls.Add(this.label1);
            this.ReqDetail.Controls.Add(this.ProjectselectcomboBox1);
            this.ReqDetail.Controls.Add(this.reqcreateddateTimePicker1);
            this.ReqDetail.Controls.Add(this.reqStatuscomboBox1);
            this.ReqDetail.Controls.Add(this.reqUpdateddateTimePicker1);
            this.ReqDetail.Controls.Add(this.reqIdtextBox1);
            this.ReqDetail.Controls.Add(this.reqcancelbutton);
            this.ReqDetail.Controls.Add(this.reqsavebutton);
            this.ReqDetail.Controls.Add(this.req_updated_at);
            this.ReqDetail.Controls.Add(this.reqVersiontextBox);
            this.ReqDetail.Controls.Add(this.req_version);
            this.ReqDetail.Controls.Add(this.req_status);
            this.ReqDetail.Controls.Add(this.reqNametextBox);
            this.ReqDetail.Controls.Add(this.req_name);
            this.ReqDetail.Location = new System.Drawing.Point(8, 50);
            this.ReqDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReqDetail.Name = "ReqDetail";
            this.ReqDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReqDetail.Size = new System.Drawing.Size(1632, 905);
            this.ReqDetail.TabIndex = 1;
            this.ReqDetail.Text = "Requirement Detail";
            this.ReqDetail.UseVisualStyleBackColor = true;
            // 
            // req_projectIDtextBox1
            // 
            this.req_projectIDtextBox1.Location = new System.Drawing.Point(553, 206);
            this.req_projectIDtextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.req_projectIDtextBox1.Name = "req_projectIDtextBox1";
            this.req_projectIDtextBox1.Size = new System.Drawing.Size(94, 44);
            this.req_projectIDtextBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Project";
            // 
            // ProjectselectcomboBox1
            // 
            this.ProjectselectcomboBox1.FormattingEnabled = true;
            this.ProjectselectcomboBox1.Location = new System.Drawing.Point(124, 206);
            this.ProjectselectcomboBox1.Name = "ProjectselectcomboBox1";
            this.ProjectselectcomboBox1.Size = new System.Drawing.Size(379, 44);
            this.ProjectselectcomboBox1.TabIndex = 16;
            // 
            // reqcreateddateTimePicker1
            // 
            this.reqcreateddateTimePicker1.Location = new System.Drawing.Point(1002, 125);
            this.reqcreateddateTimePicker1.Name = "reqcreateddateTimePicker1";
            this.reqcreateddateTimePicker1.Size = new System.Drawing.Size(534, 44);
            this.reqcreateddateTimePicker1.TabIndex = 15;
            // 
            // reqStatuscomboBox1
            // 
            this.reqStatuscomboBox1.FormattingEnabled = true;
            this.reqStatuscomboBox1.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.reqStatuscomboBox1.Location = new System.Drawing.Point(720, 381);
            this.reqStatuscomboBox1.Name = "reqStatuscomboBox1";
            this.reqStatuscomboBox1.Size = new System.Drawing.Size(199, 44);
            this.reqStatuscomboBox1.TabIndex = 14;
            // 
            // reqUpdateddateTimePicker1
            // 
            this.reqUpdateddateTimePicker1.Location = new System.Drawing.Point(712, 578);
            this.reqUpdateddateTimePicker1.Name = "reqUpdateddateTimePicker1";
            this.reqUpdateddateTimePicker1.Size = new System.Drawing.Size(534, 44);
            this.reqUpdateddateTimePicker1.TabIndex = 13;
            // 
            // reqIdtextBox1
            // 
            this.reqIdtextBox1.Location = new System.Drawing.Point(1002, 206);
            this.reqIdtextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqIdtextBox1.Name = "reqIdtextBox1";
            this.reqIdtextBox1.Size = new System.Drawing.Size(182, 44);
            this.reqIdtextBox1.TabIndex = 12;
            this.reqIdtextBox1.Text = "0";
            // 
            // reqcancelbutton
            // 
            this.reqcancelbutton.Location = new System.Drawing.Point(519, 725);
            this.reqcancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqcancelbutton.Name = "reqcancelbutton";
            this.reqcancelbutton.Size = new System.Drawing.Size(322, 128);
            this.reqcancelbutton.TabIndex = 11;
            this.reqcancelbutton.Text = "Cancel";
            this.reqcancelbutton.UseVisualStyleBackColor = true;
            // 
            // reqsavebutton
            // 
            this.reqsavebutton.Location = new System.Drawing.Point(124, 725);
            this.reqsavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqsavebutton.Name = "reqsavebutton";
            this.reqsavebutton.Size = new System.Drawing.Size(322, 128);
            this.reqsavebutton.TabIndex = 10;
            this.reqsavebutton.Text = "Save";
            this.reqsavebutton.UseVisualStyleBackColor = true;
            // 
            // req_updated_at
            // 
            this.req_updated_at.AutoSize = true;
            this.req_updated_at.Location = new System.Drawing.Point(704, 491);
            this.req_updated_at.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.req_updated_at.Name = "req_updated_at";
            this.req_updated_at.Size = new System.Drawing.Size(207, 36);
            this.req_updated_at.TabIndex = 8;
            this.req_updated_at.Text = "Updated Date";
            // 
            // reqVersiontextBox
            // 
            this.reqVersiontextBox.Location = new System.Drawing.Point(124, 578);
            this.reqVersiontextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqVersiontextBox.Name = "reqVersiontextBox";
            this.reqVersiontextBox.Size = new System.Drawing.Size(439, 44);
            this.reqVersiontextBox.TabIndex = 7;
            // 
            // req_version
            // 
            this.req_version.AutoSize = true;
            this.req_version.Location = new System.Drawing.Point(128, 491);
            this.req_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.req_version.Name = "req_version";
            this.req_version.Size = new System.Drawing.Size(120, 36);
            this.req_version.TabIndex = 6;
            this.req_version.Text = "Version";
            // 
            // req_status
            // 
            this.req_status.AutoSize = true;
            this.req_status.Location = new System.Drawing.Point(716, 294);
            this.req_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.req_status.Name = "req_status";
            this.req_status.Size = new System.Drawing.Size(105, 36);
            this.req_status.TabIndex = 4;
            this.req_status.Text = "Status";
            // 
            // reqNametextBox
            // 
            this.reqNametextBox.Location = new System.Drawing.Point(124, 381);
            this.reqNametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqNametextBox.Name = "reqNametextBox";
            this.reqNametextBox.Size = new System.Drawing.Size(439, 44);
            this.reqNametextBox.TabIndex = 3;
            // 
            // req_name
            // 
            this.req_name.AutoSize = true;
            this.req_name.Location = new System.Drawing.Point(128, 294);
            this.req_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.req_name.Name = "req_name";
            this.req_name.Size = new System.Drawing.Size(289, 36);
            this.req_name.TabIndex = 2;
            this.req_name.Text = "Requirement Name";
            // 
            // ReqCmd
            // 
            this.ReqCmd.Controls.Add(this.cmdIDtextBox);
            this.ReqCmd.Controls.Add(this.cmdCreateddateTimePicker);
            this.ReqCmd.Controls.Add(this.label4);
            this.ReqCmd.Controls.Add(this.cmdReqtextBox);
            this.ReqCmd.Controls.Add(this.label3);
            this.ReqCmd.Controls.Add(this.cmdUserIDtextBox);
            this.ReqCmd.Controls.Add(this.label2);
            this.ReqCmd.Controls.Add(this.cmdUserSelectioncomboBox);
            this.ReqCmd.Controls.Add(this.cmdReqCancelbutton);
            this.ReqCmd.Controls.Add(this.cmdReqSavebutton);
            this.ReqCmd.Controls.Add(this.cmdReqIDtextBox);
            this.ReqCmd.Controls.Add(this.cmdProjectIDtextBox);
            this.ReqCmd.Controls.Add(this.reqSelection);
            this.ReqCmd.Controls.Add(this.cmd_projectSelection);
            this.ReqCmd.Controls.Add(this.cmdReqSelectioncomboBox2);
            this.ReqCmd.Controls.Add(this.cmdProjectSelectioncomboBox1);
            this.ReqCmd.Location = new System.Drawing.Point(8, 50);
            this.ReqCmd.Name = "ReqCmd";
            this.ReqCmd.Size = new System.Drawing.Size(1632, 905);
            this.ReqCmd.TabIndex = 2;
            this.ReqCmd.Text = "Requirement Comment";
            this.ReqCmd.UseVisualStyleBackColor = true;
            // 
            // cmdReqCancelbutton
            // 
            this.cmdReqCancelbutton.Location = new System.Drawing.Point(582, 708);
            this.cmdReqCancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdReqCancelbutton.Name = "cmdReqCancelbutton";
            this.cmdReqCancelbutton.Size = new System.Drawing.Size(322, 128);
            this.cmdReqCancelbutton.TabIndex = 16;
            this.cmdReqCancelbutton.Text = "Cancel";
            this.cmdReqCancelbutton.UseVisualStyleBackColor = true;
            // 
            // cmdReqSavebutton
            // 
            this.cmdReqSavebutton.Location = new System.Drawing.Point(196, 708);
            this.cmdReqSavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdReqSavebutton.Name = "cmdReqSavebutton";
            this.cmdReqSavebutton.Size = new System.Drawing.Size(322, 128);
            this.cmdReqSavebutton.TabIndex = 15;
            this.cmdReqSavebutton.Text = "Save";
            this.cmdReqSavebutton.UseVisualStyleBackColor = true;
            // 
            // cmdReqIDtextBox
            // 
            this.cmdReqIDtextBox.Location = new System.Drawing.Point(1271, 176);
            this.cmdReqIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdReqIDtextBox.Name = "cmdReqIDtextBox";
            this.cmdReqIDtextBox.Size = new System.Drawing.Size(88, 44);
            this.cmdReqIDtextBox.TabIndex = 14;
            // 
            // cmdProjectIDtextBox
            // 
            this.cmdProjectIDtextBox.Location = new System.Drawing.Point(31, 176);
            this.cmdProjectIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdProjectIDtextBox.Name = "cmdProjectIDtextBox";
            this.cmdProjectIDtextBox.Size = new System.Drawing.Size(94, 44);
            this.cmdProjectIDtextBox.TabIndex = 13;
            // 
            // reqSelection
            // 
            this.reqSelection.AutoSize = true;
            this.reqSelection.Location = new System.Drawing.Point(817, 95);
            this.reqSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reqSelection.Name = "reqSelection";
            this.reqSelection.Size = new System.Drawing.Size(292, 36);
            this.reqSelection.TabIndex = 4;
            this.reqSelection.Text = "Select Requirement";
            // 
            // cmd_projectSelection
            // 
            this.cmd_projectSelection.AutoSize = true;
            this.cmd_projectSelection.Location = new System.Drawing.Point(179, 95);
            this.cmd_projectSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmd_projectSelection.Name = "cmd_projectSelection";
            this.cmd_projectSelection.Size = new System.Drawing.Size(209, 36);
            this.cmd_projectSelection.TabIndex = 3;
            this.cmd_projectSelection.Text = "Select Project";
            // 
            // cmdReqSelectioncomboBox2
            // 
            this.cmdReqSelectioncomboBox2.FormattingEnabled = true;
            this.cmdReqSelectioncomboBox2.Location = new System.Drawing.Point(823, 176);
            this.cmdReqSelectioncomboBox2.Name = "cmdReqSelectioncomboBox2";
            this.cmdReqSelectioncomboBox2.Size = new System.Drawing.Size(410, 44);
            this.cmdReqSelectioncomboBox2.TabIndex = 1;
            // 
            // cmdProjectSelectioncomboBox1
            // 
            this.cmdProjectSelectioncomboBox1.FormattingEnabled = true;
            this.cmdProjectSelectioncomboBox1.Location = new System.Drawing.Point(185, 176);
            this.cmdProjectSelectioncomboBox1.Name = "cmdProjectSelectioncomboBox1";
            this.cmdProjectSelectioncomboBox1.Size = new System.Drawing.Size(379, 44);
            this.cmdProjectSelectioncomboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Requirement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1648, 133);
            this.panel1.TabIndex = 7;
            // 
            // Requirement
            // 
            this.Requirement.AutoSize = true;
            this.Requirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requirement.Location = new System.Drawing.Point(32, 34);
            this.Requirement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Requirement.Name = "Requirement";
            this.Requirement.Size = new System.Drawing.Size(231, 42);
            this.Requirement.TabIndex = 0;
            this.Requirement.Text = "Requirement";
            // 
            // reqCommentButton
            // 
            this.reqCommentButton.Location = new System.Drawing.Point(1413, 472);
            this.reqCommentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reqCommentButton.Name = "reqCommentButton";
            this.reqCommentButton.Size = new System.Drawing.Size(172, 69);
            this.reqCommentButton.TabIndex = 6;
            this.reqCommentButton.Text = "Comment";
            this.reqCommentButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select User";
            // 
            // cmdUserSelectioncomboBox
            // 
            this.cmdUserSelectioncomboBox.FormattingEnabled = true;
            this.cmdUserSelectioncomboBox.Location = new System.Drawing.Point(185, 373);
            this.cmdUserSelectioncomboBox.Name = "cmdUserSelectioncomboBox";
            this.cmdUserSelectioncomboBox.Size = new System.Drawing.Size(379, 44);
            this.cmdUserSelectioncomboBox.TabIndex = 17;
            // 
            // cmdUserIDtextBox
            // 
            this.cmdUserIDtextBox.Location = new System.Drawing.Point(31, 373);
            this.cmdUserIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdUserIDtextBox.Name = "cmdUserIDtextBox";
            this.cmdUserIDtextBox.Size = new System.Drawing.Size(94, 44);
            this.cmdUserIDtextBox.TabIndex = 19;
            // 
            // cmdReqtextBox
            // 
            this.cmdReqtextBox.Location = new System.Drawing.Point(823, 373);
            this.cmdReqtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdReqtextBox.Name = "cmdReqtextBox";
            this.cmdReqtextBox.Size = new System.Drawing.Size(439, 44);
            this.cmdReqtextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Comment";
            // 
            // cmdCreateddateTimePicker
            // 
            this.cmdCreateddateTimePicker.Location = new System.Drawing.Point(185, 556);
            this.cmdCreateddateTimePicker.Name = "cmdCreateddateTimePicker";
            this.cmdCreateddateTimePicker.Size = new System.Drawing.Size(534, 44);
            this.cmdCreateddateTimePicker.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Created Date";
            // 
            // cmdIDtextBox
            // 
            this.cmdIDtextBox.Location = new System.Drawing.Point(816, 556);
            this.cmdIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdIDtextBox.Name = "cmdIDtextBox";
            this.cmdIDtextBox.Size = new System.Drawing.Size(88, 44);
            this.cmdIDtextBox.TabIndex = 24;
            this.cmdIDtextBox.Text = "0";
            // 
            // RequirementViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 1096);
            this.Controls.Add(this.ReqtabControl);
            this.Controls.Add(this.panel1);
            this.Name = "RequirementViewForm";
            this.Text = "RequirementViewForm";
            this.ReqtabControl.ResumeLayout(false);
            this.ReqList.ResumeLayout(false);
            this.ReqList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqdataGridView)).EndInit();
            this.ReqDetail.ResumeLayout(false);
            this.ReqDetail.PerformLayout();
            this.ReqCmd.ResumeLayout(false);
            this.ReqCmd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ReqtabControl;
        private System.Windows.Forms.TabPage ReqList;
        private System.Windows.Forms.Button reqDeletebutton;
        private System.Windows.Forms.Button reqEditbutton;
        private System.Windows.Forms.Button reqAddbutton;
        private System.Windows.Forms.DataGridView ReqdataGridView;
        private System.Windows.Forms.Button reqSearchbutton;
        private System.Windows.Forms.TextBox reqSearchtextBox;
        private System.Windows.Forms.TabPage ReqDetail;
        private System.Windows.Forms.TextBox reqIdtextBox1;
        private System.Windows.Forms.Button reqcancelbutton;
        private System.Windows.Forms.Button reqsavebutton;
        private System.Windows.Forms.Label req_updated_at;
        private System.Windows.Forms.TextBox reqVersiontextBox;
        private System.Windows.Forms.Label req_version;
        private System.Windows.Forms.Label req_status;
        private System.Windows.Forms.TextBox reqNametextBox;
        private System.Windows.Forms.Label req_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Requirement;
        private System.Windows.Forms.ComboBox reqStatuscomboBox1;
        private System.Windows.Forms.DateTimePicker reqUpdateddateTimePicker1;
        private System.Windows.Forms.TabPage ReqCmd;
        private System.Windows.Forms.Button cmdReqCancelbutton;
        private System.Windows.Forms.Button cmdReqSavebutton;
        private System.Windows.Forms.TextBox cmdReqIDtextBox;
        private System.Windows.Forms.TextBox cmdProjectIDtextBox;
        private System.Windows.Forms.Label reqSelection;
        private System.Windows.Forms.Label cmd_projectSelection;
        private System.Windows.Forms.ComboBox cmdReqSelectioncomboBox2;
        private System.Windows.Forms.ComboBox cmdProjectSelectioncomboBox1;
        private System.Windows.Forms.DateTimePicker reqcreateddateTimePicker1;
        private System.Windows.Forms.TextBox req_projectIDtextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjectselectcomboBox1;
        private System.Windows.Forms.Button reqCommentButton;
        private System.Windows.Forms.TextBox cmdReqtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmdUserIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdUserSelectioncomboBox;
        private System.Windows.Forms.DateTimePicker cmdCreateddateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmdIDtextBox;
    }
}