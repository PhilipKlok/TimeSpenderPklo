namespace TimeSpender19septPKlok
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
            this.components = new System.ComponentModel.Container();
            this.btnSafeWorkPklo = new System.Windows.Forms.Button();
            this.btnShowPklo = new System.Windows.Forms.Button();
            this.cmbActivityPklo = new System.Windows.Forms.ComboBox();
            this.rtbActivityPklo = new System.Windows.Forms.RichTextBox();
            this.tmrAppRemovePklo = new System.Windows.Forms.Timer(this.components);
            this.tmrChangeColorPklo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSafeWorkPklo
            // 
            this.btnSafeWorkPklo.Location = new System.Drawing.Point(49, 42);
            this.btnSafeWorkPklo.Name = "btnSafeWorkPklo";
            this.btnSafeWorkPklo.Size = new System.Drawing.Size(75, 23);
            this.btnSafeWorkPklo.TabIndex = 0;
            this.btnSafeWorkPklo.Text = "Save Work";
            this.btnSafeWorkPklo.UseVisualStyleBackColor = true;
            this.btnSafeWorkPklo.Click += new System.EventHandler(this.btnSafeWorkPklo_Click);
            // 
            // btnShowPklo
            // 
            this.btnShowPklo.Location = new System.Drawing.Point(143, 42);
            this.btnShowPklo.Name = "btnShowPklo";
            this.btnShowPklo.Size = new System.Drawing.Size(80, 23);
            this.btnShowPklo.TabIndex = 1;
            this.btnShowPklo.Text = "Show";
            this.btnShowPklo.UseVisualStyleBackColor = true;
            // 
            // cmbActivityPklo
            // 
            this.cmbActivityPklo.FormattingEnabled = true;
            this.cmbActivityPklo.Items.AddRange(new object[] {
            "Having a break",
            "Doing hard stuff",
            "Having a meeting",
            "Sleep"});
            this.cmbActivityPklo.Location = new System.Drawing.Point(49, 71);
            this.cmbActivityPklo.Name = "cmbActivityPklo";
            this.cmbActivityPklo.Size = new System.Drawing.Size(174, 21);
            this.cmbActivityPklo.TabIndex = 2;
            // 
            // rtbActivityPklo
            // 
            this.rtbActivityPklo.Location = new System.Drawing.Point(49, 99);
            this.rtbActivityPklo.Name = "rtbActivityPklo";
            this.rtbActivityPklo.Size = new System.Drawing.Size(174, 160);
            this.rtbActivityPklo.TabIndex = 3;
            this.rtbActivityPklo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 315);
            this.Controls.Add(this.rtbActivityPklo);
            this.Controls.Add(this.cmbActivityPklo);
            this.Controls.Add(this.btnShowPklo);
            this.Controls.Add(this.btnSafeWorkPklo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSafeWorkPklo;
        private System.Windows.Forms.Button btnShowPklo;
        private System.Windows.Forms.ComboBox cmbActivityPklo;
        private System.Windows.Forms.RichTextBox rtbActivityPklo;
        private System.Windows.Forms.Timer tmrAppRemovePklo;
        private System.Windows.Forms.Timer tmrChangeColorPklo;
    }
}

