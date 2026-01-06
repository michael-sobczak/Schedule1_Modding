using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class GregFliggle : NPC
{
	public new static string NPCId => "greg_fliggle";

	internal GregFliggle()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "greg_fliggle"))
	{
	}
}
