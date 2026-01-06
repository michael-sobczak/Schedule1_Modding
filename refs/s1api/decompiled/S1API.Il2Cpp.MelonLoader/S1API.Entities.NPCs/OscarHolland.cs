using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class OscarHolland : NPC
{
	public new static string NPCId => "oscar_holland";

	internal OscarHolland()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "oscar_holland"))
	{
	}
}
