using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class GeraldinePoon : NPC
{
	public new static string NPCId => "geraldine_poon";

	internal GeraldinePoon()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "geraldine_poon"))
	{
	}
}
