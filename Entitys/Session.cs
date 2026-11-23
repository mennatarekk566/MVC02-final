namespace GymManagmentSystem.Entitys
{
    #region video02
    public class Session : BaseEntity<int>
    {
        
        public string? description { get; set; }
        public int capacity { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        #region vido05
        public int TrainerId { get; set; } //FK
        public Trainer? trainer { get; set; }
        #endregion
    }
    #endregion
}
