namespace GymManagmentSystem.Entitys
{ 
    #region video02
    public class Member : GymUser
    {
        
        public string? photo { get; set; }
        #region video05
        public ICollection<MemberShip>? MemberShips { get; set; }
        #endregion
    }
    #endregion
}
