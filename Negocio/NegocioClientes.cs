﻿using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioClientes
    {
        DaoClientes DC = new DaoClientes();

        public string Buscar(string dni)
        {
            return DC.BuscarCliente(dni);
        }
    }
}
