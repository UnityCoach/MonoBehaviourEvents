//
//  TriggerEvents.cs
//
//  Author:
//       Frederic Moreau <info@unitycoach.ca>
//
//  Copyright (c) 2018 Frederic Moreau, UnityCoach (Jikkou Publishing Inc.)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace BehaviourEvents
{
	[AddComponentMenu ("UnityCoach/Behaviour Events/Trigger Events")]
	[RequireComponent (typeof (Collider))]
	public class TriggerEvents : MonoBehaviourMessageEvents
	{
		public enum TriggerEventType {Enter, Stay, Exit}
		new Collider collider;

		public TriggerEventType triggerEventType;
		public bool useTag;
		public string matchTag;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;
		public ColliderEvent colliderEvent;
		public CollisionEvent collisionEvent;

		void Awake ()
		{
			collider = GetComponent<Collider>();
		}

		void OnTriggerEnter (Collider other)
		{
			if (triggerEventType != TriggerEventType.Enter)
				return;
			InvokeEvents (other);
		}

		void OnTriggerStay (Collider other)
		{
			if (triggerEventType != TriggerEventType.Stay)
				return;
			InvokeEvents (other);
		}

		void OnTriggerExit (Collider other)
		{
			if (triggerEventType != TriggerEventType.Exit)
				return;
			InvokeEvents (other);
		}

		void InvokeEvents (Collider other)
		{
			if (useTag && matchTag != other.gameObject.tag)
				return;

			simpleEvent.Invoke ();
			gameObjectEvent.Invoke (other.gameObject);
			colliderEvent.Invoke (other);
			collisionEvent.Invoke (collider, other);
		}
	}
}