namespace EscolarMysql.Data.Cadastro
{
    public class CadastroDbContextBase
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //-->Conexao com servidor local
            const string strConnection = "Server=oficiotec.ddns.net;User Id=root;Password=@cpdrede12;Database=Oficio10Dev";
            optionsBuilder
            .UseMySql(strConnection, ServerVersion.AutoDetect(strConnection));

        }
    }
}