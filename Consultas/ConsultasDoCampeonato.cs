namespace Consultas;
{
	using System;
    using System.Linq;
    using app_mvc.Projecao;

public class ConsultasDoCampeonato
{
    public ConsultasDoCampeonato()
    {
        public IList<ProjecaoDaEquipe> ObterTimes(int id)
        {
            var time = this._consultaDeTimes.Buscar(b => b.ID == id).ToList();
            ProjecaoDaEquipe result = null;

            if (times != null && times.Count == 8)
            {
                result = (from t in times
                          select new ProjecaoDaEquipe
                          {
                              Id = t.Id,
                              Nome = t.Nome,
                              GolMarcado = t.GolMarcado,
                              GolLevado = t.GolLevado,
                              Pontos = t.Pontos
                          }).ToList();
            }
            return result;
        }


        public Equipe NovoEEditaTime(Equipe dto)
        {
            if (dto.Id == 0)
            {
                var novo = new Equipe();
                novo.Id = _repositorioDeEquipe.ObterNovoId();
                novo.Nome = dto.Nome;
                novo.GolMarcado = dto.GolMarcado;
                novo.GolLevado = dto.GolLevado;
                novo.Pontos = dto.Pontos;

            }
            else
            {
                var entidade = _repositorioDeEquipe.ObterPorId(dto.Id);
                entidade.Nome = dto.Nome;
                entidade.GolMarcado = dto.GolMarcado;
                entidade.GolLevado = dto.GolLevado;
                entidade.Pontos = dto.Pontos;
            }

            GerenciadorDeUnidadeDeTrabalho.Corrente.Commit();

            return dto;
        }

        public void ExcluirTime(int id)
        {
            var time = this._consultaDeTimes.Buscar(b => b.ID == id);

            GerenciadorDeUnidadeDeTrabalho.Corrente.ExecutarComandoSql(new ComandoSQL("DELETE TBTIMES WHERE ID =" + time));
            GerenciadorDeUnidadeDeTrabalho.Corrente.Commit();

        }
    }
}
}
