namespace ROSI_Controller
{
    partial class Form1
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
            this.general = new System.Windows.Forms.TabControl();
            this.auth = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.pinText = new System.Windows.Forms.TextBox();
            this.sNumText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.TabPage();
            this.ops = new System.Windows.Forms.TabControl();
            this.autoEnrolmentTab = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.singleLectureSectionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.singleCourseButton = new System.Windows.Forms.Button();
            this.singleSectionCodeTextbox = new System.Windows.Forms.TextBox();
            this.singleCourseCodeTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.multiConfirm = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.general.SuspendLayout();
            this.auth.SuspendLayout();
            this.operation.SuspendLayout();
            this.ops.SuspendLayout();
            this.autoEnrolmentTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.Controls.Add(this.auth);
            this.general.Controls.Add(this.operation);
            this.general.Location = new System.Drawing.Point(-14, -23);
            this.general.Name = "general";
            this.general.SelectedIndex = 0;
            this.general.Size = new System.Drawing.Size(617, 409);
            this.general.TabIndex = 21;
            // 
            // auth
            // 
            this.auth.Controls.Add(this.loginButton);
            this.auth.Controls.Add(this.pinText);
            this.auth.Controls.Add(this.sNumText);
            this.auth.Controls.Add(this.label2);
            this.auth.Controls.Add(this.label1);
            this.auth.Location = new System.Drawing.Point(4, 22);
            this.auth.Name = "auth";
            this.auth.Padding = new System.Windows.Forms.Padding(3);
            this.auth.Size = new System.Drawing.Size(609, 383);
            this.auth.TabIndex = 0;
            this.auth.Text = "tabPage1";
            this.auth.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(257, 197);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 25;
            this.loginButton.Text = "Confirm";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(288, 158);
            this.pinText.Name = "pinText";
            this.pinText.PasswordChar = '*';
            this.pinText.Size = new System.Drawing.Size(100, 20);
            this.pinText.TabIndex = 24;
            // 
            // sNumText
            // 
            this.sNumText.Location = new System.Drawing.Point(288, 121);
            this.sNumText.Name = "sNumText";
            this.sNumText.Size = new System.Drawing.Size(100, 20);
            this.sNumText.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student Number";
            // 
            // operation
            // 
            this.operation.Controls.Add(this.ops);
            this.operation.Location = new System.Drawing.Point(4, 22);
            this.operation.Name = "operation";
            this.operation.Padding = new System.Windows.Forms.Padding(3);
            this.operation.Size = new System.Drawing.Size(609, 383);
            this.operation.TabIndex = 1;
            this.operation.Text = "tabPage2";
            this.operation.UseVisualStyleBackColor = true;
            // 
            // ops
            // 
            this.ops.Controls.Add(this.autoEnrolmentTab);
            this.ops.Controls.Add(this.tabPage2);
            this.ops.Location = new System.Drawing.Point(6, 3);
            this.ops.Name = "ops";
            this.ops.SelectedIndex = 0;
            this.ops.Size = new System.Drawing.Size(587, 367);
            this.ops.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.ops.TabIndex = 0;
            // 
            // autoEnrolmentTab
            // 
            this.autoEnrolmentTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.autoEnrolmentTab.Controls.Add(this.checkBox1);
            this.autoEnrolmentTab.Controls.Add(this.singleLectureSectionBox);
            this.autoEnrolmentTab.Controls.Add(this.label5);
            this.autoEnrolmentTab.Controls.Add(this.singleCourseButton);
            this.autoEnrolmentTab.Controls.Add(this.singleSectionCodeTextbox);
            this.autoEnrolmentTab.Controls.Add(this.singleCourseCodeTextbox);
            this.autoEnrolmentTab.Controls.Add(this.label4);
            this.autoEnrolmentTab.Controls.Add(this.label3);
            this.autoEnrolmentTab.Location = new System.Drawing.Point(4, 22);
            this.autoEnrolmentTab.Name = "autoEnrolmentTab";
            this.autoEnrolmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.autoEnrolmentTab.Size = new System.Drawing.Size(579, 341);
            this.autoEnrolmentTab.TabIndex = 0;
            this.autoEnrolmentTab.Text = "Automatic Single Course Enrolment";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(201, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Continuous attempting to enroll";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // singleLectureSectionBox
            // 
            this.singleLectureSectionBox.Location = new System.Drawing.Point(276, 136);
            this.singleLectureSectionBox.Name = "singleLectureSectionBox";
            this.singleLectureSectionBox.Size = new System.Drawing.Size(100, 20);
            this.singleLectureSectionBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lecture Section:";
            // 
            // singleCourseButton
            // 
            this.singleCourseButton.Location = new System.Drawing.Point(228, 205);
            this.singleCourseButton.Name = "singleCourseButton";
            this.singleCourseButton.Size = new System.Drawing.Size(113, 23);
            this.singleCourseButton.TabIndex = 4;
            this.singleCourseButton.Text = "Confirm";
            this.singleCourseButton.UseVisualStyleBackColor = true;
            this.singleCourseButton.Click += new System.EventHandler(this.singleCourseButton_Click);
            // 
            // singleSectionCodeTextbox
            // 
            this.singleSectionCodeTextbox.Location = new System.Drawing.Point(276, 103);
            this.singleSectionCodeTextbox.Name = "singleSectionCodeTextbox";
            this.singleSectionCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.singleSectionCodeTextbox.TabIndex = 3;
            // 
            // singleCourseCodeTextbox
            // 
            this.singleCourseCodeTextbox.Location = new System.Drawing.Point(276, 69);
            this.singleCourseCodeTextbox.Name = "singleCourseCodeTextbox";
            this.singleCourseCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.singleCourseCodeTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Section Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course Code:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.multiConfirm);
            this.tabPage2.Controls.Add(this.add);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Automatic Multiple Course Enrolment";
            // 
            // multiConfirm
            // 
            this.multiConfirm.Location = new System.Drawing.Point(491, 58);
            this.multiConfirm.Name = "multiConfirm";
            this.multiConfirm.Size = new System.Drawing.Size(75, 23);
            this.multiConfirm.TabIndex = 2;
            this.multiConfirm.Text = "Confirm";
            this.multiConfirm.UseVisualStyleBackColor = true;
            this.multiConfirm.Click += new System.EventHandler(this.multiConfirm_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(492, 15);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Add Course";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 333);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 369);
            this.Controls.Add(this.general);
            this.Name = "Form1";
            this.Text = "Form1";
            this.general.ResumeLayout(false);
            this.auth.ResumeLayout(false);
            this.auth.PerformLayout();
            this.operation.ResumeLayout(false);
            this.ops.ResumeLayout(false);
            this.autoEnrolmentTab.ResumeLayout(false);
            this.autoEnrolmentTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl general;
        private System.Windows.Forms.TabPage auth;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox pinText;
        private System.Windows.Forms.TextBox sNumText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage operation;
        private System.Windows.Forms.TabControl ops;
        private System.Windows.Forms.TabPage autoEnrolmentTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox singleSectionCodeTextbox;
        private System.Windows.Forms.TextBox singleCourseCodeTextbox;
        private System.Windows.Forms.Button singleCourseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox singleLectureSectionBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button multiConfirm;
        private System.Windows.Forms.CheckBox checkBox1;



    }
}

