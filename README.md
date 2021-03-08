# MVC - Aluno
 CRUD com ASP.NET Core EF MVC - Cadastro de alunos

## O que é CRUD:

CRUD é a composição da primeira letra de 4 funções básicas de um sistema que trabalha com banco de dados:

- ✅ C: Create `(criar)` - criar um novo registro.

- 👁 R: Read `(ler)` - ler (exibir) as informações de um registro.

- ♻️ U: Update `(atualizar)` - atualiza os dados do registro.

- ❌ D: Delete `(apagar)` - apaga um registro.
##
Por exemplo, se você precisa desenvolver desde uma simples agenda telefônica até um sistema complexo de gestão de faturamento de pedidos, você precisará realizar essas 4 ações para manipular as tabelas do banco de dados de seu sistema.

Do ponto de vista do desenvolvedor, ele precisará criar as tabelas (modelos) do banco de dados, funções (controles) que atualizarão o banco de dados e as interfaces (visões), como página web ou aplicativo mobile, em que os usuários irão interagir com os dados. 

Em sistemas mais sofisticados, os dados do CRUD podem ser manipulados por outros sistemas via API - Application Programming Interface (em tradução livre, “Interface de Programação de Aplicativos”).

[Fonte](https://angelopublio.com.br/blog/crud)
##
Tecnologias usadas para o desenvolvimento:
* SDK .NET Core
```
Versão 5.0.103
```
##
Editor de Código
[Visual Studio Code](https://code.visualstudio.com/download)

## Ao clonar este repositório instalar pacotes:
- dotnet tool install --global dotnet-ef
- dotnet tool install --global dotnet-aspnet-codegenerator
- dotnet add package Microsoft.EntityFrameworkCore.SQLite
- dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.Extensions.Logging.Debug
##

## Imagens do projeto em tela:
1 - Página Inicial
![Página Inicial](https://user-images.githubusercontent.com/71888055/110330235-4f120800-7ffc-11eb-94ed-376690ea14fa.PNG)

2 - Alunos
![Alunos](https://user-images.githubusercontent.com/71888055/110330599-b5972600-7ffc-11eb-965a-5a8e1391e9a0.PNG)

3 - Criar
![Criar](https://user-images.githubusercontent.com/71888055/110330778-f42ce080-7ffc-11eb-887f-fafc6067cf91.PNG)

4 - Editar
![Editar](https://user-images.githubusercontent.com/71888055/110330806-00b13900-7ffd-11eb-826c-b7d18c6bb6f0.PNG)

5 - Detalhes
![Detalhes](https://user-images.githubusercontent.com/71888055/110330835-0c9cfb00-7ffd-11eb-8983-4b351b409335.PNG)

6 - Excluir
![Deletar](https://user-images.githubusercontent.com/71888055/110330877-19b9ea00-7ffd-11eb-9b6c-a94e13810121.PNG)
