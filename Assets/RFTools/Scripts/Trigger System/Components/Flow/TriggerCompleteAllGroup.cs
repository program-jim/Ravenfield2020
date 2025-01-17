using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger {

	[AddComponentMenu("Trigger/Flow/Trigger Complete All Group")]
	[TriggerDoc("When triggered, checks if all MonoBehaviours in the Dependencies list has triggered this component. If all dependencies have triggered at least once, sends OnAllTriggersDone")]
	public class TriggerCompleteAllGroup : TriggerReceiver
    {
		public List<MonoBehaviour> dependencies;

		[AutoPopulateChildReceivers]
		public TriggerSend onAllTriggersDone;
	}
}