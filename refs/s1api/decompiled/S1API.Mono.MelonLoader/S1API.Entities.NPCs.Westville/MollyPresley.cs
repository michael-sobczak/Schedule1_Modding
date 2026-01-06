using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class MollyPresley : NPC
{
	public new static string NPCId => "molly_presley";

	internal MollyPresley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "molly_presley"))
	{
	}
}
