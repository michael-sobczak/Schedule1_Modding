using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class KimDelaney : NPC
{
	public new static string NPCId => "kim_delaney";

	internal KimDelaney()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "kim_delaney"))
	{
	}
}
