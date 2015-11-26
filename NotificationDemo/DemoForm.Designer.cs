namespace NotificationDemo
{
    partial class DemoForm
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
            this.buttonCreateNotificationIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNotificationIcon
            // 
            this.buttonCreateNotificationIcon.Location = new System.Drawing.Point(81, 74);
            this.buttonCreateNotificationIcon.Name = "buttonCreateNotificationIcon";
            this.buttonCreateNotificationIcon.Size = new System.Drawing.Size(144, 23);
            this.buttonCreateNotificationIcon.TabIndex = 0;
            this.buttonCreateNotificationIcon.Text = "Create Notification Icon";
            this.buttonCreateNotificationIcon.UseVisualStyleBackColor = true;
            this.buttonCreateNotificationIcon.Click += new System.EventHandler(this.buttonCreateNotificationIcon_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCreateNotificationIcon);
            this.Name = "DemoForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNotificationIcon;
    }
}

