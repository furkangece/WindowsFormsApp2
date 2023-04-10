namespace WindowsFormsApp1
{
    partial class Form2
    {
        int count1 = 0;
        int count2 = 0;
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
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart1
            // 
            this.btnStart1.BackColor = System.Drawing.Color.Lime;
            this.btnStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart1.Location = new System.Drawing.Point(45, 61);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(103, 48);
            this.btnStart1.TabIndex = 0;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.BackColor = System.Drawing.Color.Lime;
            this.btnStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart2.Location = new System.Drawing.Point(45, 168);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(103, 48);
            this.btnStart2.TabIndex = 1;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = false;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.BackColor = System.Drawing.Color.Red;
            this.btnStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop1.Location = new System.Drawing.Point(224, 61);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(98, 48);
            this.btnStop1.TabIndex = 2;
            this.btnStop1.Text = "Stop";
            this.btnStop1.UseVisualStyleBackColor = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.BackColor = System.Drawing.Color.Red;
            this.btnStop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop2.Location = new System.Drawing.Point(224, 168);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(98, 45);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.Text = "Stop";
            this.btnStop2.UseVisualStyleBackColor = false;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(454, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Süre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(454, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Süre";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}