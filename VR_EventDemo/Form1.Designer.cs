namespace VR_EventDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudArmor1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudWeapon1 = new System.Windows.Forms.NumericUpDown();
            this.prbHP1 = new System.Windows.Forms.ProgressBar();
            this.btnAttackMarine2 = new System.Windows.Forms.Button();
            this.btnAttackMarine1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudArmor2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWeapon2 = new System.Windows.Forms.NumericUpDown();
            this.prbHP2 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeapon1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeapon2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudArmor1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudWeapon1);
            this.groupBox1.Controls.Add(this.prbHP1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marine 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "방";
            // 
            // nudArmor1
            // 
            this.nudArmor1.Location = new System.Drawing.Point(32, 74);
            this.nudArmor1.Name = "nudArmor1";
            this.nudArmor1.Size = new System.Drawing.Size(79, 21);
            this.nudArmor1.TabIndex = 3;
            this.nudArmor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudArmor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "공";
            // 
            // nudWeapon1
            // 
            this.nudWeapon1.Location = new System.Drawing.Point(32, 47);
            this.nudWeapon1.Name = "nudWeapon1";
            this.nudWeapon1.Size = new System.Drawing.Size(79, 21);
            this.nudWeapon1.TabIndex = 1;
            this.nudWeapon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWeapon1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // prbHP1
            // 
            this.prbHP1.Location = new System.Drawing.Point(11, 18);
            this.prbHP1.Name = "prbHP1";
            this.prbHP1.Size = new System.Drawing.Size(100, 23);
            this.prbHP1.TabIndex = 0;
            this.prbHP1.Value = 100;
            // 
            // btnAttackMarine2
            // 
            this.btnAttackMarine2.Location = new System.Drawing.Point(137, 39);
            this.btnAttackMarine2.Name = "btnAttackMarine2";
            this.btnAttackMarine2.Size = new System.Drawing.Size(69, 23);
            this.btnAttackMarine2.TabIndex = 2;
            this.btnAttackMarine2.Text = "-->";
            this.btnAttackMarine2.UseVisualStyleBackColor = true;
            this.btnAttackMarine2.Click += new System.EventHandler(this.btnAttackMarine2_Click);
            // 
            // btnAttackMarine1
            // 
            this.btnAttackMarine1.Location = new System.Drawing.Point(137, 77);
            this.btnAttackMarine1.Name = "btnAttackMarine1";
            this.btnAttackMarine1.Size = new System.Drawing.Size(69, 23);
            this.btnAttackMarine1.TabIndex = 3;
            this.btnAttackMarine1.Text = "<--";
            this.btnAttackMarine1.UseVisualStyleBackColor = true;
            this.btnAttackMarine1.Click += new System.EventHandler(this.btnAttackMarine1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudArmor2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudWeapon2);
            this.groupBox2.Controls.Add(this.prbHP2);
            this.groupBox2.Location = new System.Drawing.Point(221, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marine 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "방";
            // 
            // nudArmor2
            // 
            this.nudArmor2.Location = new System.Drawing.Point(32, 74);
            this.nudArmor2.Name = "nudArmor2";
            this.nudArmor2.Size = new System.Drawing.Size(79, 21);
            this.nudArmor2.TabIndex = 3;
            this.nudArmor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudArmor2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "공";
            // 
            // nudWeapon2
            // 
            this.nudWeapon2.Location = new System.Drawing.Point(32, 47);
            this.nudWeapon2.Name = "nudWeapon2";
            this.nudWeapon2.Size = new System.Drawing.Size(79, 21);
            this.nudWeapon2.TabIndex = 1;
            this.nudWeapon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWeapon2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // prbHP2
            // 
            this.prbHP2.Location = new System.Drawing.Point(11, 18);
            this.prbHP2.Name = "prbHP2";
            this.prbHP2.Size = new System.Drawing.Size(100, 23);
            this.prbHP2.TabIndex = 0;
            this.prbHP2.Value = 100;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 174);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAttackMarine1);
            this.Controls.Add(this.btnAttackMarine2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeapon1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeapon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAttackMarine2;
        private System.Windows.Forms.Button btnAttackMarine1;
        private System.Windows.Forms.ProgressBar prbHP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudArmor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWeapon1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudArmor2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudWeapon2;
        private System.Windows.Forms.ProgressBar prbHP2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

