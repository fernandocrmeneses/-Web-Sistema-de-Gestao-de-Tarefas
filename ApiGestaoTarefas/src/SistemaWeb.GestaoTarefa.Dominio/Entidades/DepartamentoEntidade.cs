﻿using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class DepartamentoEntidade : Entidade, IAgregadorRaiz
    {
        public string Nome { get; private set; }
        public UsuarioEntidade Usuario { get; private set; }
        public int Codigo { get; private set; }

        public SetorEntidade Setor { get; private set; }

        public List<GestorEntidade> Gestores { get; set; }

        public DepartamentoEntidade(string nome, UsuarioEntidade usuario, int codigo, SetorEntidade setor, List<GestorEntidade> gestores)
        {
            Nome = nome;
            Usuario = usuario;
            Codigo = codigo;
            Setor = setor;
            Gestores = gestores;
        }
    }
}