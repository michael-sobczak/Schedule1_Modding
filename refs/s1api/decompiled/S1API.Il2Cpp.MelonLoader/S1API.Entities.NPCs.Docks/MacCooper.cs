using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class MacCooper : NPC
{
	public new static string NPCId => "mac_cooper";

	internal MacCooper()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "mac_cooper"))
	{
	}
}
