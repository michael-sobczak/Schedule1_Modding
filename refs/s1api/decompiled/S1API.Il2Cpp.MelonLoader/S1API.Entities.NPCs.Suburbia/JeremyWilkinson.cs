using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class JeremyWilkinson : NPC
{
	public new static string NPCId => "jeremy_wilkinson";

	internal JeremyWilkinson()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jeremy_wilkinson"))
	{
	}
}
