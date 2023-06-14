using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaORM___Exercicio1
{
    public partial class TelaEstacionamento : Form
    {
        public TelaEstacionamento()
        {
            InitializeComponent();
        }
        Cliente cli;

        private void Salvarbtn_Click(object sender, EventArgs e)
        {
             cli = new Cliente();

            if (Idtxt.Text == null || Idtxt.Text == "")
            {

                cli.Nome = Clientetxt.Text;
                cli.Modelo = Modelotxt.Text;
                cli.Placa = Placatxt.Text;
            }
            else
            {

                cli.Nome = Clientetxt.Text;
                cli.Modelo = Modelotxt.Text;
                cli.Placa = Placatxt.Text;
            }
            cli.Salvar();


            LimpaCampos();
            GetClientes();
        }

        private void GetClientes()
        {
            
        }

        private void Excluirbtn_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            var id = int.Parse(Idtxt.Text);
            cli.Excluir();
            GetClientes();
        }

        private void Cadastrarbtn_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            cli.Id = Convert.ToInt32((string)Idtxt.Text);
            foreach(Cliente c in cli.Buscar())
            {
                Idtxt.Text = c.Id.ToString();
                Clientetxt.Text = c.Nome;
                Modelotxt.Text = c.Modelo;
                Placatxt.Text = c.Placa;
            }
        }
        private void LimpaCampos()
        {

            Clientetxt.Text = "";
            Modelotxt.Text = "";
            Placatxt.Text = "";

        }
    }
}

