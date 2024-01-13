using System.Reflection;

namespace Modules.Users.Endpoints;

public static class AssemblyReference
{
    public static Assembly Assembly = typeof(AssemblyReference).Assembly;
}
