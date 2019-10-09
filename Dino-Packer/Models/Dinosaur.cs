namespace DinoPacker.Models
{
    public class Dinosaur
    {
        public string Name {get;set;}
        public Dinosaur(string dinosaurname)
        {
            Name = dinosaurname;
            DinoEra.ActiveDinosaurs.Add(this);
        }
    }
}