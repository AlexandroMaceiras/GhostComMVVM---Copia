using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ghost.Models;

namespace Ghost.Controllers
{
    public class GerenciamentoViewController : Controller
    {
        private GerenciamentoViewContexto db = new GerenciamentoViewContexto();

        // GET: GerenciamentoView
        public ActionResult Index()
        {
            //List<string> lista = new List<string>();

            //var result = from t in db.SLV_VW_GERE_PROCESSOS
            //             select t;
            //foreach (SLV_VW_GERE_PROCESSOS t in result)
            //{
                
            //    //Eu estava testando a view do sql, fazendo um laço pra trazer valores ao invés de chamar direto por lambda.
            //    lista.Add(t.CD_OP_SOLVERE.ToString());
                
            //}

            return View(db.SLV_VW_GERE_PROCESSOS.ToList());
        }        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
