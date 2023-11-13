namespace app_mvc.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    public class TimeController:Controller
    {   
        
        public ActionResult ObterTime(int id)
        {
            var time = this._consultasDoCampeonato.ObterTimes(id);
            return GeradorDeJson.JsonParaBusca(time);
        }
        public ActionResult NovoTime(Equipe dto)
        {
            var time = this._consultasDoCampeonato.NovoEEditaTime(dto);
            return GeradorDeJson.JsonParaListagem(time, JsonRequestBehavior.AllowGet);
        }
        public ActionResult EditarTime(Equipe dto )
        {
            var time = this._consultasDoCampeonato.NovoEEditaTime(dto);
            return GeradorDeJson.JsonParaListagem(time, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ExcluirTime(int id)
        {
            var time = this._consultasDoCampeonato.ExcluirTime(id);
            return GeradorDeJson.JsonParaBusca(time);

        }

    }
}