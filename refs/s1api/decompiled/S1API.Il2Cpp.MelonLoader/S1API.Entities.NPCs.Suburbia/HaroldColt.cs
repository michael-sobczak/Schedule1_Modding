using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class HaroldColt : NPC
{
	public new static string NPCId => "harold_colt";

	internal HaroldColt()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "harold_colt"))
	{
	}
}
