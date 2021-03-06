﻿namespace DesingPatternsView
{
    partial class FormTemplateMethod
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
            this.panelDiagrama = new System.Windows.Forms.Panel();
            this.linkFecharDiagrama = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExemploPratico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParticipantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAplicacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImposto = new System.Windows.Forms.Button();
            this.btnDiagrama = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDiagrama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDiagrama
            // 
            this.panelDiagrama.BackColor = System.Drawing.SystemColors.Control;
            this.panelDiagrama.Controls.Add(this.linkFecharDiagrama);
            this.panelDiagrama.Controls.Add(this.label5);
            this.panelDiagrama.Controls.Add(this.pictureBox1);
            this.panelDiagrama.Location = new System.Drawing.Point(36, 80);
            this.panelDiagrama.Name = "panelDiagrama";
            this.panelDiagrama.Size = new System.Drawing.Size(545, 297);
            this.panelDiagrama.TabIndex = 33;
            this.panelDiagrama.Visible = false;
            // 
            // linkFecharDiagrama
            // 
            this.linkFecharDiagrama.AutoSize = true;
            this.linkFecharDiagrama.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFecharDiagrama.LinkColor = System.Drawing.Color.Black;
            this.linkFecharDiagrama.Location = new System.Drawing.Point(486, 11);
            this.linkFecharDiagrama.Name = "linkFecharDiagrama";
            this.linkFecharDiagrama.Size = new System.Drawing.Size(46, 15);
            this.linkFecharDiagrama.TabIndex = 4;
            this.linkFecharDiagrama.TabStop = true;
            this.linkFecharDiagrama.Text = "Fechar";
            this.linkFecharDiagrama.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFecharDiagrama_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Diagrama";
            // 
            // txtExemploPratico
            // 
            this.txtExemploPratico.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemploPratico.Location = new System.Drawing.Point(36, 301);
            this.txtExemploPratico.Margin = new System.Windows.Forms.Padding(2);
            this.txtExemploPratico.Multiline = true;
            this.txtExemploPratico.Name = "txtExemploPratico";
            this.txtExemploPratico.ReadOnly = true;
            this.txtExemploPratico.Size = new System.Drawing.Size(545, 76);
            this.txtExemploPratico.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Resumo exemplo prático:";
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipantes.Location = new System.Drawing.Point(321, 45);
            this.txtParticipantes.Margin = new System.Windows.Forms.Padding(2);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.ReadOnly = true;
            this.txtParticipantes.Size = new System.Drawing.Size(260, 22);
            this.txtParticipantes.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Participantes:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(36, 45);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(260, 22);
            this.txtCategoria.TabIndex = 28;
            // 
            // txtAplicacao
            // 
            this.txtAplicacao.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAplicacao.Location = new System.Drawing.Point(36, 105);
            this.txtAplicacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtAplicacao.Multiline = true;
            this.txtAplicacao.Name = "txtAplicacao";
            this.txtAplicacao.ReadOnly = true;
            this.txtAplicacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAplicacao.Size = new System.Drawing.Size(545, 72);
            this.txtAplicacao.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Aplicação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Categoria:";
            // 
            // btnImposto
            // 
            this.btnImposto.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImposto.Location = new System.Drawing.Point(36, 205);
            this.btnImposto.Margin = new System.Windows.Forms.Padding(2);
            this.btnImposto.Name = "btnImposto";
            this.btnImposto.Size = new System.Drawing.Size(212, 52);
            this.btnImposto.TabIndex = 24;
            this.btnImposto.Text = "Executar exemplo imposto";
            this.btnImposto.UseVisualStyleBackColor = true;
            this.btnImposto.Click += new System.EventHandler(this.BtnImposto_Click);
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagrama.Location = new System.Drawing.Point(263, 205);
            this.btnDiagrama.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(93, 52);
            this.btnDiagrama.TabIndex = 34;
            this.btnDiagrama.Text = "Diagrama";
            this.btnDiagrama.UseVisualStyleBackColor = true;
            this.btnDiagrama.Click += new System.EventHandler(this.BtnDiagrama_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(369, 205);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(212, 52);
            this.btnRelatorio.TabIndex = 35;
            this.btnRelatorio.Text = "Executar exemplo relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesingPatternsView.Properties.Resources.estrutura_template_method;
            this.pictureBox1.Location = new System.Drawing.Point(75, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormTemplateMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 396);
            this.Controls.Add(this.panelDiagrama);
            this.Controls.Add(this.txtExemploPratico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParticipantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtAplicacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImposto);
            this.Controls.Add(this.btnDiagrama);
            this.Controls.Add(this.btnRelatorio);
            this.Name = "FormTemplateMethod";
            this.Text = "Template Method";
            this.panelDiagrama.ResumeLayout(false);
            this.panelDiagrama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDiagrama;
        private System.Windows.Forms.LinkLabel linkFecharDiagrama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtExemploPratico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParticipantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAplicacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImposto;
        private System.Windows.Forms.Button btnDiagrama;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRelatorio;
    }
}