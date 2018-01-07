using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrøveEksamen3Ny
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1
	{
		public static List<Catch> CatchList = new List<Catch>
		{
			new Catch {Art = "TestArt", Id = 1, Navn = "TestNavn", Sted = "TestSted", Uge = 1, Vægt = 1.1},
			new Catch {Art = "TestArt2", Id = 2, Navn = "TestNavn2", Sted = "TestSted2", Uge = 2, Vægt = 2.2}
		};
		

		public List<Catch> GetCatches()
		{
			return CatchList;
		}

		public Catch GetOneCatch(string id)
		{
			foreach (Catch c in CatchList)
			{
				if (c.Id == Int32.Parse(id))
				{
					return c;
				}
			}
			throw new IndexOutOfRangeException("Catch med id findes ikke");
		}

		public void AddCatch(Catch newCatch)
		{
			CatchList.Add(newCatch);
		}

		public void DeleteCatch(string id)
		{
			CatchList.RemoveAll(x => x.Id == Int32.Parse(id));
		}

		public void UpdateCatch(Catch myCatch)
		{
			CatchList.RemoveAll(x => x.Id == myCatch.Id);
			CatchList.Add(myCatch);
		}
	}
}
