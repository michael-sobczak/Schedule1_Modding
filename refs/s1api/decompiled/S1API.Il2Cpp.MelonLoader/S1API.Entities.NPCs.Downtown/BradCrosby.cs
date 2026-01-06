using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class BradCrosby : NPC
{
	public new static string NPCId => "brad_crosby";

	internal BradCrosby()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "brad_crosby"))
	{
	}
}
