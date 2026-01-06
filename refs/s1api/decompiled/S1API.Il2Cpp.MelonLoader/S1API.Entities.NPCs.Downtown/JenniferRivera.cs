using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class JenniferRivera : NPC
{
	public new static string NPCId => "jennifer_rivera";

	internal JenniferRivera()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jennifer_rivera"))
	{
	}
}
