# CadastroDeProdutosMVC
Esse Projeto consiste em desenvolver uma aplicação Web api MVC com Asp.Net e Entity Framework. 

Esta aplicação faz simulação de cadastro de produtos de uma loja virtual, tendo como pricipais funcionalidades um CRUD (Create, Read, Update e Delete ):
- **Tela de listagem de Produtos**
- **Tela de edição de produtos**
- **Tela de exclusão de Produtos**
- **Tela de cadastro de Produtos** 

## Tecnologias utilizadas
- **Visual Studio 2017**
- **EntityFramework 6.2** 
- **Nuget como gerenciador de dependências**
- **Microsoft Sql Server 2017** 
- **Microsoft sql server management studio 2017** 

## Etapas de configurações

1. Use `git clone git://github.com/Kdiaseng/CadastroDeProdutosMVC.git`ou faça download do projeto completo como .zip.
2. Abra a Solução *CadastroProdutosMVC.sln. no Visual Studio*
3. Use o Nuget(Ferramentas->Gerenciador de Pacote do Nuget->Console do Gerenciador de Pacote) para instalar o EntityFramework usando:
```
PM> Install-Package EntityFramework
```

4. Abra o arquivo **Web.config** da solução e modifique o seguinte código:
 ```
 <connectionStrings>
      <add name="produtosContext" connectionString="Data Source=[nome_servidor];Initial Catalog = CadastroProdutos;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```
[nome_do servidor] é o nome que se encontra no MS SQl SERVER MANAGEMENT;
Será gerado o banco de dados automaticamente.

**OBS.**
Caso queira usar um Banco de dados local crie um banco de dados na pasta `App_Data` com o nome : *cadastroProdutoDb.mdf*. e não terá que modificar o arquivo **Web.config**

5. Agora é só executar.

