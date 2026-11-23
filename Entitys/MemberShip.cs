using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagmentSystem.Entitys
{
    #region video05
    public class MemberShip : BaseEntity<int>
    { 
        public int PlanID { get; set; }
        public Plan plan { get; set; }
        public int MemberID { get; set; }
        public Member member { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string status => StartDate > DateTime.Now ? "Upcoming" : EndDate < DateTime.Now ? "Active" : "Expired";

    }
    #endregion
}
