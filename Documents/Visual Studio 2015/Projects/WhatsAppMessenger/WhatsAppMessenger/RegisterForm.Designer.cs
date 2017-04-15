namespace WhatsAppMessenger
{
    partial class RegisterForm
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.grbRequest = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbConfirm = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbRequest.SuspendLayout();
            this.grbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(241, 71);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // grbRequest
            // 
            this.grbRequest.Controls.Add(this.txtName);
            this.grbRequest.Controls.Add(this.btnRequest);
            this.grbRequest.Controls.Add(this.label2);
            this.grbRequest.Controls.Add(this.txtNumber);
            this.grbRequest.Controls.Add(this.label1);
            this.grbRequest.Location = new System.Drawing.Point(28, 40);
            this.grbRequest.Name = "grbRequest";
            this.grbRequest.Size = new System.Drawing.Size(332, 98);
            this.grbRequest.TabIndex = 1;
            this.grbRequest.TabStop = false;
            this.grbRequest.Text = "Step 1: Request code";
            this.grbRequest.Enter += new System.EventHandler(this.grpRequest_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full name:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(92, 19);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(224, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbConfirm
            // 
            this.grbConfirm.Controls.Add(this.btnConfirm);
            this.grbConfirm.Controls.Add(this.txtSms);
            this.grbConfirm.Controls.Add(this.label4);
            this.grbConfirm.Location = new System.Drawing.Point(28, 155);
            this.grbConfirm.Name = "grbConfirm";
            this.grbConfirm.Size = new System.Drawing.Size(332, 78);
            this.grbConfirm.TabIndex = 1;
            this.grbConfirm.TabStop = false;
            this.grbConfirm.Text = "Step 2: Confirm Sms code";
            this.grbConfirm.Enter += new System.EventHandler(this.grpRequest_Enter);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(241, 45);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSms
            // 
            this.txtSms.Location = new System.Drawing.Point(92, 19);
            this.txtSms.MaxLength = 6;
            this.txtSms.Name = "txtSms";
            this.txtSms.Size = new System.Drawing.Size(224, 20);
            this.txtSms.TabIndex = 0;
            this.txtSms.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sms code:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 255);
            this.Controls.Add(this.grbConfirm);
            this.Controls.Add(this.grbRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.grbRequest.ResumeLayout(false);
            this.grbRequest.PerformLayout();
            this.grbConfirm.ResumeLayout(false);
            this.grbConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox grbRequest;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSms;
        private System.Windows.Forms.Label label4;
    }
}

