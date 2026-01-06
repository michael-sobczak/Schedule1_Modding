using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class UncleNelson : NPC
{
	public new static string NPCId => "uncle_nelson";

	internal UncleNelson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "uncle_nelson"))
	{
	}
}
