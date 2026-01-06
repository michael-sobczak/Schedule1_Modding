using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class LucyPennington : NPC
{
	public new static string NPCId => "lucy_pennington";

	internal LucyPennington()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "lucy_pennington"))
	{
	}
}
