﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digiteca.Controller;
using Ubiety.Dns.Core.Records.NotUsed;

namespace Digiteca.Visao
{
    public partial class fmClientes : Form, IObservada
    {
        private List<IObservador> listaObservadores = new List<IObservador>();
        public fmClientes()
        {
            InitializeComponent();
        }

        private void btncFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {

        }

    }
}
