using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class BethPenn : NPC
{
	public new static string NPCId => "beth_penn";

	internal BethPenn()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "beth_penn"))
	{
	}
}
