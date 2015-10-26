namespace RedasTools
{
    partial class CopyInstanceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(160, 57);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "执行操作的用户ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(160, 99);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 21);
            this.txtUserId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "待拷贝的表单ID";
            // 
            // txtFormId
            // 
            this.txtFormId.Location = new System.Drawing.Point(160, 136);
            this.txtFormId.Name = "txtFormId";
            this.txtFormId.Size = new System.Drawing.Size(100, 21);
            this.txtFormId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "执行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 63);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "说明：填写需要复制表单到哪个公司，执行复制表单的用户id，需要拷贝的表单id，点击执行按钮";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "登录用户ID";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(160, 7);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(100, 21);
            this.txtLoginId.TabIndex = 6;
            this.txtLoginId.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.ForeColor = System.Drawing.Color.Red;
            this.lblUserInfo.Location = new System.Drawing.Point(37, 32);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(0, 12);
            this.lblUserInfo.TabIndex = 7;
            // 
            // CopyInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 341);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFormId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.Name = "CopyInstanceForm";
            this.Text = "CopyInstanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFormId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label lblUserInfo;
    }
}