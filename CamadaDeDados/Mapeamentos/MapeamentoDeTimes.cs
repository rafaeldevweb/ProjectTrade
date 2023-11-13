using System;
using GMF.Framework.CamadaDeDados.MapeadoresDeBanco;

public class MapeamentoDeTimes : MapeadorDeEntidade<Equipe>
{
	public MapeamentoDeTimes() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
	{
		this.Mapeador.Haskey(x => new { x.ID });
		this.Mapeador.Property(a => a.Nome).HasColumnName("NOME_EQUIPE").IsRequired();
		this.Mapeador.Property(a => a.GolMarcado).HasColumnName("GOL_MARCADO").IsRequired();
		this.Mapeador.Property(a => a.GolLevado).HasColumnName("GOL_LEVADO").IsRequired();
		this.Mapeador.Property(a => a.Pontos).HasColumnName("PONTO").IsRequired();

	}
}
