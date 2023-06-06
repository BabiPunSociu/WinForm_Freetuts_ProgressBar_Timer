namespace CoBan_ProgressBar_Timer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmr_1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_2 = new System.Windows.Forms.Timer(this.components);
            this.lblGio = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.lblGio);
            this.groupBox1.Controls.Add(this.lblNgayThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLoading);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bây giờ là:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vũ Thu Hiền (^-^)";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(43, 90);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(147, 51);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "&Hiển thị ngày giờ";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThang.Location = new System.Drawing.Point(529, 37);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(0, 32);
            this.lblNgayThang.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(232, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 50);
            this.progressBar1.TabIndex = 2;
            // 
            // tmr_1
            // 
            this.tmr_1.Interval = 1000;
            this.tmr_1.Tick += new System.EventHandler(this.tmr_1_Tick);
            // 
            // tmr_2
            // 
            this.tmr_2.Interval = 500;
            this.tmr_2.Tick += new System.EventHandler(this.tmr_2_Tick);
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.Location = new System.Drawing.Point(314, 37);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(0, 32);
            this.lblGio.TabIndex = 1;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(274, 43);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(0, 32);
            this.lblLoading.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ProgressBar - Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNgayThang;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmr_1;
        private System.Windows.Forms.Timer tmr_2;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Label lblLoading;
    }
}

