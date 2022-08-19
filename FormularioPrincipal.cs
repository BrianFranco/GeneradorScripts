using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            List<string> list = new List<string>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            StringBuilder textoCompleto = new StringBuilder("Titulo del Archivo.\n");
            foreach (var archivo in lboxListaArchivos.Items)
            {
                textoCompleto.AppendLine(File.ReadAllText(archivo.ToString()));
                
            }
            lblCodigoCompleto.Text = textoCompleto.ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach(var file in openFileDialog1.FileNames)
            {
                if (!lboxListaArchivos.Items.Contains(file))
                {
                    lboxListaArchivos.Items.Add(file);
                }
                else
                {
                    //Ya esta agregado a la lista el archivo
                    lblInformacion.Text += "El archivo: " + file + " fue ingresado anteriormente.\n";
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            lboxListaArchivos.Items.Remove(lboxListaArchivos.SelectedItem);
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            GetFiles();
        }
        private void GetFiles()
        {
            string path = @"C:\Users\Brian\Desktop\Practica FileDialog\";
            string[] lista = Directory.GetFiles(path);
            foreach (var archivo in lista)
            {
                LboxListaNovedad.Items.Add(archivo);
            }
        }
    }
}
