using Microsoft.VisualBasic;

namespace GymManagmentSystem.Entitys
{
    #region video02
    public class Trainer : GymUser
    {
        
        public Specialty? Specialty { get; set; }
        #region Video05
   
       public ICollection<Session>? Sessions { get; set; }
        #endregion
    }
    #endregion
}
