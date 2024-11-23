





namespace NTierArchitecture.Entities.Abstractions
{
    // Abstract: Entity Sınfıı new ile oluşturalamaz. New lenemez. bu sınıftan yeni bir entity nesnesi türetilsin istemiyoruz.

    public abstract class Entity
    {
        public Entity() 
        {
            ID=Guid.NewGuid();
        }
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        = DateTime.Now;
    }
}
