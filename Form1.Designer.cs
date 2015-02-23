namespace C__First_Windows_Form_5
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
            this.btnDisplayMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayMessage
            // 
            this.btnDisplayMessage.Location = new System.Drawing.Point(92, 66);
            this.btnDisplayMessage.Name = "btnDisplayMessage";
            this.btnDisplayMessage.Size = new System.Drawing.Size(100, 30);
            this.btnDisplayMessage.TabIndex = 0;
            this.btnDisplayMessage.Text = "A Message";
            this.btnDisplayMessage.UseVisualStyleBackColor = true;
            this.btnDisplayMessage.Click += new System.EventHandler(this.btnDisplayMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.btnDisplayMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayMessage;
    }
}

