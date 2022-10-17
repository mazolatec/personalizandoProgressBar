namespace TestProgressBar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.vProgressBar = new VerticalProgressBar.VerticalProgressBar();
            this.verticalProgressBar2 = new VerticalProgressBar.VerticalProgressBar();
            this.btnControleVarial = new System.Windows.Forms.Button();
            this.txtBoxValueMin = new System.Windows.Forms.TextBox();
            this.txtBoxValueMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatusI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vProgressBar
            // 
            this.vProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.vProgressBar.Color = System.Drawing.Color.Blue;
            this.vProgressBar.Location = new System.Drawing.Point(12, 73);
            this.vProgressBar.Maximum = 100;
            this.vProgressBar.Minimum = 0;
            this.vProgressBar.Name = "vProgressBar";
            this.vProgressBar.Size = new System.Drawing.Size(17, 120);
            this.vProgressBar.Step = 5;
            this.vProgressBar.Style = VerticalProgressBar.Styles.Classic;
            this.vProgressBar.TabIndex = 0;
            this.vProgressBar.Value = 0;
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.verticalProgressBar2.Color = System.Drawing.Color.LightSlateGray;
            this.verticalProgressBar2.Location = new System.Drawing.Point(35, 73);
            this.verticalProgressBar2.Maximum = 100;
            this.verticalProgressBar2.Minimum = 0;
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(16, 120);
            this.verticalProgressBar2.Step = 10;
            this.verticalProgressBar2.Style = VerticalProgressBar.Styles.Classic;
            this.verticalProgressBar2.TabIndex = 1;
            this.verticalProgressBar2.Value = 50;
            // 
            // btnControleVarial
            // 
            this.btnControleVarial.Location = new System.Drawing.Point(2, 210);
            this.btnControleVarial.Name = "btnControleVarial";
            this.btnControleVarial.Size = new System.Drawing.Size(118, 23);
            this.btnControleVarial.TabIndex = 2;
            this.btnControleVarial.Text = "Start Variavável";
            this.btnControleVarial.UseVisualStyleBackColor = true;
            this.btnControleVarial.Click += new System.EventHandler(this.btnControleVarial_Click);
            // 
            // txtBoxValueMin
            // 
            this.txtBoxValueMin.Location = new System.Drawing.Point(12, 34);
            this.txtBoxValueMin.Name = "txtBoxValueMin";
            this.txtBoxValueMin.Size = new System.Drawing.Size(81, 20);
            this.txtBoxValueMin.TabIndex = 3;
            // 
            // txtBoxValueMax
            // 
            this.txtBoxValueMax.Location = new System.Drawing.Point(162, 34);
            this.txtBoxValueMax.Name = "txtBoxValueMax";
            this.txtBoxValueMax.Size = new System.Drawing.Size(103, 20);
            this.txtBoxValueMax.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Progress Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Progress Maximo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start Therad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 107);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(208, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lblStatusI
            // 
            this.lblStatusI.AutoSize = true;
            this.lblStatusI.Location = new System.Drawing.Point(59, 73);
            this.lblStatusI.Name = "lblStatusI";
            this.lblStatusI.Size = new System.Drawing.Size(61, 13);
            this.lblStatusI.TabIndex = 9;
            this.lblStatusI.Text = "Var i do for:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 250);
            this.Controls.Add(this.lblStatusI);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxValueMax);
            this.Controls.Add(this.txtBoxValueMin);
            this.Controls.Add(this.btnControleVarial);
            this.Controls.Add(this.verticalProgressBar2);
            this.Controls.Add(this.vProgressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VerticalProgressBar.VerticalProgressBar vProgressBar;
        private VerticalProgressBar.VerticalProgressBar verticalProgressBar2;
        private System.Windows.Forms.Button btnControleVarial;
        private System.Windows.Forms.TextBox txtBoxValueMin;
        private System.Windows.Forms.TextBox txtBoxValueMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatusI;
    }
}

