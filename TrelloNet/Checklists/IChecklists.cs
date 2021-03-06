using System.Collections.Generic;

namespace TrelloNet
{
	public interface IChecklists
	{
		Checklist WithId(string checklistId);
		IEnumerable<Checklist> ForBoard(IBoardId board);
		IEnumerable<Checklist> ForCard(ICardId card);
		Checklist Add(string name, IBoardId board);
		void ChangeName(IChecklistId checklist, string name);
		void AddCheckItem(IChecklistId checklist, string name);
		void RemoveCheckItem(IChecklistId checklist, string checkItemId);
	}
}