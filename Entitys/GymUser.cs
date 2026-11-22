namespace GymManagmentSystem.Entitys
{
    #region video02
    public class GymUser : BaseEntity<int>
    {
      
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Address? Address { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
    }

    #endregion
}
