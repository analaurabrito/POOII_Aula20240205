﻿namespace Aula20240205Botao
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bg1 = new System.Windows.Forms.Button();
            this.bg2 = new System.Windows.Forms.Button();
            this.bg3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(383, 170);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "0";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "click down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bg1
            // 
            this.bg1.BackColor = System.Drawing.Color.IndianRed;
            this.bg1.Location = new System.Drawing.Point(680, 93);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(56, 36);
            this.bg1.TabIndex = 3;
            this.bg1.UseVisualStyleBackColor = false;
            this.bg1.Click += new System.EventHandler(this.bg1_Click);
            // 
            // bg2
            // 
            this.bg2.BackColor = System.Drawing.Color.LightGreen;
            this.bg2.Location = new System.Drawing.Point(680, 144);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(55, 38);
            this.bg2.TabIndex = 4;
            this.bg2.UseVisualStyleBackColor = false;
            this.bg2.Click += new System.EventHandler(this.bg2_Click);
            // 
            // bg3
            // 
            this.bg3.BackColor = System.Drawing.Color.Plum;
            this.bg3.Location = new System.Drawing.Point(680, 199);
            this.bg3.Name = "bg3";
            this.bg3.Size = new System.Drawing.Size(53, 39);
            this.bg3.TabIndex = 5;
            this.bg3.UseVisualStyleBackColor = false;
            this.bg3.Click += new System.EventHandler(this.bg3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bg3);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bg1;
        private System.Windows.Forms.Button bg2;
        private System.Windows.Forms.Button bg3;
    }
}

