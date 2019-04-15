//
//  CollisionEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Collider Events")]
	[RequireComponent (typeof (Collider))]
	public class CollisionEvents : MonoBehaviourMessageEvents
	{
		public enum CollisionEventType {Enter, Stay, Exit}
		new Collider collider;

		public CollisionEventType collisionEventType;
		public bool useTag;
		public string matchTag;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;
		public ColliderEvent colliderEvent;
		public Vector3Event contactEvent;
		public CollisionEvent collisionEvent;

		void Awake ()
		{
			collider = GetComponent<Collider>();
		}

		void OnCollisionEnter (Collision col)
		{
			if (collisionEventType != CollisionEventType.Enter)
				return;
			InvokeEvents (col);
		}

		void OnCollisionStay (Collision col)
		{
			if (collisionEventType != CollisionEventType.Stay)
				return;
			InvokeEvents (col);
		}

		void OnCollisionExit (Collision col)
		{
			if (collisionEventType != CollisionEventType.Exit)
				return;
			InvokeEvents (col);
		}

		void InvokeEvents (Collision col)
		{
			if (useTag && matchTag != col.gameObject.tag)
				return;

			simpleEvent.Invoke ();
			gameObjectEvent.Invoke (col.gameObject);
			colliderEvent.Invoke (col.collider);
			contactEvent.Invoke (col.contacts[0].point);
			collisionEvent.Invoke (collider, col.collider);
		}
	}
}