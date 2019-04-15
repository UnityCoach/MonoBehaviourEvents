//
//  DebugTrigger.cs
//
//  Author:
//       Frederic Moreau <info@unitycoach.ca>
//
//  Copyright (c) 2018 Frederic Moreau, UnityCoach (Jikkou Publishing Inc.)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourEvents
{
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/Debug")]
	public class DebugTrigger : MonoBehaviourMessageEvents
	{
		public bool disableBreak;

		public void Log (object obj)
		{
			Debug.Log (obj);
		}

		public void LogWarning (object obj)
		{
			Debug.LogWarning (obj);
		}

		public void LogError (object obj)
		{
			Debug.LogError (obj);
		}

		public void Break ()
		{
			if (!disableBreak)
				Debug.Break ();
		}
	}
}