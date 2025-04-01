namespace DibujarRectangulosFactory
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
            this.DibujarButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtCordenadaX = new System.Windows.Forms.TextBox();
            this.txtRectangulosCreados = new System.Windows.Forms.TextBox();
            this.txtCordenadaY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // DibujarButton
            // 
            this.DibujarButton.Location = new System.Drawing.Point(163, 126);
            this.DibujarButton.Name = "DibujarButton";
            this.DibujarButton.Size = new System.Drawing.Size(75, 31);
            this.DibujarButton.TabIndex = 0;
            this.DibujarButton.Text = "Dibujar";
            this.DibujarButton.UseVisualStyleBackColor = true;
            this.DibujarButton.Click += new System.EventHandler(this.DibujarButton_Click);
            // 
            // txtCordenadaX
            // 
            this.txtCordenadaX.Location = new System.Drawing.Point(163, 68);
            this.txtCordenadaX.Name = "txtCordenadaX";
            this.txtCordenadaX.Size = new System.Drawing.Size(156, 26);
            this.txtCordenadaX.TabIndex = 2;
            // 
            // txtRectangulosCreados
            // 
            this.txtRectangulosCreados.Location = new System.Drawing.Point(441, 126);
            this.txtRectangulosCreados.Name = "txtRectangulosCreados";
            this.txtRectangulosCreados.Size = new System.Drawing.Size(176, 26);
            this.txtRectangulosCreados.TabIndex = 3;
            // 
            // txtCordenadaY
            // 
            this.txtCordenadaY.Location = new System.Drawing.Point(335, 68);
            this.txtCordenadaY.Name = "txtCordenadaY";
            this.txtCordenadaY.Size = new System.Drawing.Size(156, 26);
            this.txtCordenadaY.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cordenada X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cordenada Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Creador de rectangulos";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Location = new System.Drawing.Point(517, 68);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(100, 26);
            this.pictureBoxColor.TabIndex = 9;
            this.pictureBoxColor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Retangulos creados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCordenadaY);
            this.Controls.Add(this.txtRectangulosCreados);
            this.Controls.Add(this.txtCordenadaX);
            this.Controls.Add(this.DibujarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DibujarButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtCordenadaX;
        private System.Windows.Forms.TextBox txtRectangulosCreados;
        private System.Windows.Forms.TextBox txtCordenadaY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

