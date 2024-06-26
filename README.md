
# PlaylistConverter

## Sobre o PlaylistConverter

O PlaylistConverter é uma aplicação de linha de comando. Seu objetivo é converter arquivos de playlist do Visual Studio, para um formato de texto simples. A principal funcionalidade dessa aplicação é extrair os nomes dos métodos de teste presentes no arquivo de playlist do Visual Studio e salvá-los em um arquivo de texto separado.

## Requisitos do Sistema

-   Microsoft Windows
-   .NET 8.0

## Estrutura do Projeto

O projeto PlaylistConverter é organizado da seguinte forma:
```
PlaylistConverter/
│
├── Converters/
│   ├── XmlPlaylistConverter.cs
│
├── Utilities/
│   ├── DisplayNameExtractor.cs
│
├── ConverterApplication.cs
```
-   **Converters**: Este diretório contém as classes responsáveis por converter o arquivo de playlist do Visual Studio.
    
    -   `XmlPlaylistConverter.cs`: Classe responsável pela conversão do arquivo de playlist XML para o formato de texto.
-   **Utilities**: Este diretório contém classes utilitárias auxiliares.
    
    -   `DisplayNameExtractor.cs`: Classe responsável por extrair nomes de exibição de elementos XML.
-   **ConverterApplication.cs**: Este arquivo contém a classe principal da aplicação, responsável por fornecer a interface de linha de comando para converter arquivos de playlist.
    

## Instalação e Execução

1.  **Download do Programa**: O arquivo executável `PlaylistConverter.exe` está localizado na pasta `"converter-playlist-to-txt\AplicativoPlaylistConverter"`, juntamente com os demais arquivos necessários para a execução. Alternativamente, você pode compilar o código do programa usando o Microsoft Visual Studio, e o arquivo .exe gerado estará no seguinte caminho: `PlaylistConverter\bin\Release\net8.0\PlaylistConverter.exe`.
    
2.  **Abrindo o Terminal**: Abra um terminal ou prompt de comando no diretório onde o arquivo `PlaylistConverter.exe` está localizado.
    
3.  **Executando o Programa**: Execute o seguinte comando no terminal:
    `.\PlaylistConverter.exe <caminho_para_o_arquivo_de_playlist> <caminho_para_o_arquivo_de_texto>` 
    
    Substitua `<caminho_para_o_arquivo_de_playlist>` pelo caminho completo para o arquivo de playlist do Visual Studio que deseja converter e `<caminho_para_o_arquivo_de_texto>` pelo caminho completo para onde deseja salvar o arquivo de texto convertido.
    
    Por exemplo:
    
    `.\PlaylistConverter.exe "C:\caminho\para\o\arquivo.playlist" "C:\caminho\para\o\arquivo.txt"` 
    
    **Nota**: Use `.\` antes de `PlaylistConverter.exe` para indicar que o executável está no diretório atual. Sem isso, o PowerShell pode não encontrar o programa, pois, por padrão, o PowerShell não carrega comandos do diretório atual. Ele busca o comando nas pastas listadas na variável de ambiente PATH, e se o executável não estiver em uma dessas pastas, o comando não será encontrado.
    
4.  **Acompanhando a Execução**: O programa exibirá mensagens indicando o progresso. Ao finalizar, mostrará uma mensagem indicando que a conversão foi concluída com sucesso ou se ocorreu algum erro.
    

## Funcionamento

O programa faz a leitura do arquivo `.playlist` do Visual Studio no formato XML e extrai os nomes dos métodos de teste presentes no arquivo. Ele ignora qualquer outro conteúdo presente no arquivo de playlist, focando exclusivamente em extrair os nomes dos métodos de teste.

## Observações

-   Certifique-se de fornecer o caminho completo para o arquivo de playlist e o arquivo de texto ao executar o programa.
-   O arquivo de playlist do Visual Studio deve estar no formato XML.

<div align="left"> <h4>< Contato ></h4> </div>

👤 Autor: João Vitor Gomes <br>
📧 Email: bgomes.joaovitor@gmail.com