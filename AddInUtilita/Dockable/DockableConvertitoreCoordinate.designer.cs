﻿namespace AddInUtilita
{
    partial class DockableConvertitoreCoordinate
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
            this.BottoneInvesione = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x_input = new System.Windows.Forms.TextBox();
            this.y_input = new System.Windows.Forms.TextBox();
            this.BottoneConverti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LATITUDINE = new System.Windows.Forms.TextBox();
            this.LONGITUDINE = new System.Windows.Forms.TextBox();
            this.Codice_EPSG = new System.Windows.Forms.TextBox();
            this.buttonePulitore = new System.Windows.Forms.Button();
            this.SR_Planare = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.svuotaTutto = new System.Windows.Forms.Button();
            this.distanzaMetrica = new System.Windows.Forms.TextBox();
            this.calcolaDistanzaMetrica = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.latiPunto2 = new System.Windows.Forms.TextBox();
            this.longiPunto2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.latiPunto1 = new System.Windows.Forms.TextBox();
            this.longiPunto1 = new System.Windows.Forms.TextBox();
            this.SR_Planare.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottoneInvesione
            // 
            this.BottoneInvesione.Location = new System.Drawing.Point(400, 285);
            this.BottoneInvesione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BottoneInvesione.Name = "BottoneInvesione";
            this.BottoneInvesione.Size = new System.Drawing.Size(190, 62);
            this.BottoneInvesione.TabIndex = 35;
            this.BottoneInvesione.Text = "Inverti";
            this.BottoneInvesione.UseVisualStyleBackColor = true;
            this.BottoneInvesione.Click += new System.EventHandler(this.BottoneInvesione_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 46);
            this.label3.TabIndex = 34;
            this.label3.Text = "Y - Planare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(236, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 41);
            this.label5.TabIndex = 33;
            this.label5.Text = "Codice EPSG SR Proiettato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "E - Longitudine Ф";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 46);
            this.label4.TabIndex = 31;
            this.label4.Text = "N - Latitudine λ";
            // 
            // x_input
            // 
            this.x_input.Location = new System.Drawing.Point(15, 144);
            this.x_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x_input.Name = "x_input";
            this.x_input.Size = new System.Drawing.Size(274, 26);
            this.x_input.TabIndex = 30;
            // 
            // y_input
            // 
            this.y_input.Location = new System.Drawing.Point(15, 285);
            this.y_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.y_input.Name = "y_input";
            this.y_input.Size = new System.Drawing.Size(274, 26);
            this.y_input.TabIndex = 29;
            // 
            // BottoneConverti
            // 
            this.BottoneConverti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottoneConverti.Location = new System.Drawing.Point(354, 98);
            this.BottoneConverti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BottoneConverti.Name = "BottoneConverti";
            this.BottoneConverti.Size = new System.Drawing.Size(297, 158);
            this.BottoneConverti.TabIndex = 28;
            this.BottoneConverti.Text = "Converti Coordinate";
            this.BottoneConverti.UseVisualStyleBackColor = true;
            this.BottoneConverti.Click += new System.EventHandler(this.BottoneConverti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 46);
            this.label2.TabIndex = 27;
            this.label2.Text = "X - Planare";
            // 
            // LATITUDINE
            // 
            this.LATITUDINE.Location = new System.Drawing.Point(736, 285);
            this.LATITUDINE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LATITUDINE.Name = "LATITUDINE";
            this.LATITUDINE.Size = new System.Drawing.Size(274, 26);
            this.LATITUDINE.TabIndex = 26;
            // 
            // LONGITUDINE
            // 
            this.LONGITUDINE.Location = new System.Drawing.Point(736, 144);
            this.LONGITUDINE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LONGITUDINE.Name = "LONGITUDINE";
            this.LONGITUDINE.Size = new System.Drawing.Size(274, 26);
            this.LONGITUDINE.TabIndex = 25;
            // 
            // Codice_EPSG
            // 
            this.Codice_EPSG.Location = new System.Drawing.Point(704, 26);
            this.Codice_EPSG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codice_EPSG.Name = "Codice_EPSG";
            this.Codice_EPSG.Size = new System.Drawing.Size(187, 26);
            this.Codice_EPSG.TabIndex = 24;
            // 
            // buttonePulitore
            // 
            this.buttonePulitore.Location = new System.Drawing.Point(15, 387);
            this.buttonePulitore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonePulitore.Name = "buttonePulitore";
            this.buttonePulitore.Size = new System.Drawing.Size(998, 52);
            this.buttonePulitore.TabIndex = 36;
            this.buttonePulitore.Text = "Svuota tutto";
            this.buttonePulitore.UseVisualStyleBackColor = true;
            this.buttonePulitore.Click += new System.EventHandler(this.buttonePulitore_Click);
            // 
            // SR_Planare
            // 
            this.SR_Planare.Controls.Add(this.Codice_EPSG);
            this.SR_Planare.Controls.Add(this.label5);
            this.SR_Planare.Location = new System.Drawing.Point(14, 22);
            this.SR_Planare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SR_Planare.Name = "SR_Planare";
            this.SR_Planare.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SR_Planare.Size = new System.Drawing.Size(1047, 76);
            this.SR_Planare.TabIndex = 37;
            this.SR_Planare.TabStop = false;
            this.SR_Planare.Text = "SR Planare";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonePulitore);
            this.groupBox1.Controls.Add(this.BottoneInvesione);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.x_input);
            this.groupBox1.Controls.Add(this.y_input);
            this.groupBox1.Controls.Add(this.BottoneConverti);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LATITUDINE);
            this.groupBox1.Controls.Add(this.LONGITUDINE);
            this.groupBox1.Location = new System.Drawing.Point(14, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1082, 450);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinate";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(-2, 4);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1112, 606);
            this.TabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.SR_Planare);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1104, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proietta Coordinate Angolari";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.svuotaTutto);
            this.tabPage2.Controls.Add(this.distanzaMetrica);
            this.tabPage2.Controls.Add(this.calcolaDistanzaMetrica);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1104, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calcola Distanza Metrica fra Coordinate Angolari";
            // 
            // svuotaTutto
            // 
            this.svuotaTutto.Location = new System.Drawing.Point(754, 9);
            this.svuotaTutto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.svuotaTutto.Name = "svuotaTutto";
            this.svuotaTutto.Size = new System.Drawing.Size(285, 50);
            this.svuotaTutto.TabIndex = 4;
            this.svuotaTutto.Text = "Svuota tutto";
            this.svuotaTutto.UseVisualStyleBackColor = true;
            this.svuotaTutto.Click += new System.EventHandler(this.svuotaTutto_Click);
            // 
            // distanzaMetrica
            // 
            this.distanzaMetrica.Location = new System.Drawing.Point(556, 459);
            this.distanzaMetrica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.distanzaMetrica.Name = "distanzaMetrica";
            this.distanzaMetrica.Size = new System.Drawing.Size(376, 26);
            this.distanzaMetrica.TabIndex = 3;
            // 
            // calcolaDistanzaMetrica
            // 
            this.calcolaDistanzaMetrica.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcolaDistanzaMetrica.Location = new System.Drawing.Point(58, 412);
            this.calcolaDistanzaMetrica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcolaDistanzaMetrica.Name = "calcolaDistanzaMetrica";
            this.calcolaDistanzaMetrica.Size = new System.Drawing.Size(382, 117);
            this.calcolaDistanzaMetrica.TabIndex = 2;
            this.calcolaDistanzaMetrica.Text = "Calcola Distanza Metrica";
            this.calcolaDistanzaMetrica.UseVisualStyleBackColor = true;
            this.calcolaDistanzaMetrica.Click += new System.EventHandler(this.calcolaDistanzaMetrica_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.latiPunto2);
            this.groupBox3.Controls.Add(this.longiPunto2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(27, 250);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1012, 130);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Secondo Punto";
            // 
            // latiPunto2
            // 
            this.latiPunto2.Location = new System.Drawing.Point(566, 82);
            this.latiPunto2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.latiPunto2.Name = "latiPunto2";
            this.latiPunto2.Size = new System.Drawing.Size(300, 26);
            this.latiPunto2.TabIndex = 37;
            // 
            // longiPunto2
            // 
            this.longiPunto2.Location = new System.Drawing.Point(566, 24);
            this.longiPunto2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.longiPunto2.Name = "longiPunto2";
            this.longiPunto2.Size = new System.Drawing.Size(300, 26);
            this.longiPunto2.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 37);
            this.label9.TabIndex = 35;
            this.label9.Text = "N - Latitudine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 37);
            this.label7.TabIndex = 34;
            this.label7.Text = "E - Longitudine";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.latiPunto1);
            this.groupBox2.Controls.Add(this.longiPunto1);
            this.groupBox2.Location = new System.Drawing.Point(27, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1012, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primo Punto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 37);
            this.label8.TabIndex = 34;
            this.label8.Text = "N - Latitudine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 37);
            this.label6.TabIndex = 33;
            this.label6.Text = "E - Longitudine";
            // 
            // latiPunto1
            // 
            this.latiPunto1.Location = new System.Drawing.Point(566, 87);
            this.latiPunto1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.latiPunto1.Name = "latiPunto1";
            this.latiPunto1.Size = new System.Drawing.Size(300, 26);
            this.latiPunto1.TabIndex = 1;
            // 
            // longiPunto1
            // 
            this.longiPunto1.Location = new System.Drawing.Point(566, 28);
            this.longiPunto1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.longiPunto1.Name = "longiPunto1";
            this.longiPunto1.Size = new System.Drawing.Size(300, 26);
            this.longiPunto1.TabIndex = 0;
            // 
            // DockableConvertitoreCoordinate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DockableConvertitoreCoordinate";
            this.Size = new System.Drawing.Size(1114, 614);
            this.SR_Planare.ResumeLayout(false);
            this.SR_Planare.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BottoneInvesione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x_input;
        private System.Windows.Forms.TextBox y_input;
        private System.Windows.Forms.Button BottoneConverti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LATITUDINE;
        private System.Windows.Forms.TextBox LONGITUDINE;
        private System.Windows.Forms.TextBox Codice_EPSG;
        private System.Windows.Forms.Button buttonePulitore;
        private System.Windows.Forms.GroupBox SR_Planare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox distanzaMetrica;
        private System.Windows.Forms.Button calcolaDistanzaMetrica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox latiPunto2;
        private System.Windows.Forms.TextBox longiPunto2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox latiPunto1;
        private System.Windows.Forms.TextBox longiPunto1;
        private System.Windows.Forms.Button svuotaTutto;

    }
}
