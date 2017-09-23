using System;
using System.Reflection;

namespace Farsiman.Drogueria.PermisosControlados.WebApi.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}