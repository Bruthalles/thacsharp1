using Microsoft.VisualBasic;

namespace models.Negocios{
    /// <summary>
    /// Cria Gerente com nome, id e senha
    /// </summary>
    public class Gerente : IUsuario{
        public string Nome{ get; set; }
        public string Id{get;set;}
        public string Senha{get;set;}
    }
}