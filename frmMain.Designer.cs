
namespace UnifiAdopter
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.btnAdopt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtController = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDevice);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP of device";
            // 
            // txtDevice
            // 
            this.txtDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDevice.Location = new System.Drawing.Point(6, 22);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(165, 29);
            this.txtDevice.TabIndex = 0;
            // 
            // btnAdopt
            // 
            this.btnAdopt.Location = new System.Drawing.Point(205, 22);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(75, 57);
            this.btnAdopt.TabIndex = 1;
            this.btnAdopt.Text = "Adopt";
            this.btnAdopt.UseVisualStyleBackColor = true;
            this.btnAdopt.Click += new System.EventHandler(this.btnAdopt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtController);
            this.groupBox2.Location = new System.Drawing.Point(13, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller URL";
            // 
            // txtController
            // 
            this.txtController.Location = new System.Drawing.Point(7, 23);
            this.txtController.Name = "txtController";
            this.txtController.Size = new System.Drawing.Size(254, 23);
            this.txtController.TabIndex = 0;
            this.txtController.Text = "http://unifi.scharsich.dev:8080/inform";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdopt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdopt);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "scharsich.dev Unifi Adopter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtController;
    }
}

