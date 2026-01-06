using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class MelissaWood : NPC
{
	public new static string NPCId => "melissa_wood";

	internal MelissaWood()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "melissa_wood"))
	{
	}
}
