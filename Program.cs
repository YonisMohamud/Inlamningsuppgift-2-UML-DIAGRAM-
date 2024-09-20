namespace UML_DIAGRAM
{
    using System;

    namespace SportbilProgram
    {
        // Bas/superklass: Sportbil
        public class Sportbil
        {
            // Attribut med protected för åtkomst i underklasser
            protected string namn;
            protected int topphastighet;
            protected double pris;

            // Konstruktor
            public Sportbil(string namn, int topphastighet, double pris)
            {
                this.namn = namn;
                this.topphastighet = topphastighet;
                this.pris = pris;
            }

            // Metod för att visa bilens information
            public virtual void VisaInfo()  // Polymorfism: Metoden kan överskrivas i underklasser
            {
                Console.WriteLine($"Bilnamn: {namn}, Topphastighet: {topphastighet} km/h, Pris: {pris} kr");
            }

            // Metod för att simulera att köra bilen
            public virtual void Kör()  // Polymorfism: Kan överskrivas i underklasser
            {
                Console.WriteLine($"{namn} kör i full fart!");
            }
        }

        // Underklass: Ferrari
        public class Ferrari : Sportbil
        {
            public Ferrari() : base("Ferrari", 350, 3000000) { }

            // Överskridning av Kör-metoden (Polymorfism)
            public override void Kör()
            {
                Console.WriteLine($"{namn} accelererar snabbt och kör i 350 km/h!");
            }
        }

        // Underklass: Lamborghini
        public class Lamborghini : Sportbil
        {
            public Lamborghini() : base("Lamborghini", 340, 2800000) { }

            // Överskridning av Kör-metoden (Polymorfism)
            public override void Kör()
            {
                Console.WriteLine($"{namn} når topphastigheten på 340 km/h!");
            }
        }

        // Underklass: Porsche
        public class Porsche : Sportbil
        {
            public Porsche() : base("Porsche", 320, 2000000) { }

            // Överskridning av Kör-metoden (Polymorfism)
            public override void Kör()
            {
                Console.WriteLine($"{namn} hanterar kurvor i hög fart och når 320 km/h!");
            }
        }

        // Programklass för att köra programmet
        class Program
        {
            static void Main(string[] args)
            {
                // Skapar objekt av de tre sportbilarna
                Ferrari ferrari = new Ferrari();
                Lamborghini lamborghini = new Lamborghini();
                Porsche porsche = new Porsche();

                // Visa information och kör bilarna
                ferrari.VisaInfo();
                ferrari.Kör();

                lamborghini.VisaInfo();
                lamborghini.Kör();

                porsche.VisaInfo();
                porsche.Kör();

                // Vänta på att användaren trycker på en knapp innan programmet avslutas
                Console.ReadKey();
            }
        }
    }

}
