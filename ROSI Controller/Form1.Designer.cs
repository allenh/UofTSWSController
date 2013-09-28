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
            this.general.SuspendLayout();
            this.auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.Controls.Add(this.auth);
            this.general.Controls.Add(this.operation);
            this.general.Location = new System.Drawing.Point(3, -3);
            this.general.Name = "general";
            this.general.SelectedIndex = 0;
            this.general.Size = new System.Drawing.Size(607, 363);
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
            this.auth.Size = new System.Drawing.Size(599, 337);
            this.auth.TabIndex = 0;
            this.auth.Text = "tabPage1";
            this.auth.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(288, 156);
            this.pinText.Name = "pinText";
            this.pinText.Size = new System.Drawing.Size(100, 20);
            this.pinText.TabIndex = 24;
            // 
            // sNumText
            // 
            this.sNumText.Location = new System.Drawing.Point(288, 119);
            this.sNumText.Name = "sNumText";
            this.sNumText.Size = new System.Drawing.Size(100, 20);
            this.sNumText.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student Number";
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(4, 22);
            this.operation.Name = "operation";
            this.operation.Padding = new System.Windows.Forms.Padding(3);
            this.operation.Size = new System.Drawing.Size(599, 337);
            this.operation.TabIndex = 1;
            this.operation.Text = "tabPage2";
            this.operation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.general);
            this.Name = "Form1";
            this.Text = "Form1";
            this.general.ResumeLayout(false);
            this.auth.ResumeLayout(false);
            this.auth.PerformLayout();
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



    }
}

