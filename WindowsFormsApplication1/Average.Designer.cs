namespace WindowsFormsApplication1
{
    partial class Average
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtThirdnumber = new System.Windows.Forms.TextBox();
            this.txtFifthnumber = new System.Windows.Forms.TextBox();
            this.txtFourthnumber = new System.Windows.Forms.TextBox();
            this.txtSecondnumber = new System.Windows.Forms.TextBox();
            this.txtFirstnumber = new System.Windows.Forms.TextBox();
            this.Firstnumber = new System.Windows.Forms.Label();
            this.Secondnumber = new System.Windows.Forms.Label();
            this.Thirdnumber = new System.Windows.Forms.Label();
            this.Fourthnumber = new System.Windows.Forms.Label();
            this.Fifthnumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtThirdnumber
            // 
            this.txtThirdnumber.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtThirdnumber.Location = new System.Drawing.Point(558, 191);
            this.txtThirdnumber.Name = "txtThirdnumber";
            this.txtThirdnumber.Size = new System.Drawing.Size(116, 21);
            this.txtThirdnumber.TabIndex = 0;
            this.txtThirdnumber.TextChanged += new System.EventHandler(this.txtThirdnumber_TextChanged);
            // 
            // txtFifthnumber
            // 
            this.txtFifthnumber.Location = new System.Drawing.Point(558, 279);
            this.txtFifthnumber.Name = "txtFifthnumber";
            this.txtFifthnumber.Size = new System.Drawing.Size(116, 21);
            this.txtFifthnumber.TabIndex = 1;
            // 
            // txtFourthnumber
            // 
            this.txtFourthnumber.Location = new System.Drawing.Point(558, 234);
            this.txtFourthnumber.Name = "txtFourthnumber";
            this.txtFourthnumber.Size = new System.Drawing.Size(117, 21);
            this.txtFourthnumber.TabIndex = 2;
            // 
            // txtSecondnumber
            // 
            this.txtSecondnumber.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSecondnumber.Location = new System.Drawing.Point(558, 149);
            this.txtSecondnumber.Name = "txtSecondnumber";
            this.txtSecondnumber.Size = new System.Drawing.Size(116, 21);
            this.txtSecondnumber.TabIndex = 3;
            // 
            // txtFirstnumber
            // 
            this.txtFirstnumber.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFirstnumber.Location = new System.Drawing.Point(558, 105);
            this.txtFirstnumber.Name = "txtFirstnumber";
            this.txtFirstnumber.Size = new System.Drawing.Size(116, 21);
            this.txtFirstnumber.TabIndex = 4;
            this.txtFirstnumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Firstnumber
            // 
            this.Firstnumber.AutoSize = true;
            this.Firstnumber.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnumber.Location = new System.Drawing.Point(245, 105);
            this.Firstnumber.Name = "Firstnumber";
            this.Firstnumber.Size = new System.Drawing.Size(82, 15);
            this.Firstnumber.TabIndex = 5;
            this.Firstnumber.Text = "Firstnumber";
            this.Firstnumber.Click += new System.EventHandler(this.Firstnumber_Click);
            // 
            // Secondnumber
            // 
            this.Secondnumber.AutoSize = true;
            this.Secondnumber.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secondnumber.Location = new System.Drawing.Point(245, 149);
            this.Secondnumber.Name = "Secondnumber";
            this.Secondnumber.Size = new System.Drawing.Size(100, 15);
            this.Secondnumber.TabIndex = 6;
            this.Secondnumber.Text = "Secondnumber";
            this.Secondnumber.Click += new System.EventHandler(this.Secondnumber_Click);
            // 
            // Thirdnumber
            // 
            this.Thirdnumber.AutoSize = true;
            this.Thirdnumber.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thirdnumber.Location = new System.Drawing.Point(245, 191);
            this.Thirdnumber.Name = "Thirdnumber";
            this.Thirdnumber.Size = new System.Drawing.Size(88, 15);
            this.Thirdnumber.TabIndex = 7;
            this.Thirdnumber.Text = "Thirdnumber";
            // 
            // Fourthnumber
            // 
            this.Fourthnumber.AutoSize = true;
            this.Fourthnumber.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fourthnumber.Location = new System.Drawing.Point(245, 234);
            this.Fourthnumber.Name = "Fourthnumber";
            this.Fourthnumber.Size = new System.Drawing.Size(96, 15);
            this.Fourthnumber.TabIndex = 8;
            this.Fourthnumber.Text = "Fourthnumber";
            // 
            // Fifthnumber
            // 
            this.Fifthnumber.AutoSize = true;
            this.Fifthnumber.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fifthnumber.Location = new System.Drawing.Point(245, 279);
            this.Fifthnumber.Name = "Fifthnumber";
            this.Fifthnumber.Size = new System.Drawing.Size(84, 15);
            this.Fifthnumber.TabIndex = 9;
            this.Fifthnumber.Text = "Fifthnumber";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(355, 349);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(262, 148);
            this.lblResult.TabIndex = 10;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calculate The Average Of Marks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Average
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Fifthnumber);
            this.Controls.Add(this.Fourthnumber);
            this.Controls.Add(this.Thirdnumber);
            this.Controls.Add(this.Secondnumber);
            this.Controls.Add(this.Firstnumber);
            this.Controls.Add(this.txtFirstnumber);
            this.Controls.Add(this.txtSecondnumber);
            this.Controls.Add(this.txtFourthnumber);
            this.Controls.Add(this.txtFifthnumber);
            this.Controls.Add(this.txtThirdnumber);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Average";
            this.Text = "Average";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThirdnumber;
        private System.Windows.Forms.TextBox txtFifthnumber;
        private System.Windows.Forms.TextBox txtFourthnumber;
        private System.Windows.Forms.TextBox txtSecondnumber;
        private System.Windows.Forms.TextBox txtFirstnumber;
        private System.Windows.Forms.Label Firstnumber;
        private System.Windows.Forms.Label Secondnumber;
        private System.Windows.Forms.Label Thirdnumber;
        private System.Windows.Forms.Label Fourthnumber;
        private System.Windows.Forms.Label Fifthnumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

