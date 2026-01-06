using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class TrentSherman : NPC
{
	public new static string NPCId => "trent_sherman";

	internal TrentSherman()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "trent_sherman"))
	{
	}
}
