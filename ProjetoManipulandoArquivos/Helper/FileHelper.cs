using System.IO;

namespace ProjetoManipulandoArquivos.Helper
{
  public class FileHelper
  {
    public void ListarDiretorios(string caminho)
    {

      var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

      foreach (var retorno in retornoCaminho)
      {
        System.Console.WriteLine(retorno);
      }
    }

    public void ListarArquivosDiretorios(string caminho)
    {
      //o asteristico é um filtro que chama todos os arquivos, se quiser que seja txt coloca .txt
      var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);
      foreach (var retorno in retornoArquivos)
      {
        System.Console.WriteLine(retorno);
      }
    }

    public void CriarDiretorio(string caminho)
    {
      var retorno = Directory.CreateDirectory(caminho);
      System.Console.WriteLine(retorno.FullName);
    }

    public void ApagarDiretorio(string caminho, bool apagarArquivos)
    {
      Directory.Delete(caminho, apagarArquivos);
      // se o diretório não estiver vazio dará erro.
      //será necessário especificar através do boolenado.
      // o arquivo apagado pelo C# não vai para lixeira, ele apaga de verdade
    }
  }
}