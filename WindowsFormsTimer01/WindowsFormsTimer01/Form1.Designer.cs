namespace WindowsFormsTimer01
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfSetToCarry = new System.Windows.Forms.TextBox();
            this.lblETA = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSecPerCook = new WindowsFormsTimer01.NumericUpDownFix();
            this.numDurability = new WindowsFormsTimer01.NumericUpDownFix();
            this.numWeight = new WindowsFormsTimer01.NumericUpDownFix();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecPerCook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Location = new System.Drawing.Point(102, 136);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(57, 23);
            this.btnSetTimer.TabIndex = 1;
            this.btnSetTimer.Text = "set";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(102, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(63, 180);
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(171, 18);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 147);
            this.textBox3.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numWeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.numberOfSetToCarry);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(250, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 213);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WeightCalc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "LT";
            // 
            // numberOfSetToCarry
            // 
            this.numberOfSetToCarry.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numberOfSetToCarry.Location = new System.Drawing.Point(7, 80);
            this.numberOfSetToCarry.Name = "numberOfSetToCarry";
            this.numberOfSetToCarry.Size = new System.Drawing.Size(62, 22);
            this.numberOfSetToCarry.TabIndex = 8;
            this.numberOfSetToCarry.Text = "0";
            this.numberOfSetToCarry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberOfSetToCarry.TextChanged += new System.EventHandler(this.numberOfSetToCarry_TextChanged);
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETA.Location = new System.Drawing.Point(6, 29);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(35, 38);
            this.lblETA.TabIndex = 11;
            this.lblETA.Text = "0";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(6, 82);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(35, 38);
            this.lblCountdown.TabIndex = 12;
            this.lblCountdown.Text = "0";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStop.Location = new System.Drawing.Point(165, 136);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 61);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "S";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numSecPerCook);
            this.groupBox2.Controls.Add(this.numDurability);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCountdown);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.lblETA);
            this.groupBox2.Controls.Add(this.btnSetTimer);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 219);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ETA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "sec/set";
            // 
            // numSecPerCook
            // 
            this.numSecPerCook.Location = new System.Drawing.Point(164, 98);
            this.numSecPerCook.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSecPerCook.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSecPerCook.Name = "numSecPerCook";
            this.numSecPerCook.Size = new System.Drawing.Size(62, 22);
            this.numSecPerCook.TabIndex = 17;
            this.numSecPerCook.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // numDurability
            // 
            this.numDurability.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurability.Location = new System.Drawing.Point(22, 137);
            this.numDurability.Maximum = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            this.numDurability.Name = "numDurability";
            this.numDurability.Size = new System.Drawing.Size(62, 22);
            this.numDurability.TabIndex = 16;
            // 
            // numWeight
            // 
            this.numWeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWeight.Location = new System.Drawing.Point(7, 36);
            this.numWeight.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(62, 22);
            this.numWeight.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BDO-CraftTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecPerCook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOfSetToCarry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NumericUpDownFix numDurability;
        private NumericUpDownFix numSecPerCook;
        private NumericUpDownFix numWeight;
    }
}

