namespace ExpresionesNodos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expresion";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(316, 55);
            this.txtExpresion.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(421, 34);
            this.txtExpresion.TabIndex = 1;
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(41, 129);
            this.BtnEjecutar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(697, 41);
            this.BtnEjecutar.TabIndex = 2;
            this.BtnEjecutar.Text = "Resolver";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(814, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preorden:";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPost.Location = new System.Drawing.Point(903, 205);
            this.lblPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(0, 28);
            this.lblPost.TabIndex = 4;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIn.Location = new System.Drawing.Point(903, 129);
            this.lblIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(0, 28);
            this.lblIn.TabIndex = 5;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPre.Location = new System.Drawing.Point(903, 51);
            this.lblPre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(0, 28);
            this.lblPre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(814, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Postorden:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(814, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Inorden:";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(294, 257);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(1000, 540);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1486, 824);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Expresiones";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtExpresion;
        private Button BtnEjecutar;
        private Label label2;
        private Label lblPost;
        private Label lblIn;
        private Label lblPre;
        private Label label6;
        private Label label7;
        private PictureBox pbImagen;
    }
}