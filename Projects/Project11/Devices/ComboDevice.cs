namespace Project11.Devices {
    internal class ComboDevice : Device, IPrinter, IScanner {

        public override void ProcessDoc(string document) {

            System.Console.WriteLine($"ComboDevice processing {document}");
        }

        public string Scan() {

            return $"ComboDevice scan result";
        }

        public void Print(string document) {

            System.Console.WriteLine($"ComboDevice print {document}");
        }
    }
}
