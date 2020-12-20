namespace NetcatApplication
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
            this.rxTextBox = new System.Windows.Forms.RichTextBox();
            this.txTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RAddressText = new System.Windows.Forms.TextBox();
            this.RPortText = new System.Windows.Forms.TextBox();
            this.LPortText = new System.Windows.Forms.TextBox();
            this.roleList = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rxTextBox
            // 
            this.rxTextBox.Location = new System.Drawing.Point(13, 13);
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.Size = new System.Drawing.Size(550, 447);
            this.rxTextBox.TabIndex = 0;
            this.rxTextBox.Text = "";
            // 
            // txTextBox
            // 
            this.txTextBox.Location = new System.Drawing.Point(13, 466);
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.Size = new System.Drawing.Size(550, 30);
            this.txTextBox.TabIndex = 1;
            this.txTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remote Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remote Port: (Client Only)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local Port: (Server Only)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Role:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RAddressText
            // 
            this.RAddressText.Location = new System.Drawing.Point(569, 36);
            this.RAddressText.Name = "RAddressText";
            this.RAddressText.Size = new System.Drawing.Size(100, 22);
            this.RAddressText.TabIndex = 6;
            // 
            // RPortText
            // 
            this.RPortText.Location = new System.Drawing.Point(569, 89);
            this.RPortText.Name = "RPortText";
            this.RPortText.Size = new System.Drawing.Size(100, 22);
            this.RPortText.TabIndex = 7;
            // 
            // LPortText
            // 
            this.LPortText.Location = new System.Drawing.Point(569, 145);
            this.LPortText.Name = "LPortText";
            this.LPortText.Size = new System.Drawing.Size(100, 22);
            this.LPortText.TabIndex = 8;
            // 
            // roleList
            // 
            this.roleList.FormattingEnabled = true;
            this.roleList.ItemHeight = 16;
            this.roleList.Items.AddRange(new object[] {
            "UdpServer",
            "UdpClient",
            "TcpServer",
            "TcpClient"});
            this.roleList.Location = new System.Drawing.Point(569, 201);
            this.roleList.Name = "roleList";
            this.roleList.Size = new System.Drawing.Size(120, 84);
            this.roleList.TabIndex = 10;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(572, 324);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 34);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(572, 466);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(120, 28);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(572, 384);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(120, 34);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 508);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.roleList);
            this.Controls.Add(this.LPortText);
            this.Controls.Add(this.RPortText);
            this.Controls.Add(this.RAddressText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTextBox);
            this.Controls.Add(this.rxTextBox);
            this.Name = "Form1";
            this.Text = "Windows Netcat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rxTextBox;
        private System.Windows.Forms.RichTextBox txTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RAddressText;
        private System.Windows.Forms.TextBox RPortText;
        private System.Windows.Forms.TextBox LPortText;
        private System.Windows.Forms.ListBox roleList;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button quitButton;
    }
}

