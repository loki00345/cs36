﻿namespace cs36_1_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            lblResponse = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(303, 246);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(217, 23);
            btnSend.TabIndex = 0;
            btnSend.Text = "Відправити повідомлення";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Location = new Point(351, 218);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(122, 15);
            lblResponse.TabIndex = 1;
            lblResponse.Text = "Очікуємо відповідь...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResponse);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblResponse;
    }
}
