using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class GeorgeGreene : NPC
{
	public new static string NPCId => "george_greene";

	internal GeorgeGreene()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "george_greene"))
	{
	}
}
