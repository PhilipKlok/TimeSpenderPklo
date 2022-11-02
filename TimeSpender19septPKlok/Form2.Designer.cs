
namespace TimeSpender19septPKlok
{
    partial class Form2
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
            this.lblLogFilePklo = new System.Windows.Forms.Label();
            this.txbLogFileLocationPklo = new System.Windows.Forms.TextBox();
            this.btnBrowsePklo = new System.Windows.Forms.Button();
            this.lblLogIntervalPklo = new System.Windows.Forms.Label();
            this.lbxLogIntervalPklo = new System.Windows.Forms.ListBox();
            this.btnClosePklo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxTasksPklo = new System.Windows.Forms.ListBox();
            this.txbAddingTaskPklo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTaskPklo = new System.Windows.Forms.Button();
            this.btnDeleteTaskPklo = new System.Windows.Forms.Button();
            this.btnFinishedPklo = new System.Windows.Forms.Button();
            this.btnSaveSettingsPklo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogFilePklo
            // 
            this.lblLogFilePklo.AutoSize = true;
            this.lblLogFilePklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogFilePklo.Location = new System.Drawing.Point(12, 18);
            this.lblLogFilePklo.Name = "lblLogFilePklo";
            this.lblLogFilePklo.Size = new System.Drawing.Size(125, 18);
            this.lblLogFilePklo.TabIndex = 0;
            this.lblLogFilePklo.Text = "Log File Location:";
            // 
            // txbLogFileLocationPklo
            // 
            this.txbLogFileLocationPklo.Location = new System.Drawing.Point(143, 19);
            this.txbLogFileLocationPklo.Name = "txbLogFileLocationPklo";
            this.txbLogFileLocationPklo.Size = new System.Drawing.Size(371, 20);
            this.txbLogFileLocationPklo.TabIndex = 1;
            // 
            // btnBrowsePklo
            // 
            this.btnBrowsePklo.Location = new System.Drawing.Point(520, 18);
            this.btnBrowsePklo.Name = "btnBrowsePklo";
            this.btnBrowsePklo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePklo.TabIndex = 2;
            this.btnBrowsePklo.Text = "Browse";
            this.btnBrowsePklo.UseVisualStyleBackColor = true;
            // 
            // lblLogIntervalPklo
            // 
            this.lblLogIntervalPklo.AutoSize = true;
            this.lblLogIntervalPklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIntervalPklo.Location = new System.Drawing.Point(42, 66);
            this.lblLogIntervalPklo.Name = "lblLogIntervalPklo";
            this.lblLogIntervalPklo.Size = new System.Drawing.Size(83, 18);
            this.lblLogIntervalPklo.TabIndex = 3;
            this.lblLogIntervalPklo.Text = "Log Interval";
            // 
            // lbxLogIntervalPklo
            // 
            this.lbxLogIntervalPklo.FormattingEnabled = true;
            this.lbxLogIntervalPklo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lbxLogIntervalPklo.Location = new System.Drawing.Point(26, 87);
            this.lbxLogIntervalPklo.Name = "lbxLogIntervalPklo";
            this.lbxLogIntervalPklo.Size = new System.Drawing.Size(120, 134);
            this.lbxLogIntervalPklo.TabIndex = 4;
            // 
            // btnClosePklo
            // 
            this.btnClosePklo.Location = new System.Drawing.Point(447, 307);
            this.btnClosePklo.Name = "btnClosePklo";
            this.btnClosePklo.Size = new System.Drawing.Size(75, 23);
            this.btnClosePklo.TabIndex = 5;
            this.btnClosePklo.Text = "Close";
            this.btnClosePklo.UseVisualStyleBackColor = true;
            this.btnClosePklo.Click += new System.EventHandler(this.btnClosePklo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tasks";
            // 
            // lbxTasksPklo
            // 
            this.lbxTasksPklo.FormattingEnabled = true;
            this.lbxTasksPklo.Location = new System.Drawing.Point(185, 87);
            this.lbxTasksPklo.Name = "lbxTasksPklo";
            this.lbxTasksPklo.Size = new System.Drawing.Size(187, 134);
            this.lbxTasksPklo.TabIndex = 7;
            // 
            // txbAddingTaskPklo
            // 
            this.txbAddingTaskPklo.Location = new System.Drawing.Point(388, 87);
            this.txbAddingTaskPklo.Name = "txbAddingTaskPklo";
            this.txbAddingTaskPklo.Size = new System.Drawing.Size(207, 20);
            this.txbAddingTaskPklo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adding Task";
            // 
            // btnAddTaskPklo
            // 
            this.btnAddTaskPklo.Location = new System.Drawing.Point(458, 113);
            this.btnAddTaskPklo.Name = "btnAddTaskPklo";
            this.btnAddTaskPklo.Size = new System.Drawing.Size(75, 23);
            this.btnAddTaskPklo.TabIndex = 10;
            this.btnAddTaskPklo.Text = "Add";
            this.btnAddTaskPklo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTaskPklo
            // 
            this.btnDeleteTaskPklo.Location = new System.Drawing.Point(241, 227);
            this.btnDeleteTaskPklo.Name = "btnDeleteTaskPklo";
            this.btnDeleteTaskPklo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTaskPklo.TabIndex = 11;
            this.btnDeleteTaskPklo.Text = "Delete";
            this.btnDeleteTaskPklo.UseVisualStyleBackColor = true;
            // 
            // btnFinishedPklo
            // 
            this.btnFinishedPklo.Location = new System.Drawing.Point(26, 307);
            this.btnFinishedPklo.Name = "btnFinishedPklo";
            this.btnFinishedPklo.Size = new System.Drawing.Size(110, 23);
            this.btnFinishedPklo.TabIndex = 12;
            this.btnFinishedPklo.Text = "Finished For Today";
            this.btnFinishedPklo.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettingsPklo
            // 
            this.btnSaveSettingsPklo.Location = new System.Drawing.Point(528, 307);
            this.btnSaveSettingsPklo.Name = "btnSaveSettingsPklo";
            this.btnSaveSettingsPklo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettingsPklo.TabIndex = 13;
            this.btnSaveSettingsPklo.Text = "Save";
            this.btnSaveSettingsPklo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "(Max. 10)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveSettingsPklo);
            this.Controls.Add(this.btnFinishedPklo);
            this.Controls.Add(this.btnDeleteTaskPklo);
            this.Controls.Add(this.btnAddTaskPklo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAddingTaskPklo);
            this.Controls.Add(this.lbxTasksPklo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClosePklo);
            this.Controls.Add(this.lbxLogIntervalPklo);
            this.Controls.Add(this.lblLogIntervalPklo);
            this.Controls.Add(this.btnBrowsePklo);
            this.Controls.Add(this.txbLogFileLocationPklo);
            this.Controls.Add(this.lblLogFilePklo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogFilePklo;
        private System.Windows.Forms.TextBox txbLogFileLocationPklo;
        private System.Windows.Forms.Button btnBrowsePklo;
        private System.Windows.Forms.Label lblLogIntervalPklo;
        private System.Windows.Forms.ListBox lbxLogIntervalPklo;
        private System.Windows.Forms.Button btnClosePklo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTasksPklo;
        private System.Windows.Forms.TextBox txbAddingTaskPklo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTaskPklo;
        private System.Windows.Forms.Button btnDeleteTaskPklo;
        private System.Windows.Forms.Button btnFinishedPklo;
        private System.Windows.Forms.Button btnSaveSettingsPklo;
        private System.Windows.Forms.Label label3;
    }
}