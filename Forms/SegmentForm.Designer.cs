namespace Lab3.Forms
{
    partial class SegmentForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Нарисовать отрезок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "X1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "X2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y2:";
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.SystemColors.Window;
            this.x1.Cursor = System.Windows.Forms.Cursors.Default;
            this.x1.Location = new System.Drawing.Point(50, 26);
            this.x1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(103, 20);
            this.x1.TabIndex = 14;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(50, 52);
            this.y1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(103, 20);
            this.y1.TabIndex = 15;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(50, 77);
            this.x2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(103, 20);
            this.x2.TabIndex = 16;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(50, 104);
            this.y2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(103, 20);
            this.y2.TabIndex = 17;
            // 
            // SegmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 180);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SegmentForm";
            this.Text = "Отрезок";
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown x1;
    }
}