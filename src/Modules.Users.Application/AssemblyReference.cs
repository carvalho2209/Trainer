using System.Reflection;

namespace Modules.Users.Application;

public static class AssemblyReference
{
    public static Assembly Assembly = typeof(AssemblyReference).Assembly;
}
