namespace models.Negocios{
    public interface IUsuario{
        string Nome{ 
            get => Nome; 
            set{
                if(value != null){
                    Nome = value;
                }
            } 
        }
    }
}