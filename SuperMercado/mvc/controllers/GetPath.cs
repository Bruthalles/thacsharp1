using System.IO;

namespace getpath{
    public static class GetPath{

         //diretorio onde fica o executavel - /SuperMercado/bin/Debug/net9.0/
        private static string basePath = AppContext.BaseDirectory;

        // Volta alguns níveis até chegar na raiz do projeto (SuperMercado/)
        private static string raizProjeto = Directory.GetParent(basePath)?.Parent?.Parent?.Parent?.FullName;

        public static string caminhoArquivo; 

        public static void CriarJson(string nomeArquivo, List<string> conteudo){
            
            // Monta o caminho até um arquivo .json
            caminhoArquivo = Path.Combine(raizProjeto!, "mvc", "models", $"{nomeArquivo}.json");

             using(StreamWriter writer = new StreamWriter(caminhoArquivo,append:true)){
            writer.WriteLine(conteudo);
            }
        }
    }
}