namespace LUS.UserInterfaceLayer
{
    partial class AdminForm
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
            this.btnUpdateHeader = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.headerTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateHeader
            // 
            this.btnUpdateHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateHeader.Location = new System.Drawing.Point(526, 372);
            this.btnUpdateHeader.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateHeader.Name = "btnUpdateHeader";
            this.btnUpdateHeader.Size = new System.Drawing.Size(159, 42);
            this.btnUpdateHeader.TabIndex = 22;
            this.btnUpdateHeader.Text = "Update Header";
            this.btnUpdateHeader.UseVisualStyleBackColor = false;
            this.btnUpdateHeader.Click += new System.EventHandler(this.BtnUpdateHeader_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Header Information";
            // 
            // headerTxtBox
            // 
            this.headerTxtBox.Location = new System.Drawing.Point(117, 94);
            this.headerTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.headerTxtBox.Multiline = true;
            this.headerTxtBox.Name = "headerTxtBox";
            this.headerTxtBox.Size = new System.Drawing.Size(568, 233);
            this.headerTxtBox.TabIndex = 20;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headerTxtBox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox headerTxtBox;
    }
}