namespace S02_tableau;

class Program
{
    static void Main(string[] args)
    {
        // Création des tableaux
        int[] tableau1 = new int [10];
        int[] tableau2 = new int [10];
        int[] tableau3 = new int[20];

          // Attribuer des valeurs aux tableaux
        for (int i = 0; i < tableau1.Length; i++)
        {
            tableau1[i] = i + 1;
            tableau2[i] = (i + 11) * 1;
        }

        // Copie des valeurs des deux premiers tableaux dans le troisième
        Array.Copy(tableau1, tableau3, tableau1.Length);
        Array.Copy(tableau2, 0, tableau3, tableau1.Length, tableau2.Length);

        // Affichage du troisième tableau
        Console.WriteLine("Tableau 3");
        for (int i = 0; i < tableau3.Length; i++)
        {
            Console.WriteLine(tableau3[i]);
        }
    }
}

