# FormsCSharp
### Чтобы запустить определённую Form:
#### *В Program.cs заменить 'Form9' на нужный из репозитория*

```
namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form9());
        }                       ^^^^^
    }
}
```