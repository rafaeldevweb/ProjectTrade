class Program
{
    static void Main(string[] args)
    {
        ChampionshipController controller = new ChampionshipController();

        // Executar as fases do campeonato
        controller.PlayQuarterFinals();
        controller.PlaySemiFinals();
        controller.PlayThirdPlacePlayoff();
        controller.PlayFinal();

        // Exibir resultados
        controller.DisplayResults();
    }
}
