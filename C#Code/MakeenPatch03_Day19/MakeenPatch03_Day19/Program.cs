using MakeenPatch03_Day19.MyDbContext;

namespace MakeenPatch03_Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  steps For Connecting you C# Console Application  to Database 
             *  install Needed Packages 
                *MicrosoftEntityFrameworkCore
                **MicrosoftEntityFrameworkCore.SqlServer
                **MicrosoftEntityFrameworkCore.tools
             *Create your Customized Manager Class(ApplicationDbContext)
                *CreateAfolder Called MyDbContext (any Name But Make It Describtive)Don't use DbContext
                * Create class Inisde the Folder Called ApplicationDbContext (any Name But Make It Describtive)
                * Make this Class Inherit From  DbContext =>(Comes From MicrosoftEntityFrameworkCore )
                *Override the OnConfiguring Function \
                *use OptionsBulider Instance Like optionsBuilder.UseSqlServer("Data Source= DESKTOP-L6SQVCF ;Initial Catalog=MakeenCompany;Integrated Security=True; ") ==> Put Connection String
                * Create Your Models Folder 
                * Create Your Classes (only with Properties )
                * put inside the ApplicationDbContext a Property of Type DbSet 
                                * public DbSet<Classname> {get;set} 
                *Open the Console and write 
                *add-Migration "Message" 
                *update-database
             
             */


            Console.WriteLine("Hello, World!");
            ApplicationDbContext db = new ApplicationDbContext();
            //db.Employees.Add()
        }
    }
}