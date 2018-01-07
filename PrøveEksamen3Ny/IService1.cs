using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrøveEksamen3Ny
{
	[ServiceContract]
	public interface IService1
	{

		[OperationContract]
		[WebInvoke(Method = "GET",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "Catch/")]
		List<Catch> GetCatches();

		[OperationContract]
		[WebInvoke(Method = "GET",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "Catch/{id}")]
		Catch GetOneCatch(string id);

		[OperationContract]
		[WebInvoke(Method = "POST",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "AddCatch/")]
		void AddCatch(Catch newCatch);

		[OperationContract]
		[WebInvoke(Method = "DELETE",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "DeleteCatch/{id}")]
		void DeleteCatch(string id);

		[OperationContract]
		[WebInvoke(Method = "PUT",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "UpdateCatch/")]
		void UpdateCatch(Catch myCatch);
		
	}

	[DataContract]
	public class Catch
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Navn { get; set; }
		[DataMember]
		public string Art { get; set; }
		[DataMember]
		public double Vægt { get; set; }
		[DataMember]
		public string Sted { get; set; }
		[DataMember]
		public int Uge { get; set; }
	}
}
