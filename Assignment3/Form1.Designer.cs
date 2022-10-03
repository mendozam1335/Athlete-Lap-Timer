namespace Assignment3
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AthleteName = new System.Windows.Forms.ListBox();
            this.Add_To_List = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.StopWatchTimer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Lap = new System.Windows.Forms.Button();
            this.OutPut = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(1587, 82);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(404, 56);
            this.FirstName.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(1587, 201);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(404, 56);
            this.LastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1285, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1287, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "List of Athletes";
            // 
            // AthleteName
            // 
            this.AthleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleteName.FormattingEnabled = true;
            this.AthleteName.ItemHeight = 37;
            this.AthleteName.Location = new System.Drawing.Point(230, 173);
            this.AthleteName.Name = "AthleteName";
            this.AthleteName.Size = new System.Drawing.Size(364, 337);
            this.AthleteName.TabIndex = 5;
            this.AthleteName.SelectedIndexChanged += new System.EventHandler(this.AthleteName_SelectedIndexChanged);
            // 
            // Add_To_List
            // 
            this.Add_To_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_To_List.Location = new System.Drawing.Point(683, 137);
            this.Add_To_List.Name = "Add_To_List";
            this.Add_To_List.Size = new System.Drawing.Size(271, 109);
            this.Add_To_List.TabIndex = 6;
            this.Add_To_List.Text = "Add to List";
            this.Add_To_List.UseVisualStyleBackColor = true;
            this.Add_To_List.Click += new System.EventHandler(this.Add_To_List_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(1789, 370);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(181, 103);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // StopWatchTimer
            // 
            this.StopWatchTimer.AutoSize = true;
            this.StopWatchTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopWatchTimer.Location = new System.Drawing.Point(1375, 410);
            this.StopWatchTimer.Name = "StopWatchTimer";
            this.StopWatchTimer.Size = new System.Drawing.Size(354, 63);
            this.StopWatchTimer.TabIndex = 8;
            this.StopWatchTimer.Text = "00:00:00:000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1078, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop Watch";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(1087, 573);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(181, 103);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(1444, 573);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(181, 103);
            this.Stop.TabIndex = 11;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Lap
            // 
            this.Lap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap.Location = new System.Drawing.Point(1789, 573);
            this.Lap.Name = "Lap";
            this.Lap.Size = new System.Drawing.Size(181, 103);
            this.Lap.TabIndex = 12;
            this.Lap.Text = "Lap";
            this.Lap.UseVisualStyleBackColor = true;
            this.Lap.Click += new System.EventHandler(this.Lap_Click);
            // 
            // OutPut
            // 
            this.OutPut.AcceptsReturn = true;
            this.OutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPut.Location = new System.Drawing.Point(1087, 743);
            this.OutPut.Multiline = true;
            this.OutPut.Name = "OutPut";
            this.OutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutPut.Size = new System.Drawing.Size(883, 388);
            this.OutPut.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 125);
            this.button1.TabIndex = 14;
            this.button1.Text = "Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Enabled = false;
            this.OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Location = new System.Drawing.Point(449, 982);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(145, 97);
            this.OpenFile.TabIndex = 15;
            this.OpenFile.Text = "Save";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.Location = new System.Drawing.Point(160, 982);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(215, 97);
            this.SaveFile.TabIndex = 16;
            this.SaveFile.Text = "Save To File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(683, 982);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(173, 97);
            this.Open.TabIndex = 17;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(901, 982);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(155, 97);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2224, 1248);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.Lap);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StopWatchTimer);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Add_To_List);
            this.Controls.Add(this.AthleteName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AthleteName;
        private System.Windows.Forms.Button Add_To_List;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label StopWatchTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Lap;
        private System.Windows.Forms.TextBox OutPut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Exit;
    }
}

