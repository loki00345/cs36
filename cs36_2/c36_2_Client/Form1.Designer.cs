namespace c36_2_Client
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
            btnTime = new Button();
            btnDate = new Button();
            lblResponse = new Label();
            SuspendLayout();
            // 
            // btnTime
            // 
            btnTime.Location = new Point(267, 279);
            btnTime.Name = "btnTime";
            btnTime.Size = new Size(128, 23);
            btnTime.TabIndex = 0;
            btnTime.Text = "Отримати час";
            btnTime.UseVisualStyleBackColor = true;
            btnTime.Click += btnTime_Click;
            // 
            // btnDate
            // 
            btnDate.Location = new Point(415, 279);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(132, 23);
            btnDate.TabIndex = 1;
            btnDate.Text = "Отримати дату";
            btnDate.UseVisualStyleBackColor = true;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Location = new Point(354, 235);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(0, 15);
            lblResponse.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResponse);
            Controls.Add(btnDate);
            Controls.Add(btnTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTime;
        private Button btnDate;
        private Label lblResponse;
    }
}
