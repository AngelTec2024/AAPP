﻿namespace PPPP
{
    partial class InterfazEdicion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnPrevisualizacion = new System.Windows.Forms.Panel();
            this.pbRecortar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resoluciones = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            this.x5X7 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NCopias = new System.Windows.Forms.NumericUpDown();
            this.PanelPre = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Acercar = new System.Windows.Forms.Button();
            this.Alejar = new System.Windows.Forms.Button();
            this.pbPrevisualizacion = new System.Windows.Forms.PictureBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecortar)).BeginInit();
            this.resoluciones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NCopias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevisualizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrevisualizacion
            // 
            this.pnPrevisualizacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnPrevisualizacion.Location = new System.Drawing.Point(229, 47);
            this.pnPrevisualizacion.Name = "pnPrevisualizacion";
            this.pnPrevisualizacion.Size = new System.Drawing.Size(445, 356);
            this.pnPrevisualizacion.TabIndex = 0;
            this.pnPrevisualizacion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPrevisualizacion_Paint);
            // 
            // pbRecortar
            // 
            this.pbRecortar.Location = new System.Drawing.Point(701, 28);
            this.pbRecortar.Name = "pbRecortar";
            this.pbRecortar.Size = new System.Drawing.Size(445, 355);
            this.pbRecortar.TabIndex = 11;
            this.pbRecortar.TabStop = false;
            this.pbRecortar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbRecortar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(68, 658);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(254, 79);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(77, 599);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(245, 62);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barra de herramientas";
            // 
            // resoluciones
            // 
            this.resoluciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resoluciones.Controls.Add(this.button10);
            this.resoluciones.Controls.Add(this.radioButton5);
            this.resoluciones.Controls.Add(this.button9);
            this.resoluciones.Controls.Add(this.x5X7);
            this.resoluciones.Controls.Add(this.radioButton4);
            this.resoluciones.Controls.Add(this.radioButton3);
            this.resoluciones.Controls.Add(this.radioButton2);
            this.resoluciones.Controls.Add(this.radioButton1);
            this.resoluciones.Location = new System.Drawing.Point(101, 47);
            this.resoluciones.Name = "resoluciones";
            this.resoluciones.Size = new System.Drawing.Size(126, 238);
            this.resoluciones.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(21, 191);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "TamañoInfantil";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.inInf);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(21, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(21, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "4X6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.in4x6);
            // 
            // x5X7
            // 
            this.x5X7.Location = new System.Drawing.Point(21, 132);
            this.x5X7.Name = "x5X7";
            this.x5X7.Size = new System.Drawing.Size(96, 23);
            this.x5X7.TabIndex = 11;
            this.x5X7.Text = "5X7";
            this.x5X7.UseVisualStyleBackColor = true;
            this.x5X7.Click += new System.EventHandler(this.in4x6);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 86);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4x6";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tamaño Infantil";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5x7";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.crop);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 212);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajustar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crop
            // 
            this.crop.Location = new System.Drawing.Point(0, 36);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(85, 40);
            this.crop.TabIndex = 7;
            this.crop.Text = "Recortar";
            this.crop.UseVisualStyleBackColor = true;
            this.crop.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Resolucion de img";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "AtoAjustarImgH";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp\"";
            // 
            // NCopias
            // 
            this.NCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCopias.Location = new System.Drawing.Point(498, 492);
            this.NCopias.Name = "NCopias";
            this.NCopias.Size = new System.Drawing.Size(111, 35);
            this.NCopias.TabIndex = 8;
            this.NCopias.ValueChanged += new System.EventHandler(this.NCopias_ValueChanged);
            // 
            // PanelPre
            // 
            this.PanelPre.AutoScroll = true;
            this.PanelPre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelPre.Location = new System.Drawing.Point(1178, 28);
            this.PanelPre.Name = "PanelPre";
            this.PanelPre.Size = new System.Drawing.Size(336, 427);
            this.PanelPre.TabIndex = 9;
            this.PanelPre.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPre_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero de Copias";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Acercar
            // 
            this.Acercar.BackgroundImage = global::PPPP.Properties.Resources.boton_para_acercar__1_;
            this.Acercar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Acercar.Location = new System.Drawing.Point(1420, 477);
            this.Acercar.Name = "Acercar";
            this.Acercar.Size = new System.Drawing.Size(70, 70);
            this.Acercar.TabIndex = 7;
            this.Acercar.UseVisualStyleBackColor = true;
            this.Acercar.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // Alejar
            // 
            this.Alejar.BackgroundImage = global::PPPP.Properties.Resources.lupa_con_signo_menos__2_;
            this.Alejar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Alejar.Location = new System.Drawing.Point(1249, 477);
            this.Alejar.Name = "Alejar";
            this.Alejar.Size = new System.Drawing.Size(70, 70);
            this.Alejar.TabIndex = 6;
            this.Alejar.UseVisualStyleBackColor = true;
            this.Alejar.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // pbPrevisualizacion
            // 
            this.pbPrevisualizacion.Location = new System.Drawing.Point(715, 534);
            this.pbPrevisualizacion.Name = "pbPrevisualizacion";
            this.pbPrevisualizacion.Size = new System.Drawing.Size(291, 254);
            this.pbPrevisualizacion.TabIndex = 12;
            this.pbPrevisualizacion.TabStop = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(88, 359);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 13;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // InterfazEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1526, 749);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.pbRecortar);
            this.Controls.Add(this.pbPrevisualizacion);
            this.Controls.Add(this.PanelPre);
            this.Controls.Add(this.Acercar);
            this.Controls.Add(this.Alejar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NCopias);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resoluciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnPrevisualizacion);
            this.Name = "InterfazEdicion";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecortar)).EndInit();
            this.resoluciones.ResumeLayout(false);
            this.resoluciones.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NCopias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevisualizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnPrevisualizacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel resoluciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Alejar;
        private System.Windows.Forms.Button Acercar;
        private System.Windows.Forms.NumericUpDown NCopias;
        private System.Windows.Forms.Panel PanelPre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button x5X7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pbRecortar;
        private System.Windows.Forms.PictureBox pbPrevisualizacion;
        private System.Windows.Forms.Button btnAplicar;
    }
}

