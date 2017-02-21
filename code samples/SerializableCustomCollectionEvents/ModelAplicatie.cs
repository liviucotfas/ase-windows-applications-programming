namespace SerializableCustomCollectionEvents
{
	internal class ModelAplicatie
	{
		public static ColectieComenzi Comenzi { get; set; }

		static ModelAplicatie()
		{
			Comenzi = new ColectieComenzi();
		}
	}
}
