#pragma checksum "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b96bcf08233f45a5f0aae5036e33aae0cf35ac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Recursos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Recursos/ListadoDeRecursos")]
    public partial class ListadoDeRecursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado De Recursos</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
                              ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Nuevo Recurso");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
 if (Recursos == null)
{

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<thead>\r\n            <tr>\r\n                <th>Nombre</th>\r\n                <th>Usuario</th>\r\n\r\n                <th>Acciones</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 27 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
             foreach (var item in Recursos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
                     item.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
                     item.User.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
                                                  ()=>Editar(item.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Editar");
            __builder.CloseElement();
            __builder.AddContent(27, " ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
                                                                                                                     ()=>Borrar(item.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 35 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 38 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\ListadoDeRecursos.razor"
       
    /*
   private List<Recursos> Recursos;

   protected override async Task OnInitializedAsync()
   {
       Recursos = Recurso.getRecursos();
   }
*/

    private List<Recursos> Recursos;

    protected override async Task OnInitializedAsync()
    {
        Recursos = await RecursoSer.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/Recursos/EditarRecurso/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el recurso?");
        if (confirmed)
        {
            await RecursoSer.Remove(id);
            Recursos = await RecursoSer.GetAll();
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursosService RecursoSer { get; set; }
    }
}
#pragma warning restore 1591
