namespace JuegoDados
{
    partial class Form1
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
            btn_jugar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            txt_tiradas = new TextBox();
            btn_reiniciar = new Button();
            btn_salir = new Button();
            label3 = new Label();
            txt_puntos = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btn_jugar
            // 
            btn_jugar.Location = new Point(24, 147);
            btn_jugar.Name = "btn_jugar";
            btn_jugar.Size = new Size(126, 55);
            btn_jugar.TabIndex = 0;
            btn_jugar.Text = "Tirar";
            btn_jugar.UseVisualStyleBackColor = true;
            btn_jugar.Click += btn_jugar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(327, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 146);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(534, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 146);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(327, 172);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 146);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(534, 172);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(180, 146);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(327, 333);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(180, 146);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(534, 333);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(180, 146);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // txt_tiradas
            // 
            txt_tiradas.Location = new Point(203, 49);
            txt_tiradas.Name = "txt_tiradas";
            txt_tiradas.Size = new Size(100, 23);
            txt_tiradas.TabIndex = 9;
            // 
            // btn_reiniciar
            // 
            btn_reiniciar.Location = new Point(24, 222);
            btn_reiniciar.Name = "btn_reiniciar";
            btn_reiniciar.Size = new Size(126, 55);
            btn_reiniciar.TabIndex = 10;
            btn_reiniciar.Text = "Limpiar";
            btn_reiniciar.UseVisualStyleBackColor = true;
            btn_reiniciar.Click += btn_reiniciar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(24, 297);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(126, 55);
            btn_salir.TabIndex = 11;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 52);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 12;
            label3.Text = "Ingresa el Numero de Tiradas:";
            // 
            // txt_puntos
            // 
            txt_puntos.Location = new Point(203, 94);
            txt_puntos.Name = "txt_puntos";
            txt_puntos.ReadOnly = true;
            txt_puntos.Size = new Size(100, 23);
            txt_puntos.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 102);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 14;
            label1.Text = "Puntos Obtenidos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 509);
            Controls.Add(label1);
            Controls.Add(txt_puntos);
            Controls.Add(label3);
            Controls.Add(btn_salir);
            Controls.Add(btn_reiniciar);
            Controls.Add(txt_tiradas);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_jugar);
            Name = "Form1";
            Text = "Juego de Dados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_jugar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txt_tiradas;
        private Button btn_reiniciar;
        private Button btn_salir;
        private Label label3;
        private TextBox txt_puntos;
        private Label label1;
    }
}