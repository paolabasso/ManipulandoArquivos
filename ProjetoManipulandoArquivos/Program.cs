using System;
using ProjetoManipulandoArquivos.Helper;
using System.IO;
using System.Collections.Generic;

namespace ManipulandoArquivos // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var caminho = "C:\\TrabalhandoComArquivos";
      var caminhoPathCombine = Path.Combine(caminho, "PastaTeste1");
      var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
      var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "arquivo-teste-stream.txt");
      var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
      var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
      var listaString = new List<string> { "linha 1", "linha 2", "linha 3" };
      var listaStringContinuacao = new List<string> { "linha 4", "linha 5", "linha 6" };

      FileHelper helper = new FileHelper();
      // helper.ListarDiretorios(caminho);
      //helper.ListarArquivosDiretorios(caminho);
      //helper.CriarDiretorio(caminhoPathCombine);
      //helper.ApagarDiretorio(caminhoPathCombine, true);
      //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
      //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
      //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
      //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
      //helper.LerArquivoStream(caminhoArquivo);
      //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
      //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
      helper.DeletarArquivo(caminhoArquivoTesteCopia);
    }
  }
}