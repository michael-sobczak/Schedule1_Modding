using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class JenHeard : NPC
{
	public new static string NPCId => "jen_heard";

	internal JenHeard()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jen_heard"))
	{
	}
}
