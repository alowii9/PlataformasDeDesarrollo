﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using BlazorApp1.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace BlazorApp1.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace BlazorApp1.Data
{
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedRemoteService : RemoteService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedRemoteService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<Tareas>> RemoteService.GetAllTarea()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllTarea", new Type[] {  });
            return (Task<List<Tareas>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tareas> RemoteService.GuardarTareas(Tareas valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarTareas", new Type[] { typeof(Tareas) });
            return (Task<Tareas>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tareas> RemoteService.GetTarea(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetTarea", new Type[] { typeof(int) });
            return (Task<Tareas>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Usuarios>> RemoteService.GetAllUsuario()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllUsuario", new Type[] {  });
            return (Task<List<Usuarios>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuarios> RemoteService.GetUsuario(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUsuario", new Type[] { typeof(int) });
            return (Task<Usuarios>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuarios> RemoteService.GuardarUsuario(Usuarios valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarUsuario", new Type[] { typeof(Usuarios) });
            return (Task<Usuarios>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Recursos>> RemoteService.GetAllRecurso()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllRecurso", new Type[] {  });
            return (Task<List<Recursos>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recursos> RemoteService.GuardarRecursos(Recursos valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarRecursos", new Type[] { typeof(Recursos) });
            return (Task<Recursos>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recursos> RemoteService.GetRecurso(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetRecurso", new Type[] { typeof(int) });
            return (Task<Recursos>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Detalles>> RemoteService.GetAllDetalle()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllDetalle", new Type[] {  });
            return (Task<List<Detalles>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalles> RemoteService.GuardarDetalles(Detalles valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarDetalles", new Type[] { typeof(Detalles) });
            return (Task<Detalles>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalles> RemoteService.GetDetalles(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetDetalles", new Type[] { typeof(int) });
            return (Task<Detalles>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
