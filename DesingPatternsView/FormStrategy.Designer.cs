﻿namespace DesingPatternsView
{
    partial class FormStrategy
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
            this.btnImposto = new System.Windows.Forms.Button();
            this.btnInvestimento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAplicacao = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParticipantes = new System.Windows.Forms.TextBox();
            this.txtExemploPratico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDiagrama = new System.Windows.Forms.Panel();
            this.linkFecharDiagrama = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDiagrama = new System.Windows.Forms.Button();
            this.panelDiagrama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImposto
            // 
            this.btnImposto.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImposto.Location = new System.Drawing.Point(31, 210);
            this.btnImposto.Margin = new System.Windows.Forms.Padding(2);
            this.btnImposto.Name = "btnImposto";
            this.btnImposto.Size = new System.Drawing.Size(212, 52);
            this.btnImposto.TabIndex = 0;
            this.btnImposto.Text = "Executar exemplo imposto";
            this.btnImposto.UseVisualStyleBackColor = true;
            this.btnImposto.Click += new System.EventHandler(this.BtnImposto_Click);
            // 
            // btnInvestimento
            // 
            this.btnInvestimento.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestimento.Location = new System.Drawing.Point(364, 210);
            this.btnInvestimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvestimento.Name = "btnInvestimento";
            this.btnInvestimento.Size = new System.Drawing.Size(212, 52);
            this.btnInvestimento.TabIndex = 1;
            this.btnInvestimento.Text = "Executar exemplo investimento";
            this.btnInvestimento.UseVisualStyleBackColor = true;
            this.btnInvestimento.Click += new System.EventHandler(this.BtnInvestimento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aplicação:";
            // 
            // txtAplicacao
            // 
            this.txtAplicacao.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAplicacao.Location = new System.Drawing.Point(31, 110);
            this.txtAplicacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtAplicacao.Multiline = true;
            this.txtAplicacao.Name = "txtAplicacao";
            this.txtAplicacao.ReadOnly = true;
            this.txtAplicacao.Size = new System.Drawing.Size(545, 72);
            this.txtAplicacao.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(31, 50);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(260, 22);
            this.txtCategoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Participantes:";
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipantes.Location = new System.Drawing.Point(316, 50);
            this.txtParticipantes.Margin = new System.Windows.Forms.Padding(2);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.ReadOnly = true;
            this.txtParticipantes.Size = new System.Drawing.Size(260, 22);
            this.txtParticipantes.TabIndex = 7;
            // 
            // txtExemploPratico
            // 
            this.txtExemploPratico.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemploPratico.Location = new System.Drawing.Point(31, 306);
            this.txtExemploPratico.Margin = new System.Windows.Forms.Padding(2);
            this.txtExemploPratico.Multiline = true;
            this.txtExemploPratico.Name = "txtExemploPratico";
            this.txtExemploPratico.ReadOnly = true;
            this.txtExemploPratico.Size = new System.Drawing.Size(545, 76);
            this.txtExemploPratico.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resumo exemplo prático:";
            // 
            // panelDiagrama
            // 
            this.panelDiagrama.BackColor = System.Drawing.SystemColors.Control;
            this.panelDiagrama.Controls.Add(this.linkFecharDiagrama);
            this.panelDiagrama.Controls.Add(this.label5);
            this.panelDiagrama.Controls.Add(this.pictureBox1);
            this.panelDiagrama.Location = new System.Drawing.Point(31, 85);
            this.panelDiagrama.Name = "panelDiagrama";
            this.panelDiagrama.Size = new System.Drawing.Size(545, 297);
            this.panelDiagrama.TabIndex = 10;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesingPatternsView.Properties.Resources.estrutura_strategy;
            this.pictureBox1.Location = new System.Drawing.Point(48, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagrama.Location = new System.Drawing.Point(258, 210);
            this.btnDiagrama.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(93, 52);
            this.btnDiagrama.TabIndex = 11;
            this.btnDiagrama.Text = "Diagrama";
            this.btnDiagrama.UseVisualStyleBackColor = true;
            this.btnDiagrama.Click += new System.EventHandler(this.BtnDiagrama_Click);
            // 
            // FormStrategy
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
            this.Controls.Add(this.btnInvestimento);
            this.Controls.Add(this.btnImposto);
            this.Controls.Add(this.btnDiagrama);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStrategy";
            this.Text = "Strategy / Policy";
            this.panelDiagrama.ResumeLayout(false);
            this.panelDiagrama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImposto;
        private System.Windows.Forms.Button btnInvestimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAplicacao;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParticipantes;
        private System.Windows.Forms.TextBox txtExemploPratico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDiagrama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkFecharDiagrama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDiagrama;
    }
}

