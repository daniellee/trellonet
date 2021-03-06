using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrelloNet.Internal
{
	internal class AsyncMembers : IAsyncMembers
	{
		private readonly TrelloRestClient _restClient;

		internal AsyncMembers(TrelloRestClient restClient)
		{
			_restClient = restClient;
		}

		public Task<Member> WithId(string memberIdOrUsername)
		{
			return _restClient.RequestAsync<Member>(new MembersRequest(memberIdOrUsername));
		}

		public Task<Member> Me()
		{
			return _restClient.RequestAsync<Member>(new MembersRequest(new Me()));
		}

		public Task<IEnumerable<Member>> ForBoard(IBoardId board, MemberFilter filter = MemberFilter.Default)
		{
			return _restClient.RequestListAsync<Member>(new MembersForBoardRequest(board, filter));
		}

		public Task<IEnumerable<Member>> ForCard(ICardId card)
		{
			return _restClient.RequestListAsync<Member>(new MembersForCardRequest(card));
		}

		public Task<IEnumerable<Member>> ForOrganization(IOrganizationId organization, MemberFilter filter = MemberFilter.Default)
		{
			return _restClient.RequestListAsync<Member>(new MembersForOrganizationRequest(organization, filter));
		}

		public Task<Member> ForToken(string token)
		{
			return _restClient.RequestAsync<Member>(new MembersForTokenRequest(token));
		}
	}
}