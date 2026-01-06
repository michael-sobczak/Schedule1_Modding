using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class KarenKennedy : NPC
{
	public new static string NPCId => "karen_kennedy";

	internal KarenKennedy()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "karen_kennedy"))
	{
	}
}
