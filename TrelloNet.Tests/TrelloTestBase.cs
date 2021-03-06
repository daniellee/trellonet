using System.Configuration;
using NUnit.Framework;

namespace TrelloNet.Tests
{
	public class TrelloTestBase
	{
		protected Trello _trelloReadOnly;
		protected Trello _trelloReadWrite;

		[SetUp]
		public void Setup()
		{
			_trelloReadOnly = new Trello(ConfigurationManager.AppSettings["ApplicationKey"]);
			_trelloReadOnly.Authorize(ConfigurationManager.AppSettings["MemberReadToken"]);

			_trelloReadWrite = new Trello(ConfigurationManager.AppSettings["ApplicationKey"]);
			_trelloReadWrite.Authorize(ConfigurationManager.AppSettings["MemberWriteToken"]);	
		}
	}
}