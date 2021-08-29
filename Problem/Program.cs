using System;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            DocumentWorker documentWorker = null;

            Console.WriteLine("Добро пожаловать в DocumentWorker!");
            Console.Write("Введите ключ (пропустить если не имеется): ");
            string key = Console.ReadLine();
            /*
            ключи для про версии:
                ProKey1
                ProKey2
                ProKey3

            ключи для эксперт версии:
                ExpertKey1
                ExpertKey2
                ExpertKey3
            */

            if(ProDocumentWorker.IsValidKey(key)) {
                documentWorker = new ProDocumentWorker();
                Console.WriteLine("Добро пожаловать в про версию DocumentWorker");
            } else if (ExpertDocumentWorker.IsValidKey(key)) {
                documentWorker = new ExpertDocumentWorker();
                Console.WriteLine("Добро пожаловать в эксперт версию DocumentWorker");
            } else {
                Console.WriteLine($"\'{key}\' не является ключом");
                documentWorker = new DocumentWorker();
                Console.WriteLine("Добро пожаловать в бесплатную версию DocumentWorker");
            }

            Console.WriteLine("открываем документ...");
            documentWorker.OpenDocument();
            System.Console.WriteLine();

            Console.WriteLine("изменяем документ...");
            documentWorker.EditDocument();
            System.Console.WriteLine();

            Console.WriteLine("сохраняем документ...");
            documentWorker.SaveDocument();
            System.Console.WriteLine();
            
        }
    }
}
