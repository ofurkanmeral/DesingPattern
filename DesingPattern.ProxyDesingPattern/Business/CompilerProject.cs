//Çalışıyorken şöyle bir soru gördüm çözdüm

//Eğer bir vs compiler ekibinde iseniz ve bir projeyi derlemek için önce dependency projeleri derleyip daha sonra bu projeyi derlemeniz gerekiyorsa nasıl yaparsınız

namespace DesingPattern.ProxyDesingPattern.Business
{
    public class CompilerProject
    {
        public string Name { get; set; }
        public List<CompilerProject> Dependencies { get; set; }
        public bool IsCompiler { get; set; }
        public bool IsDependencyCompiler { get; set; }
    }
    public class CompileRunProject
    {
        public CompileRunProject()
        {
            CompilerProject entity = new CompilerProject() { Name = "entity", IsCompiler = false };
            CompilerProject core = new CompilerProject() { Name = "core", IsCompiler = true };
            CompilerProject dataaccess = new CompilerProject() { IsCompiler = false, Name = "DataAccess" };
            CompilerProject webapi = new CompilerProject() { Name = "WebApi", IsCompiler = false, Dependencies = new List<CompilerProject>() };
            webapi.Dependencies.Add(entity);
            webapi.Dependencies.Add(core);
            webapi.Dependencies.Add(dataaccess);
            GetDependency(webapi);
        }




        public void GetDependency(CompilerProject webapi)
        {
            //CompilerProject webapi = new();
            foreach (var item in webapi.Dependencies)
            {
                Console.WriteLine($"Projet name {item.Name} state {item.IsCompiler}");
                RunCompiler(item);

            }
            webapi.IsCompiler = true;
            Console.WriteLine("Tüm Depenciler Compile ve ana Proje Compile");
        }

        public void RunCompiler(CompilerProject project)
        {
            if (project.IsCompiler != true)
            {
                project.IsCompiler = true;
                Console.WriteLine($"Projet name {project.Name} proje derlendi");
            }
        }
    }

}
