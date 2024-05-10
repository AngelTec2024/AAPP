using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PPPP
{
    public partial class InterfazEdicion : Form
    {
        Metodos Metodo = new Metodos();//llamar Clase
        int inX; int inY;
        string FName;
        public StreamReader lector;
        PictureBox Hoja;
        PictureBox Imagen = new PictureBox();
        
        int NC;
        double zoomFactor = 1.0;

        public InterfazEdicion()
        {

            InitializeComponent();
            Metodos Metodos = new Metodos();   
            resoluciones.Visible = false;

        }

        private void AbrirImagen()
        {
            try
            {
                openFileDialog1.ShowDialog();
                FName = openFileDialog1.FileName;
                Console.WriteLine(FName);
                Imagen.Size = pnPrevisualizacion.Size; // Tamaño de la imagen dentro del panel
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage; // Escala la imagen para ajustarse al PictureBox
                Imagen.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName); // Carga la imagen
                pnPrevisualizacion.Controls.Add(Imagen);// Agrega el PictureBox al panel

            }
            catch
            {
                //error 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            InterfazPrincipal interfazPrincipal = new InterfazPrincipal();

            // Mostrar el nuevo formulario
            this.Visible = false;
            interfazPrincipal.Show();


        }


        public void TPHoja(int tipoH)
        {
            Size tamañoHoja;
            switch (tipoH)
            {
                case 1: // Carta
                    tamañoHoja = new Size(2550, 3300); // Tamaño en píxeles (ancho x alto)
                    break;

                case 2: // Oficio
                    tamañoHoja = new Size(2550, 4200); // Tamaño en píxeles (ancho x alto)
                    break;

                case 3: // A4
                    tamañoHoja = new Size(2480, 3508); // Tamaño en píxeles (ancho x alto)
                    break;

                // ------------------- 01/05/24 -----------------------------------------------
                case 4:
                    tamañoHoja = new Size(3508, 4961);
                    break;

                case 5:
                    tamañoHoja = new Size(5100, 6600);
                    break;


                default:
                    MessageBox.Show("Tipo de número no válido. Por favor, elija 1 para Carta o 2 para Oficio.");
                    return;
            }

            // Crear el PictureBox para la previsualización de la hoja
            Hoja = new PictureBox();

            Hoja.Left = 50;
            Hoja.BackColor = Color.White;
            Hoja.Top = 50;
            Hoja.Size = tamañoHoja; // Tamaño del PictureBox igual al tamaño de la hoja
            Hoja.SizeMode = PictureBoxSizeMode.Zoom; // Escalar la imagen para ajustarse al PictureBox

            // Cargar la imagen de la hoja en el PictureBox
            // (Asegúrate de reemplazar "HojaOriginal" con el nombre de tu imagen)
            //Hoja.Image = Properties.Resources.HojaOriginal; // Cambiar "HojaOriginal" por el nombre de tu imagen
            Hoja.Tag = tamañoHoja; // Almacenar el tamaño original de la imagen en el Tag del PictureBox
            //Hoja.SizeChanged += Hoja_SizeChanged;
            // Agregar el PictureBox al formulario
            this.PanelPre.Controls.Add(Hoja);

            // Agregar controles de zoom (por ejemplo, botones de zoom) al formulario
            // (Agrega aquí los controles que permitirán al usuario hacer zoom en la imagen)
            AbrirImagen(); // SELECCIONAR IMAGEN AL ABRIR LA VENTANA
        }


        private void ZoomIn(PictureBox pictureBox)
        {
            Size tamañoOriginal = (Size)pictureBox.Tag;
            Size tamañoActual = pictureBox.ClientSize;
            int nuevoAncho = (int)(tamañoActual.Width * 1.1);
            int nuevoAlto = (int)(tamañoActual.Height * 1.1);
            nuevoAncho = Math.Min(nuevoAncho, tamañoOriginal.Width);
            nuevoAlto = Math.Min(nuevoAlto, tamañoOriginal.Height);
            pictureBox.ClientSize = new Size(nuevoAncho, nuevoAlto);
        }

        // Método para alejar la imagen de la hoja
        private void ZoomOut(PictureBox pictureBox)
        {
            Size tamañoActual = pictureBox.ClientSize;
            int nuevoAncho = (int)(tamañoActual.Width / 1.1);
            int nuevoAlto = (int)(tamañoActual.Height / 1.1);
            pictureBox.ClientSize = new Size(nuevoAncho, nuevoAlto);
        }





        private void btnZoomIn_Click(object sender, EventArgs e)
        {
             ZoomIn(Hoja);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut(Hoja);

        }


        private void NCopias_ValueChanged(object sender, EventArgs e)
        {
            NC = (int)NCopias.Value;
            AgrImgHoj(NC, zoomFactor);

        }

        private void AgrImgHoj(int nC, double zoomFactor)
        {
            Hoja.Controls.Clear(); // Limpiar hoja

            int hojaAncho = Hoja.Width; // Ancho del contenedor Hoja
            int hojaAlto = Hoja.Height; // Alto del contenedor Hoja

            int posX = 0; // Posición horizontal inicial
            int posY = 0; // Posición vertical inicial
            int filaActualAncho = 0; // Ancho actual de la fila
            int maxAlturaFila = 0; // Altura máxima de la fila actual

            // Iterar sobre cada imagen
            for (int i = 0; i < nC; i++)
            {
                // Crear un nuevo PictureBox para la imagen
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Image = Imagen.Image; // Asignar la imagen
                pictureBox1.Size = Imagen.Size; // Asignar el tamaño de la imagen

                // Verificar si la imagen cabe en la fila actual
                if (filaActualAncho + pictureBox1.Width <= hojaAncho)
                {
                    // La imagen cabe en la fila actual
                    pictureBox1.Location = new Point(posX + filaActualAncho, posY); // Posicionar la imagen en la fila
                    filaActualAncho += pictureBox1.Width + 10; // Actualizar el ancho de la fila con el espacio entre imágenes

                    // Actualizar la altura máxima de la fila
                    if (pictureBox1.Height > maxAlturaFila)
                    {
                        maxAlturaFila = pictureBox1.Height;
                    }
                }
                else
                {
                    // La imagen no cabe en la fila actual, mover a la siguiente fila
                    posY += maxAlturaFila + 10; // Mover a la siguiente fila, usando la altura máxima de la fila actual
                    posX = 0; // Reiniciar la posición horizontal
                    filaActualAncho = pictureBox1.Width + 10; // Establecer el ancho de la nueva fila
                    maxAlturaFila = pictureBox1.Height; // Restablecer la altura máxima de la fila actual
                    pictureBox1.Location = new Point(posX, posY); // Posicionar la imagen en la nueva fila
                }

                // Verificar si la imagen cabe en el contenedor en términos de altura
                if (posY + pictureBox1.Height <= hojaAlto)
                {
                    // Agregar el PictureBox al PictureBox de la hoja solo si cabe en el contenedor en términos de altura
                    Hoja.Controls.Add(pictureBox1);
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnPrevisualizacion_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear un bitmap del tamaño del PictureBox
            Bitmap bmp = new Bitmap(Hoja.Width, Hoja.Height);

            // Dibujar el contenido del PictureBox en el bitmap
            Hoja.DrawToBitmap(bmp, new Rectangle(0, 0, Hoja.Width, Hoja.Height));
            // Crear un cuadro de diálogo para guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de imagen (*.jpg)|*.jpg|Documentos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar como";

            // Si el usuario selecciona una ruta y hace clic en "Guardar"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
 
                    bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("La hoja se ha guardado correctamente en formato JPG.");
 
            }

            // Liberar los recursos del bitmap
            bmp.Dispose();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

            

        private void button4_Click(object sender, EventArgs e)
        {

            if (resoluciones.Visible == true)
            {
                resoluciones.Visible = false;
            }
            else {
                resoluciones.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void in5x7(object sender, EventArgs e)
        {
            pnPrevisualizacion.Controls.Clear();
            Hoja.Controls.Clear();
            Metodos llamada = new Metodos();
            inX = 5; inY = 7;
            llamada.AddImageToPictureBox(openFileDialog1.FileName, Imagen, inX, inY);
            pnPrevisualizacion.Controls.Add(Imagen);
        }

        private void in4x6(object sender, EventArgs e)
        {
            pnPrevisualizacion.Controls.Clear();
            Hoja.Controls.Clear();
            Metodos llamada = new Metodos();
            inX = 4;
            inY = 6;
            llamada.AddImageToPictureBox(openFileDialog1.FileName, Imagen, inX, inY);
            pnPrevisualizacion.Controls.Add(Imagen);
        }

        private void inInf(object sender, EventArgs e)
        {
            pnPrevisualizacion.Controls.Clear();
            Hoja.Controls.Clear();
            Metodos llamada = new Metodos();
            //inX = 1.18;
            //inY = 0.98;
            llamada.AddImageToPictureBox(openFileDialog1.FileName, Imagen, inX, inY);
            pnPrevisualizacion.Controls.Add(Imagen);
        }
    }

}