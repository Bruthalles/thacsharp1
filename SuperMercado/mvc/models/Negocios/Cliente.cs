namespace models.Negocios{
    /// <summary>
    /// Cria um cliente com atributo nome
    /// </summary>
    public class Cliente : IUsuario{
        private string nome;
        public string Nome{
            get => nome;
            set{if(!string.IsNullOrWhiteSpace(value)){
                nome = value;
                }
                Console.WriteLine("Nome não pode ser nulo");
            }
        }
    }
}