
namespace Cs_AplikacjaKliencka
{
    partial class loggedForm
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
            this.sendButton = new System.Windows.Forms.Button();
            this.cashinRadioB = new System.Windows.Forms.RadioButton();
            this.logoutButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.withdrawRadioB = new System.Windows.Forms.RadioButton();
            this.moneyAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(15, 183);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashinRadioB
            // 
            this.cashinRadioB.AutoSize = true;
            this.cashinRadioB.Location = new System.Drawing.Point(30, 137);
            this.cashinRadioB.Name = "cashinRadioB";
            this.cashinRadioB.Size = new System.Drawing.Size(63, 17);
            this.cashinRadioB.TabIndex = 1;
            this.cashinRadioB.TabStop = true;
            this.cashinRadioB.Text = "Cash in ";
            this.cashinRadioB.UseVisualStyleBackColor = true;
            this.cashinRadioB.CheckedChanged += new System.EventHandler(this.cashinRadioB_CheckedChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(104, 183);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(185, 183);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(75, 23);
            this.leaveButton.TabIndex = 3;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // withdrawRadioB
            // 
            this.withdrawRadioB.AutoSize = true;
            this.withdrawRadioB.Location = new System.Drawing.Point(30, 114);
            this.withdrawRadioB.Name = "withdrawRadioB";
            this.withdrawRadioB.Size = new System.Drawing.Size(99, 17);
            this.withdrawRadioB.TabIndex = 4;
            this.withdrawRadioB.TabStop = true;
            this.withdrawRadioB.Text = "Withdraw funds";
            this.withdrawRadioB.UseVisualStyleBackColor = true;
            this.withdrawRadioB.CheckedChanged += new System.EventHandler(this.withdrawRadioB_CheckedChanged);
            // 
            // moneyAmount
            // 
            this.moneyAmount.Location = new System.Drawing.Point(79, 78);
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.Size = new System.Drawing.Size(100, 20);
            this.moneyAmount.TabIndex = 5;
            this.moneyAmount.Text = "500";
            this.moneyAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please select what you\'d like to do with your funds ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "and click Send to confirm the operation.";
            // 
            // loggedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneyAmount);
            this.Controls.Add(this.withdrawRadioB);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.cashinRadioB);
            this.Controls.Add(this.sendButton);
            this.Name = "loggedForm";
            this.Text = "Turbo Hyper Banker Client 0.621";
            this.Load += new System.EventHandler(this.loggedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RadioButton cashinRadioB;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.RadioButton withdrawRadioB;
        private System.Windows.Forms.TextBox moneyAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}