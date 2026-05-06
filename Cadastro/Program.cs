using System;

class Program
{
    static void Main()
    {
        string continuar = "s";

        while (continuar == "s")
        {
            string nome1 = "Tony Stark";
            string nome2 = "Annabeth";
            string jogador1 = "Tutu";
            string jogador2 = "Mari";
            string origem1 = "Marvel";
            string origem2 = "Percy Jackson";
            string exp1 = "Batalha";
            string exp2 = "Batalha";
            int forca1 = 8;
            int forca2 = 4;
            int agilidade1 = 7;
            int agilidade2 = 5;
            int inteligencia1 = 9;
            int inteligencia2 = 9;
            int vida1 = 10;
            int vida2 = 10;

            Console.WriteLine("\n=== BATALHA DE PERSONAGENS ===\n");

            Console.WriteLine($"{nome1}, controlado por {jogador1}, vem do universo {origem1}. " + $"Possui experiência em {exp1}, com força {forca1}, agilidade {agilidade1}, " + $"inteligência {inteligencia1} e vida {vida1}.\n");

            Console.WriteLine($"{nome2}, controlado por {jogador2}, vem do universo {origem2}. " + $"Possui experiência em {exp2}, com força {forca2}, agilidade {agilidade2}, " + $"inteligência {inteligencia2} e vida {vida2}.\n");

            Console.WriteLine("O método escolhido para a batalha foi OFENSIVA (força + agilidade).\n");

            string vencedor = Ofensiva(nome1, forca1, agilidade1, nome2, forca2, agilidade2);

            Console.WriteLine($"\nVENCEDOR: {vencedor}");

            Console.WriteLine("\nDeseja repetir a batalha? (s/n)");
            continuar = Console.ReadLine().ToLower();
        }
    }

    static string Ofensiva(string nome1, int forca1, int agilidade1, string nome2, int forca2, int agilidade2)
    {
        int ofensiva1 = forca1 + agilidade1;
        int ofensiva2 = forca2 + agilidade2;

        Console.WriteLine($"Ofensiva de {nome1}: {ofensiva1}");
        Console.WriteLine($"Ofensiva de {nome2}: {ofensiva2}");

        if (ofensiva1 > ofensiva2)
            return nome1;
        else if (ofensiva2 > ofensiva1)
            return nome2;
        else
            return "Empate";
    }
}