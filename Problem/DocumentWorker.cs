using System;

namespace Problem {
    class DocumentWorker {
        public DocumentWorker() {}

        public void OpenDocument() {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument() {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument() {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker {
        private static readonly string[] _validKeys = {
            "ProKey1",
            "ProKey2",
            "ProKey3"
        };

        public static bool IsValidKey(in string key) {
            foreach(string vkey in _validKeys) 
                if(vkey == key)
                    return true;
            
            return false;
        }

        public ProDocumentWorker() {}

        public sealed override void EditDocument() {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument() {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker {
        private static readonly string[] _validKeys = {
            "ExpertKey1",
            "ExpertKey2",
            "ExpertKey3"
        };
        
        public new static bool IsValidKey(in string key) {
            foreach(string vkey in _validKeys) 
                if(vkey == key)
                    return true;
            
            return false;
        }

        public ExpertDocumentWorker() {}

        public override void SaveDocument() {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}