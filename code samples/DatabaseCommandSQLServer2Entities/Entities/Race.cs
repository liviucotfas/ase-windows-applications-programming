namespace DatabaseCommand.Entities
{
	public class Race
	{
		public int RaceId { get; set; }
		public string Name { get; set; }

		public Race(int raceId, string name)
		{
			RaceId = raceId;
			Name = name;
		}
	}
}
