# AspNetMvc5
Seguindo o tutorial da Casa do Código, utilizando a framework Asp Net Mvc 5 + SQL SERVER para realizarmos um crub básico de categorias e fabricantes

<img alt="HTML" src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white">&nbsp;<img alt=".Net" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white">&nbsp;<img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">&nbsp;<img alt="SqlServer" src="https://img.shields.io/badge/Microsoft%20SQL%20Sever-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white">&nbsp;

## Algumas Funções Utilizadas no projeto (HtmlHelper)

<h5>AntiForgeryToken:</h5> Gera um campo de formulário oculto (token anti-falsificação) que é validado quando o formulário é enviado. O valor do campo é gerado usando o valor salt especificado.

~~~C#
   @Html.AntiForgeryToken()
~~~

Adicione o [ValidateAntiForgeryToken] em todas as ações que aceitam POST HTTP
~~~C#
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Index(){
        return View();
    }
~~~

<h5>TextBoxFor():</h5>é o método de extensão genérico que cria o input.

~~~C#
     @Html.TextBoxFor(m => m.Text, new { placeholder = Html.DisplayNameFor(m => m.Text), @class = "form-control" })
~~~

<h5>ValidationMessageFor():</h5>
étodo é uma expressão lambda para especificar uma propriedade para a qual queremos mostrar uma mensagem de erro

~~~C#
    @Html.ValidationMessageFor(m => m.Text, "", new { @class = "text-danger custom-danger" })
~~~

<hr>

<h5>HttpStatusCodeResult</h5>
Fornece uma maneira de retornar um resultado de ação com uma descrição e código de status de resposta HTTP específicos.

<h5>HttpStatusCode.BadRequest</h5>
Equivalente ao status HTTP 400. BadRequest indica que a solicitação não pôde ser entendida pelo servidor. BadRequest será enviado quando nenhum outro erro for aplicável ou se o erro exato for desconhecido ou não tiver seu próprio código de erro.

~~~C#
     if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
~~~

<h5>HttpNotFound()</h5>
Equivalente ao status HTTP 404. NotFound indica que o recurso solicitado não existe no servidor.

### :link: Links Úteis
 - https://docs.microsoft.com/pt-br/aspnet/core/mvc/overview?view=aspnetcore-5.0
 - https://www.casadocodigo.com.br/
