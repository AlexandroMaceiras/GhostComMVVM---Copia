﻿using Ghost.Repositorios.Genericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ghost.Models;

namespace Ghost.Repositorios
{
    //Aqui eu armazenei rodas as chamadas para os genéricos de todos os modelos.
    // Essas chamadas são necessárias porque eu não posso chamar os genéricos
    //diretamente como uma instância por serem abstratos.
    public class GerenciamentoGenericRepository : GenericRepository<SLV_TB_STG_AQUI_DADO_CADASTRAL>
    {
    }
    //public class BensGenericRepository : GenericRepository<NOME DE OUTRO MODELO DE TABELA>
    //{
    //}
}