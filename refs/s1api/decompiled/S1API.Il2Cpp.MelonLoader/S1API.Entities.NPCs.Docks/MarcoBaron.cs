using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class MarcoBaron : NPC
{
	public new static string NPCId => "marco_baron";

	internal MarcoBaron()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "marco_baron"))
	{
	}
}
