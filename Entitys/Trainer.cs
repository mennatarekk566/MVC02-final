using Microsoft.VisualBasic;

namespace GymManagmentSystem.Entitys
{
    #region video02
    public class Trainer : GymUser
    {
        
        public DateTime hireDate { get; set; }
        public Specialty? Specialty { get; set; }
    }
    #endregion
}
