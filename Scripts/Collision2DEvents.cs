//
//  Collision2DEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Collider2D Events")]
	[RequireComponent (typeof (Collider2D))]
	public class Collision2DEvents : MonoBehaviourMessageEvents
	{
		public enum CollisionEventType {Enter, Stay, Exit}
		new Collider2D collider;

		public CollisionEventType collisionEventType;
		public bool useTag;
		public string matchTag;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;
		public Collider2DEvent colliderEvent;
		public Vector3Event contactEvent;
		public Collision2DEvent collisionEvent;

		void Awake ()
		{
			collider = GetComponent<Collider2D>();
		}

		void OnCollisionEnter2D (Collision2D col)
		{
			if (collisionEventType != CollisionEventType.Enter)
				return;
			InvokeEvents (col);
		}

		void OnCollisionStay2D (Collision2D col)
		{
			if (collisionEventType != CollisionEventType.Stay)
				return;
			InvokeEvents (col);
		}

		void OnCollisionExit2D (Collision2D col)
		{
			if (collisionEventType != CollisionEventType.Exit)
				return;
			InvokeEvents (col);
		}

		void InvokeEvents (Collision2D col)
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