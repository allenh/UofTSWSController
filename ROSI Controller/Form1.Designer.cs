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
            this.button1 = new System.Windows.Forms.Button();
            this.pinText = new System.Windows.Forms.TextBox();
            this.sNumText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.TabPage();
            this.ops = new System.Windows.Forms.TabControl();
            this.autoEnrolmentTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.singleCourseButton = new System.Windows.Forms.Button();
            this.singleSectionCodeTextbox = new System.Windows.Forms.TextBox();
            this.singleCourseCodeTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.singleLectureSectionBox = new System.Windows.Forms.TextBox();
            this.general.SuspendLayout();
            this.auth.SuspendLayout();
            this.operation.SuspendLayout();
            this.ops.SuspendLayout();
            this.autoEnrolmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.Controls.Add(this.auth);
            this.general.Controls.Add(this.operation);
            this.general.Location = new System.Drawing.Point(3, -3);
            this.general.Name = "general";
            this.general.SelectedIndex = 0;
            this.general.Size = new System.Drawing.Size(495, 306);
            this.general.TabIndex = 21;
            // 
            // auth
            // 
            this.auth.Controls.Add(this.button1);
            this.auth.Controls.Add(this.pinText);
            this.auth.Controls.Add(this.sNumText);
            this.auth.Controls.Add(this.label2);
            this.auth.Controls.Add(this.label1);
            this.auth.Location = new System.Drawing.Point(4, 22);
            this.auth.Name = "auth";
            this.auth.Padding = new System.Windows.Forms.Padding(3);
            this.auth.Size = new System.Drawing.Size(487, 280);
            this.auth.TabIndex = 0;
            this.auth.Text = "tabPage1";
            this.auth.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(239, 127);
            this.pinText.Name = "pinText";
            this.pinText.PasswordChar = '*';
            this.pinText.Size = new System.Drawing.Size(100, 20);
            this.pinText.TabIndex = 24;
            // 
            // sNumText
            // 
            this.sNumText.Location = new System.Drawing.Point(239, 90);
            this.sNumText.Name = "sNumText";
            this.sNumText.Size = new System.Drawing.Size(100, 20);
            this.sNumText.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 90);
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
            this.operation.Size = new System.Drawing.Size(487, 280);
            this.operation.TabIndex = 1;
            this.operation.Text = "tabPage2";
            this.operation.UseVisualStyleBackColor = true;
            // 
            // ops
            // 
            this.ops.Controls.Add(this.autoEnrolmentTab);
            this.ops.Controls.Add(this.tabPage2);
            this.ops.Location = new System.Drawing.Point(6, 6);
            this.ops.Name = "ops";
            this.ops.SelectedIndex = 0;
            this.ops.Size = new System.Drawing.Size(475, 263);
            this.ops.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.ops.TabIndex = 0;
            // 
            // autoEnrolmentTab
            // 
            this.autoEnrolmentTab.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.autoEnrolmentTab.Size = new System.Drawing.Size(467, 237);
            this.autoEnrolmentTab.TabIndex = 0;
            this.autoEnrolmentTab.Text = "Automatic Single Course Enrolment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lecture Section:";
            // 
            // singleCourseButton
            // 
            this.singleCourseButton.Location = new System.Drawing.Point(144, 160);
            this.singleCourseButton.Name = "singleCourseButton";
            this.singleCourseButton.Size = new System.Drawing.Size(175, 23);
            this.singleCourseButton.TabIndex = 4;
            this.singleCourseButton.Text = "Confirm";
            this.singleCourseButton.UseVisualStyleBackColor = true;
            this.singleCourseButton.Click += new System.EventHandler(this.singleCourseButton_Click);
            // 
            // singleSectionCodeTextbox
            // 
            this.singleSectionCodeTextbox.Location = new System.Drawing.Point(219, 96);
            this.singleSectionCodeTextbox.Name = "singleSectionCodeTextbox";
            this.singleSectionCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.singleSectionCodeTextbox.TabIndex = 3;
            // 
            // singleCourseCodeTextbox
            // 
            this.singleCourseCodeTextbox.Location = new System.Drawing.Point(219, 59);
            this.singleCourseCodeTextbox.Name = "singleCourseCodeTextbox";
            this.singleCourseCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.singleCourseCodeTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Section Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course Code:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // singleLectureSectionBox
            // 
            this.singleLectureSectionBox.Location = new System.Drawing.Point(219, 129);
            this.singleLectureSectionBox.Name = "singleLectureSectionBox";
            this.singleLectureSectionBox.Size = new System.Drawing.Size(100, 20);
            this.singleLectureSectionBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 299);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl general;
        private System.Windows.Forms.TabPage auth;
        private System.Windows.Forms.Button button1;
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



    }
}

