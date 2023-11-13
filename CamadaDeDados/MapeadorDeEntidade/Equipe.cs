namespace CamadaDeDados.MapeadorDeEntidade;
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace app_mvc.Models
    {
        public class Equipe: Poco, IRaizDeAgregacao
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int GolMarcado { get; set; }
            public int GolLevado { get; set; }
            public int Pontos { get; set; }
        
        }
    }
}