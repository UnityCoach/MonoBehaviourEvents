//
//  Spawn.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/Spawn")]
	public class Spawn : MonoBehaviourMessageEvents
	{
		[SerializeField] GameObject reference;

		public void SpawnObjectAtPosition (Vector3 position)
		{
			Instantiate (reference, position, reference.transform.rotation);
		}
	}
}