
namespace ManipuladorArquivos{
    public static class ManipuladorArquivos{

    //diretorio onde fica o executavel - /Projeto/bin/Debug/net9.0/
    private static string basePath = AppContext.BaseDirectory;

    // Volta alguns níveis até chegar na raiz do projeto 
    private static string raizProjeto = Directory.GetParent(basePath)?.Parent?.Parent?.Parent?.FullName;

    public static string caminhoArquivo;

    /// <summary>
    /// utiliza arquivo na pasta raiz do projeto 
    /// </summary>
    /// <param name="nomeArquivo">escolha um nome e extensão</param>
    /// <returns>caminho completo "/" + nomeArquivo</returns>
    public static string ObterCaminhoArquivoRaiz(string nomeArquivo){
        caminhoArquivo = $"{raizProjeto}/{nomeArquivo}";
        return caminhoArquivo;
        }
    /// <summary>
    /// lê arquivo salvo em qualquer subdiretório.
    /// necessário uso das barras: /
    /// </summary>
    /// <param name="nomePai">/pastas/intermediarias/</param>
    /// <param name="nomeArquivo">"arquivofinal".sua extensão</param>
    /// <returns></returns>
    public static string ObterCaminhoArquivoDoFilhoCompleto(string nomePai, string nomeArquivo){
        caminhoArquivo = $"{raizProjeto}{nomePai}{nomeArquivo}";
        return caminhoArquivo;
        }

    /// <summary>
    /// cria arquivo na raiz do projeto 
    /// </summary>
    /// <param name="nomeArquivo">nome do arquivo para criar</param>
    /// <param name="conteudo">objetos convertidos para lista que salva no json</param>
    
    public static void CriarArquivo(string nomeArquivo, List<string> conteudo){
            
        // Monta o caminho até um arquivo .json
        caminhoArquivo = Path.Combine(raizProjeto!, nomeArquivo);

        try{
            using(StreamWriter writer = new StreamWriter(caminhoArquivo,append:true)){
                foreach(var item in conteudo){
                writer.WriteLine(item);
                }
                }
                Console.WriteLine($"Arquivo e conteudo salvo com sucesso em {caminhoArquivo}");
            }
            catch(Exception ex){
                Console.WriteLine($"Erro ao salvar conteudo: {ex.Message}");
            }
        }
    }
}