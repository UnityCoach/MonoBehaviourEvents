//
//  MouseEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Mouse Events")]
	[RequireComponent (typeof (Collider))]
	public class MouseEvents : MonoBehaviourMessageEvents
	{
		public enum MouseEventType {Enter, Over, Exit, Down, Up, UpAsButton, Drag}
		new Collider collider;

		public MouseEventType mouseEventType;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;
		public ColliderEvent colliderEvent;

		void Awake ()
		{
			collider = GetComponent<Collider>();
		}

		void OnMouseDown ()
		{
			if (mouseEventType != MouseEventType.Down)
				return;
			InvokeEvents ();
		}

		void OnMouseDrag ()
		{
			if (mouseEventType != MouseEventType.Drag)
				return;
			InvokeEvents ();
		}

		void OnMouseEnter ()
		{
			if (mouseEventType != MouseEventType.Enter)
				return;
			InvokeEvents ();
		}

		void OnMouseExit ()
		{
			if (mouseEventType != MouseEventType.Exit)
				return;
			InvokeEvents ();
		}

		void OnMouseOver ()
		{
			if (mouseEventType != MouseEventType.Over)
				return;
			InvokeEvents ();
		}

		void OnMouseUp ()
		{
			if (mouseEventType != MouseEventType.Up)
				return;
			InvokeEvents ();
		}

		void OnMouseUpAsButton ()
		{
			if (mouseEventType != MouseEventType.UpAsButton)
				return;
			InvokeEvents ();
		}

		void InvokeEvents ()
		{
			simpleEvent.Invoke ();
			gameObjectEvent.Invoke (gameObject);
			colliderEvent.Invoke (collider);
		}
	}
}