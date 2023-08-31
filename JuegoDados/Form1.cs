using System.Security.Cryptography;

namespace JuegoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            int numerodetiros = 1;
            int numerodetirosoriginal = 0;
            int dado = 0;
            int sumapuntos = 0;
            Random dadoaleatorio = new Random();

            if (Convert.ToInt32(txt_tiradas.Text) > 6)
            {
                MessageBox.Show("El numero ingresado no puede ser mayor a 6");


            }
            else
            {
                numerodetirosoriginal = Convert.ToInt32(txt_tiradas.Text);
                while (numerodetirosoriginal >= numerodetiros)
                {
                    //   int figura = 1;
                    dado = dadoaleatorio.Next(1, 7);
                    switch (numerodetiros)
                    {
                        case 1:
                            // Instrucciones
                            if (dado == 1)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox1.Image = Image.FromFile("dado1.jpg");

                            }
                            if (dado == 2)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox1.Image = Image.FromFile("dado2.jpg");

                            }
                            if (dado == 3)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox1.Image = Image.FromFile("dado3.jpg");

                            }
                            if (dado == 4)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox1.Image = Image.FromFile("dado4.jpg");


                            }
                            if (dado == 5)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox1.Image = Image.FromFile("dado5.jpg");

                            }
                            if (dado == 6)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox1.Image = Image.FromFile("dado6.jpg");

                            }
                            break;
                        case 2:

                            //  Instrucciones
                            if (dado == 1)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox2.Image = Image.FromFile("dado1.jpg");

                            }
                            if (dado == 2)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox2.Image = Image.FromFile("dado2.jpg");

                            }
                            if (dado == 3)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox2.Image = Image.FromFile("dado3.jpg");

                            }
                            if (dado == 4)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox2.Image = Image.FromFile("dado4.jpg");


                            }
                            if (dado == 5)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox2.Image = Image.FromFile("dado5.jpg");

                            }
                            if (dado == 6)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox2.Image = Image.FromFile("dado6.jpg");

                            }

                            break;
                        case 3:
                            //Instrucciones
                            if (dado == 1)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox3.Image = Image.FromFile("dado1.jpg");

                            }
                            if (dado == 2)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox3.Image = Image.FromFile("dado2.jpg");

                            }
                            if (dado == 3)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox3.Image = Image.FromFile("dado3.jpg");

                            }
                            if (dado == 4)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox3.Image = Image.FromFile("dado4.jpg");


                            }
                            if (dado == 5)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox3.Image = Image.FromFile("dado5.jpg");

                            }
                            if (dado == 6)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox3.Image = Image.FromFile("dado6.jpg");

                            }
                            break;
                        case 4:
                            //Instrucciones
                            if (dado == 1)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox4.Image = Image.FromFile("dado1.jpg");

                            }
                            if (dado == 2)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox4.Image = Image.FromFile("dado2.jpg");

                            }
                            if (dado == 3)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox4.Image = Image.FromFile("dado3.jpg");

                            }
                            if (dado == 4)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox4.Image = Image.FromFile("dado4.jpg");


                            }
                            if (dado == 5)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox4.Image = Image.FromFile("dado5.jpg");

                            }
                            if (dado == 6)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox4.Image = Image.FromFile("dado6.jpg");

                            }
                            break;
                        case 5:
                            //Instrucciones
                            if (dado == 1)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox5.Image = Image.FromFile("dado1.jpg");

                            }
                            if (dado == 2)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;

                                pictureBox5.Image = Image.FromFile("dado2.jpg");

                            }
                            if (dado == 3)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox5.Image = Image.FromFile("dado3.jpg");

                            }
                            if (dado == 4)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox5.Image = Image.FromFile("dado4.jpg");


                            }
                            if (dado == 5)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox5.Image = Image.FromFile("dado5.jpg");

                            }
                            if (dado == 6)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox5.Image = Image.FromFile("dado6.jpg");

                            }
                            break;

                        case 6:
                            //Instrucciones
                            if (dado == 1)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox6.Image = Image.FromFile("dado1.jpg");

                            }
                            if (dado == 2)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox6.Image = Image.FromFile("dado2.jpg");

                            }
                            if (dado == 3)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox6.Image = Image.FromFile("dado3.jpg");

                            }
                            if (dado == 4)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox6.Image = Image.FromFile("dado4.jpg");


                            }
                            if (dado == 5)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox6.Image = Image.FromFile("dado5.jpg");

                            }
                            if (dado == 6)
                            {
                                numerodetiros = numerodetiros + 1;
                                sumapuntos = dado + sumapuntos;
                                pictureBox6.Image = Image.FromFile("dado6.jpg");

                            }
                            break;

                        default:
                            // Instrucciones
                            break;
                    }





                }
                txt_puntos.Text = sumapuntos.ToString();
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("dado0.jpg");
            pictureBox2.Image = Image.FromFile("dado0.jpg");
            pictureBox3.Image = Image.FromFile("dado0.jpg");
            pictureBox4.Image = Image.FromFile("dado0.jpg");
            pictureBox5.Image = Image.FromFile("dado0.jpg");
            pictureBox6.Image = Image.FromFile("dado0.jpg");
            txt_tiradas.Text = "";
            txt_puntos.Text = "";

        }
    }
}