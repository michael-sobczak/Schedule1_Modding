using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class KeithWagner : NPC
{
	public new static string NPCId => "keith_wagner";

	internal KeithWagner()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "keith_wagner"))
	{
	}
}
