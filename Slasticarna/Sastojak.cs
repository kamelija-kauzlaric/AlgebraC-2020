namespace Slasticarna
{
    public class Sastojak
    {
        public Sastojak(string imeSastojka, int gramaza)
        {
            ImeSastojka = imeSastojka;
            Gramaza = gramaza;
        }

        public string ImeSastojka { get; set; }
        public int Gramaza { get; set; }
    }
}