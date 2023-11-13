using System;

public class RepositorioDeEquipe
{
	public class RepositorioDeEquipe : RepositorioCache <ProjecaoDaEquipe>
	{
		public int ObterNovoId()
		{
			return this.ObterIdSequence("TBTIMES", "ID")
		}
		public int ObterPorId ( int id)
		{

		}
		private int ObterIdSequence ( string str, int id )
		{

		}

    }
}
