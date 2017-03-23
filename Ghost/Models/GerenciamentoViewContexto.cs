namespace Ghost.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GerenciamentoViewContexto : DbContext
    {
        public GerenciamentoViewContexto()
            : base("name=GerenciamentoViewContexto")
        {
        }

        public virtual DbSet<SLV_VW_GERE_PROCESSOS> SLV_VW_GERE_PROCESSOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.SG_TP_PESSOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.CD_CAUSA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NR_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NR_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_ESCRITORIO_COBRANCA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.IC_STATUS_PROCESSUAL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.IC_STATUS_OPERACIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.CD_CARTEIRA)
                .IsUnicode(false);
        }
    }
}
