namespace GymManagmentSystem.Entitys
{
    #region video02
    public class Plan : BaseEntity<int>
    {
       
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }

        #region vieo 05
        public ICollection<MemberShip>? MemberShips { get; set; }
        #endregion
    }
    #endregion
}
