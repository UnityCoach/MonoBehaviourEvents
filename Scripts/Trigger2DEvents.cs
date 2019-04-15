//
//  Trigger2DEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Trigger2D Events")]
	[RequireComponent (typeof (Collider2D))]
	public class Trigger2DEvents : MonoBehaviourMessageEvents
	{
		public enum TriggerEventType {Enter, Stay, Exit}
		new Collider2D collider;

		public TriggerEventType triggerEventType;
		public bool useTag;
		public string matchTag;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;
		public Collider2DEvent colliderEvent;
		public Collision2DEvent collisionEvent;

		void Awake ()
		{
			collider = GetComponent<Collider2D>();
		}

		void OnTriggerEnter2D (Collider2D other)
		{
			if (triggerEventType != TriggerEventType.Enter)
				return;
			InvokeEvents (other);
		}

		void OnTriggerStay2D (Collider2D other)
		{
			if (triggerEventType != TriggerEventType.Stay)
				return;
			InvokeEvents (other);
		}

		void OnTriggerExit2D (Collider2D other)
		{
			if (triggerEventType != TriggerEventType.Exit)
				return;
			InvokeEvents (other);
		}

		void InvokeEvents (Collider2D other)
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