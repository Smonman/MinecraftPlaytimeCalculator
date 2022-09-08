namespace MinecraftPlaytimeCalculator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_openFolderDialoge = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_playerName = new System.Windows.Forms.TextBox();
            this.textBox_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.label_playtime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_openFolderDialoge);
            this.groupBox1.Controls.Add(this.button_calculate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_playerName);
            this.groupBox1.Controls.Add(this.textBox_dir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // button_openFolderDialoge
            // 
            this.button_openFolderDialoge.Location = new System.Drawing.Point(470, 16);
            this.button_openFolderDialoge.Name = "button_openFolderDialoge";
            this.button_openFolderDialoge.Size = new System.Drawing.Size(25, 20);
            this.button_openFolderDialoge.TabIndex = 1;
            this.button_openFolderDialoge.Text = "...";
            this.button_openFolderDialoge.UseVisualStyleBackColor = true;
            this.button_openFolderDialoge.Click += new System.EventHandler(this.button_openFolderDialoge_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(9, 68);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(486, 23);
            this.button_calculate.TabIndex = 3;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player Name";
            // 
            // textBox_playerName
            // 
            this.textBox_playerName.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_playerName.Location = new System.Drawing.Point(88, 42);
            this.textBox_playerName.Name = "textBox_playerName";
            this.textBox_playerName.Size = new System.Drawing.Size(407, 20);
            this.textBox_playerName.TabIndex = 2;
            // 
            // textBox_dir
            // 
            this.textBox_dir.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_dir.Location = new System.Drawing.Point(88, 16);
            this.textBox_dir.Name = "textBox_dir";
            this.textBox_dir.Size = new System.Drawing.Size(376, 20);
            this.textBox_dir.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_dir, "Usually \"C:\\Users\\USER\\AppData\\Roaming\\.minecraft\\logs\"");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logs Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_output);
            this.groupBox2.Controls.Add(this.label_playtime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // listBox_output
            // 
            this.listBox_output.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(9, 32);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(486, 221);
            this.listBox_output.TabIndex = 2;
            // 
            // label_playtime
            // 
            this.label_playtime.AutoSize = true;
            this.label_playtime.Location = new System.Drawing.Point(60, 16);
            this.label_playtime.Name = "label_playtime";
            this.label_playtime.Size = new System.Drawing.Size(33, 13);
            this.label_playtime.TabIndex = 1;
            this.label_playtime.Text = "TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Playtime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Minecraft Playtime Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_dir;
		private System.Windows.Forms.TextBox textBox_playerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_playtime;
		private System.Windows.Forms.Button button_calculate;
		private System.Windows.Forms.Button button_openFolderDialoge;
		private System.Windows.Forms.ListBox listBox_output;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

