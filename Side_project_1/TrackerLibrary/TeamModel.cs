namespace TrackerLibrary
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        #region In following code is equal to write in constructor
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        //public TeamModel()
        //{
        //    TeamMembers = new List<PersonModel>();
        //}
        #endregion 


    }
}
