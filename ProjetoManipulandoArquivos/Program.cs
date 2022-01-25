using System;
using ProjetoManipulandoArquivos.Helper;
using System.IO;

namespace ManipulandoArquivos // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var caminho = "C:\\TrabalhandoComArquivos";
      var caminhoPathCombine = Path.Combine(caminho, "PastaTeste1");
      FileHelper helper = new FileHelper();
      // helper.ListarDiretorios(caminho);
      //helper.ListarArquivosDiretorios(caminho);
      //helper.CriarDiretorio(caminhoPathCombine);
      helper.ApagarDiretorio(caminhoPathCombine, true);
    }
  }
}