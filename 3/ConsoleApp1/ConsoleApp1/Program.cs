using System;

namespace ConsoleApp1
{
    {
    class Program
    {
        private const string PRO_LICENSE = "123";
        private const string EXP_LICENSE = "321";

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ключ:");
            var license = Console.ReadLine();
            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
                    { 
            while (true)
            {
                Console.WriteLine("Enter Command (o/e/s/q): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }
            }
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ вiдкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа доступне у версiї Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступно у версiї Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ вiдредаговано");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версiї Експерт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у новому форматi");
        }
    }
}
}
