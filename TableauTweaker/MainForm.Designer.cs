namespace WashU.BatemanLab.MassSpec.TableauTweaker
{
    partial class MainForm
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
            this.tabMainForm = new System.Windows.Forms.TabControl();
            this.tabHomePage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainForm
            // 
            this.tabMainForm.Controls.Add(this.tabHomePage);
            this.tabMainForm.Controls.Add(this.tabPage2);
            this.tabMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainForm.Location = new System.Drawing.Point(0, 0);
            this.tabMainForm.Name = "tabMainForm";
            this.tabMainForm.SelectedIndex = 0;
            this.tabMainForm.Size = new System.Drawing.Size(800, 450);
            this.tabMainForm.TabIndex = 0;
            // 
            // tabHomePage
            // 
            this.tabHomePage.Location = new System.Drawing.Point(4, 22);
            this.tabHomePage.Name = "tabHomePage";
            this.tabHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabHomePage.Size = new System.Drawing.Size(792, 424);
            this.tabHomePage.TabIndex = 0;
            this.tabHomePage.Text = "Home Page";
            this.tabHomePage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMainForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainForm;
        private System.Windows.Forms.TabPage tabHomePage;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

