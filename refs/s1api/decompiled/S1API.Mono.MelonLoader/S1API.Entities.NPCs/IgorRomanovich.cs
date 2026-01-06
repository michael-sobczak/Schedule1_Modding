using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class IgorRomanovich : NPC
{
	public new static string NPCId => "igor_romanovich";

	internal IgorRomanovich()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "igor_romanovich"))
	{
	}
}
