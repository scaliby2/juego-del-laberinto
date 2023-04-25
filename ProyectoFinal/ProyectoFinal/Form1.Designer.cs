namespace ProyectoFinal
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
            this.lblObstaculo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblReinicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.txtbxLaberinto = new System.Windows.Forms.TextBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObstaculo
            // 
            this.lblObstaculo.AutoSize = true;
            this.lblObstaculo.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstaculo.Location = new System.Drawing.Point(82, 122);
            this.lblObstaculo.Name = "lblObstaculo";
            this.lblObstaculo.Size = new System.Drawing.Size(132, 18);
            this.lblObstaculo.TabIndex = 17;
            this.lblObstaculo.Text = "X  >>> Obstaculo";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(137, 350);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(125, 18);
            this.lblTurno.TabIndex = 16;
            this.lblTurno.Text = "Turno actual: ";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(59, 42);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(614, 20);
            this.lblInstrucciones.TabIndex = 15;
            this.lblInstrucciones.Text = "Instrucciones:  Mueve a tu personaje \"J\" con las flechas de tu teclado.";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(82, 247);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(111, 18);
            this.lblJugador.TabIndex = 14;
            this.lblJugador.Text = "J  >>> Jugador";
            // 
            // lblReinicio
            // 
            this.lblReinicio.AutoSize = true;
            this.lblReinicio.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReinicio.Location = new System.Drawing.Point(82, 213);
            this.lblReinicio.Name = "lblReinicio";
            this.lblReinicio.Size = new System.Drawing.Size(195, 18);
            this.lblReinicio.TabIndex = 13;
            this.lblReinicio.Text = "R  >>> Reregesas al inicio";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(82, 182);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(83, 18);
            this.lblFinal.TabIndex = 12;
            this.lblFinal.Text = "F  >>> Final";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(82, 151);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(85, 18);
            this.lblInicio.TabIndex = 11;
            this.lblInicio.Text = "I  >>> Inicio";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.labelInfo1.Location = new System.Drawing.Point(82, 122);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(0, 16);
            this.labelInfo1.TabIndex = 10;
            // 
            // txtbxLaberinto
            // 
            this.txtbxLaberinto.Enabled = false;
            this.txtbxLaberinto.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLaberinto.Location = new System.Drawing.Point(377, 93);
            this.txtbxLaberinto.Multiline = true;
            this.txtbxLaberinto.Name = "txtbxLaberinto";
            this.txtbxLaberinto.Size = new System.Drawing.Size(284, 275);
            this.txtbxLaberinto.TabIndex = 9;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(68, 79);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(78, 18);
            this.lblLeyenda.TabIndex = 18;
            this.lblLeyenda.Text = "Leyenda:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(71, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 27);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Iniciar Juego";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(750, 428);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.lblObstaculo);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.lblReinicio);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.txtbxLaberinto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObstaculo;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblReinicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.TextBox txtbxLaberinto;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button btnStart;
    }
}

