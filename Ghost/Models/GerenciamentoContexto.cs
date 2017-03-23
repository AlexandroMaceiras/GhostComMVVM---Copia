namespace Ghost.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GerenciamentoContexto : DbContext
    {
        public GerenciamentoContexto()
            : base("name=GerenciamentoContexto")
        {
        }

        public virtual DbSet<SLV_TB_STG_AQUI_DADO_CADASTRAL> SLV_TB_STG_AQUI_DADO_CADASTRAL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.SG_TP_PESSOA)
                .IsUnicode(false);



            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.CD_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NR_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.SG_UF)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NR_DDD)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NR_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NR_DDD_CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NR_CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.CD_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NR_RG)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_EMISSOR_RG)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.DT_NASCIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.DS_NATURALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.DS_NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_PAI)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_MAE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.NM_CONJUGE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.CD_ESTADO_CIVIL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.CD_REGIME_CIVIL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.DT_CADASTRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_STG_AQUI_DADO_CADASTRAL>()
                .Property(e => e.DT_ATUALIZACAO)
                .IsUnicode(false);
        }
    }
}
