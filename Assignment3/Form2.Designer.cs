namespace Assignment3
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
            this.allAthletes = new System.Windows.Forms.TextBox();
            this.sortByName = new System.Windows.Forms.Button();
            this.sortFastestLap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lapNumber = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SaveRecord = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allAthletes
            // 
            this.allAthletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allAthletes.Location = new System.Drawing.Point(12, 46);
            this.allAthletes.Multiline = true;
            this.allAthletes.Name = "allAthletes";
            this.allAthletes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allAthletes.Size = new System.Drawing.Size(532, 919);
            this.allAthletes.TabIndex = 0;
            // 
            // sortByName
            // 
            this.sortByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByName.Location = new System.Drawing.Point(990, 46);
            this.sortByName.Name = "sortByName";
            this.sortByName.Size = new System.Drawing.Size(375, 113);
            this.sortByName.TabIndex = 1;
            this.sortByName.Text = "Sort By Name";
            this.sortByName.UseVisualStyleBackColor = true;
            this.sortByName.Click += new System.EventHandler(this.sortByName_Click);
            // 
            // sortFastestLap
            // 
            this.sortFastestLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortFastestLap.Location = new System.Drawing.Point(990, 288);
            this.sortFastestLap.Name = "sortFastestLap";
            this.sortFastestLap.Size = new System.Drawing.Size(375, 113);
            this.sortFastestLap.TabIndex = 2;
            this.sortFastestLap.Text = "Sort By Fastest Lap";
            this.sortFastestLap.UseVisualStyleBackColor = true;
            this.sortFastestLap.Click += new System.EventHandler(this.sortFastestLap_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(990, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 104);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sort By Lap Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lapNumber
            // 
            this.lapNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapNumber.Location = new System.Drawing.Point(653, 548);
            this.lapNumber.Name = "lapNumber";
            this.lapNumber.Size = new System.Drawing.Size(275, 56);
            this.lapNumber.TabIndex = 4;
            // 
            // SaveFile
            // 
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.Location = new System.Drawing.Point(653, 763);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(213, 83);
            this.SaveFile.TabIndex = 5;
            this.SaveFile.Text = "Save to File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SaveRecord
            // 
            this.SaveRecord.Enabled = false;
            this.SaveRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRecord.Location = new System.Drawing.Point(958, 763);
            this.SaveRecord.Name = "SaveRecord";
            this.SaveRecord.Size = new System.Drawing.Size(216, 83);
            this.SaveRecord.TabIndex = 6;
            this.SaveRecord.Text = "Save Record";
            this.SaveRecord.UseVisualStyleBackColor = true;
            this.SaveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1286, 763);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(162, 83);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 1004);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveRecord);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.lapNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortFastestLap);
            this.Controls.Add(this.sortByName);
            this.Controls.Add(this.allAthletes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox allAthletes;
        private System.Windows.Forms.Button sortByName;
        private System.Windows.Forms.Button sortFastestLap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lapNumber;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button SaveRecord;
        private System.Windows.Forms.Button Exit;
    }
}