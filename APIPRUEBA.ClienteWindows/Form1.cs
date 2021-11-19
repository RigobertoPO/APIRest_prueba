using APIPRUEBA.ClienteWindows.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPRUEBA.ClienteWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ApiExternabutton_Click(object sender, EventArgs e)
        {
            List<Root> lista = new List<Root>();
            List<Root> listaModificada = new List<Root>();
            string urlAPI = "https://jsonplaceholder.typicode.com/albums";
            WebClient cliente = new WebClient();
            cliente.Headers["Content-type"] = "application/json";
            cliente.Encoding = Encoding.UTF8;
            string jsonResultado = cliente.DownloadString(urlAPI);
            lista = JsonConvert.DeserializeObject<List<Root>>(jsonResultado);
            var filtro = (from l in lista where l.userId == 1 select l).ToList();
            foreach (var item in  lista)
            {
                Root nuevo = new Root();
                nuevo.userId = item.userId;
                nuevo.id = item.id;
                nuevo.title = "hola mundo " + item.id;
                listaModificada.Add(nuevo);
            }
            ResultadodataGridView.DataSource = listaModificada;

        }

        private void ApiLocalbutton_Click(object sender, EventArgs e)
        {
            List<Libro> listaLibro = new List<Libro>();
            string urlAPI = "https://localhost:44393/api/Libros/ObtenerLibros";
            WebClient cliente = new WebClient();
            cliente.Headers["Content-type"] = "application/json";
            cliente.Encoding = Encoding.UTF8;
            string jsonResultado = cliente.DownloadString(urlAPI);
            listaLibro = JsonConvert.DeserializeObject<List<Libro>>(jsonResultado);
            ResultadodataGridView.DataSource = listaLibro;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Libro nuevoLibro = new Libro();
                nuevoLibro.ISBN = ISBNtextBox.Text;
                nuevoLibro.Titulo = TitulotextBox.Text;
                nuevoLibro.AñoPublicacion = int.Parse( AñotextBox.Text);
                nuevoLibro.Editorial = EditorialtextBox.Text;
                var json = JsonConvert.SerializeObject(nuevoLibro);
                HttpClient clienteHttp = new HttpClient();
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var respuesta = await clienteHttp.PostAsync("https://localhost:44393/api/Libros/GuardarLibro",content);
                if(respuesta.StatusCode==HttpStatusCode.OK)
                {
                    MessageBox.Show("Guardo el libro");
                    ISBNtextBox.Text = "";
                    TitulotextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("No se Guardo el libro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de captura");
            }
        }
    }
}
