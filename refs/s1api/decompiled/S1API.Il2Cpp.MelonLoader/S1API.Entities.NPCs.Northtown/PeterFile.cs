using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class PeterFile : NPC
{
	public new static string NPCId => "peter_file";

	internal PeterFile()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "peter_file"))
	{
	}
}
