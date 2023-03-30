namespace MyVSCodeProject{
    class Functions{

    public static double CalculerPerimetreCarre(double cote)
        {
            double perimetre = cote * 4;
            return perimetre;
        }

    public static double CalculerPerimetreCercle(double rayon)
        {
        const double pi = 3.14159;
        double circonference = (2 * rayon) * pi;
        return circonference;
        }
       
    public static void AfficherLesPerimetres()
    {
        double perimetreCarre = CalculerPerimetreCarre(5);
        double perimetreCercle = CalculerPerimetreCercle(5);
        Console.WriteLine("Le périmètre du carré est de " + perimetreCarre);
        Console.WriteLine("Le périmètre du cercle est de " + perimetreCercle);
    }
}
}