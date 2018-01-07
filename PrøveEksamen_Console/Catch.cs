namespace PrøveEksamen_Console
{
	public class Catch
	{
		public int Id { get; set; }
		public string Navn { get; set; }
		public string Art { get; set; }
		public double Vægt { get; set; }
		public string Sted { get; set; }
		public int Uge { get; set; }

		public Catch()
		{
			
		}

		public Catch(int id, string navn, string art, double vægt, string sted, int uge)
		{
			Id = id;
			Navn = navn;
			Art = art;
			Vægt = vægt;
			Sted = sted;
			Uge = uge;
		}
	}
}