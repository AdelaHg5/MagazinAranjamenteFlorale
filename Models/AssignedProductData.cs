namespace MagazinAranjamenteFlorale.Models
{
    public class AssignedProductData
    {
        public int ProductID { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Assigned { get; set; } //O proprietate publică de tip boolean (bool) numită Assigned, care indică dacă produsul este asignat sau nu.
    }
}
