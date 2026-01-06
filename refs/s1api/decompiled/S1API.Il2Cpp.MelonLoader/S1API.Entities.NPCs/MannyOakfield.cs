using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class MannyOakfield : NPC
{
	public new static string NPCId => "manny_oakfield";

	internal MannyOakfield()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "manny_oakfield"))
	{
	}
}
