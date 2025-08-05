Para usar o repositório, será necessário possuir .Net usando uma versão > .5;

1º pasta para a solução 
2º abrir a pasta 
3º criar solution 
\"Program Files"\dotnet\dotnet new sln -n BoletimEscolar
4º criar um projeto do tipo console 
\"Program Files"\dotnet\dotnet new console -o Boletim.Console
5º registrar o projeto na solution 
"Program Files"\dotnet\dotnet sln NomeArquivo.sln add NomeArquivo.Console/NomeArquivo.Console.csproj