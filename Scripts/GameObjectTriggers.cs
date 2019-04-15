//
//  GameObjectTriggers.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/GameObject")]
	public class GameObjectTriggers : MonoBehaviourMessageEvents
	{
		public void DestroyGameObject (GameObject gObject)
		{
			Destroy (gObject);
		}
	}
}