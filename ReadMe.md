# Projeto de CRUD em Asp.NET com Bootstrap

Esse projeto tem como objetivo implementar um CRUD básico com operações de consulta à dados direto via interface utilizando MySQL e LINQ como métodos de consulta. Além disso iremos implementar uma interface e trabalhar esta no formato de template-engine. Não será implementado nenhum micro-serviço inicialmente.

O projeto também contará com implementações de campos de inserção e deleção de registros além de, se houver tempo hábil, a implementação de uma área para criação e gerenciamento de usuários.

# Sobre o MVC

O MVC surgiu de uma iniciativa da Microsoft em conjunto com a comunidade sendo ouen-source e também compatível tanto com .Net Framework quanto .Net Core.

Ele possui uma estrutura bem definida, contando com:

* Controllers -> Unidades de controlle e regulação dos serviços realizados no backend.
* Views -> Reúne as páginas e interfaces gráficas da aplicação.
* Models -> Reúne modelos e formulários aplicados.
* View Models -> Modelos de visualizações padronizados da aplicação.

## Responsabilidades no MVC

MVC é a tradução de Model View Controller, ou seja, os três elementos principais da sua arquitetura. Cada componente se refere à uma estrutura que possui resposabilidades bem delimitadas:

### Model
    O model reúne o core da aplicação, ou seja, as entidades, serviços, regras de negócio, entre outros componentes principais. Resumindo, o model é a aplicação ou o sistema. Pode, também, conter os repositórios usados pela aplicação.

### Controllers
    Os controllers é a camada que rece e trata das interações com o usuário ou outros sistemas. Nos controllers temos desde os serviços de autenticação quanto as API's e webservices utilizados pela aplicação.

### Views
    Esta camada, no modelo de Template Engine, é responsável por reunir as estruturas e comportamento das telas da aplicação, ou seja, a parte gráfica onde ocorrerão as interações com os usuários.    

# Web Services X Template Engine

## Web Services
Aplicações com webservices consistem de uma estrutura em duas camadas (back e frontend) onde as camadas se conversam através de requisições realizadas entre elas, onde uma é responsável pela interface e lado do cliente e a outra é responsável pelo lado do servidor. O front envi requisições HTTP para o back e este, por sua vez, responde as requisições com os dados solicitados como, por exemplo, o cadastro de uma pessoa ou os dados de uma pesquisa.

## Template Engine
Uma aplicação em Template Engine funciona de modo diferente, onde todas operações são feitas no servidor e este, por sua vez, responde as requisições já com as telas prontas.

# Anotações Gerais

## ViewData e Templates
Dentro dos controllers temos cada ação como um módulo onde, a partir de um objeto ViewData["key"] podemos criar valores temporários para serem retornados pelas views apenas aplicando as chaves criadas a partir do controller. Paras aplicarmos um código C#, ou seja, chamarmos alguma função, métodos ou valor, com sintaxe do C# basta iniciarmos a váriável com @, ou @{}, tudo imediatamente após o @ será tratado como sintaxe csharp ao invés de HTML, inclusive, se utilizarmos as chaves, o conteúdo delas será lido como um bloco de código a ser executado quando da requisição desta view, embora não seja aconselhado o uso de código direto na view.

## Natural Templates
O C# trabalha com o uso de natural templates, ou seja, quando fazemos uma chamada de URL para determinado endereço, é feito um roteamento onde a chamada é encaminhada no controller dentro de uma de suas ações, de acordo com a url, e é o controller quem executa a view de acordo com seu conteúdo. Isso permite a implementação das ações de modo seguro, onde apenas o servido executa ações na página.

## IActionResult
O tipo IActionResult consiste de um tipo genérico que define as ações, nele estão contidos diversas classes de objetos View ou Interações. Essa superclasse permite a implementação de diversos tipos de retorno para as ações. A saber:

* ViewResult : retorna um objeto View
* PartialViewResult : retorna um objeto PartialView
* ContentResult : retorna um objeto do tipo Content
* RedirectResult : retorna um objeto Redirect
* RedirectToRouteResult: retorna um objeto RedirectToAction (redireciona para outra ação.)
* JsonResult : retorna um objeto Json
* FileResult : retorna um objeto File (arquivo)
* HttpNotFoundResult : retorna um objeto HttpNotFound (erro 404)
* EmptyResult : retorna um objeto null

O uso do IActionResult é interessante por permitir diversos tipos de retorno diferente, isso traz flexibilidade e maior compatibilidade das ações com os retornos. Além disso, podemos aplicar diversos builders sem a necessidade de criarmos todas as ações de acordo com o método da saída.