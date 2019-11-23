using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aspn_Upload.Controllers
{
    public class UploadController : Controller
    {
        //Define uma instância de IHostingEnvironment
        IHostingEnvironment _appEnvironment;
        //Injeta a instância no construtor para poder usar os recursos
        public UploadController(IHostingEnvironment env)
        {
            _appEnvironment = env;
        }

        //Retorna a View Index.cshtml que será o formulário para
        //selecionar os arquivos a serem enviados 
        public IActionResult Index()
        {
            return View();
        }

        public void EnviarImagem(List<IFormFile> arquivos)
        {
            ViewData["imagemDoUsuario"] = arquivos;

            long tamanhoArquivos = arquivos.Sum(f => f.Length);
            // caminho completo do arquivo na localização temporária
            var caminhoArquivo = Path.GetTempFileName();
            // processa o arquivo enviado
            string caminhoDestinoArquivoOriginal = "";
            //percorre a lista de arquivos selecionados
            foreach (var arquivo in arquivos)
            {
                //verifica se existem arquivos 
                if (arquivo == null || arquivo.Length == 0)
                {
                    //retorna a viewdata com erro
                    //return "Error: Arquivo(s) não selecionado(s)";
                }

                // < define a pasta onde vamos salvar os arquivos >
                string pasta = "Arquivos_Usuario";
                // Define um nome para o arquivo enviado incluindo o sufixo obtido de milesegundos
                string nomeArquivo = "Usuario_arquivo_" + DateTime.Now.Millisecond.ToString();

                //verifica qual o tipo de arquivo : jpg, gif, png, pdf ou tmp
                if (arquivo.FileName.Contains(".jpg"))
                    nomeArquivo += ".jpg";
                else if (arquivo.FileName.Contains(".gif"))
                    nomeArquivo += ".gif";
                else if (arquivo.FileName.Contains(".png"))
                    nomeArquivo += ".png";
                else if (arquivo.FileName.Contains(".pdf"))
                    nomeArquivo += ".pdf";
                else
                    nomeArquivo += ".tmp";

                //< obtém o caminho físico da pasta wwwroot >
                string caminho_WebRoot = _appEnvironment.WebRootPath;
                // monta o caminho onde vamos salvar o arquivo :  ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos
                string caminhoDestinoArquivo = caminho_WebRoot + "\\Arquivos\\" + pasta + "\\";
                // incluir a pasta Recebidos e o nome do arquiov enviado : ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos\
                caminhoDestinoArquivoOriginal = caminhoDestinoArquivo + "\\Recebidos\\" + nomeArquivo;

                //copia o arquivo para o local de destino original
                using (var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create))
                {
                    arquivo.CopyToAsync(stream);
                }
            }
        }

    }
}