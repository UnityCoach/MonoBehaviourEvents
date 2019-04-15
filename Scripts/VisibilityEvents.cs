//
//  VisibilityEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Visibility Events")]
	[RequireComponent (typeof (Renderer))]
	public class VisibilityEvents : MonoBehaviourMessageEvents
	{
		public enum VisibilityEventType {BecameVisible, BecameInvisible}
		new Renderer renderer;

		public VisibilityEventType monoEventType;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;
		public RendererEvent rendererEvent;

		void Awake ()
		{
			renderer = GetComponent<Renderer>();
		}

		void OnBecameInvisible ()
		{
//			Debug.Log("became invisible");
//			Debug.Break();
			if (monoEventType != VisibilityEventType.BecameInvisible)
				return;
			InvokeEvents ();
		}

		void OnBecameVisible ()
		{
//			Debug.Log("became visible");
//			Debug.Break();
			if (monoEventType != VisibilityEventType.BecameVisible)
				return;
			InvokeEvents ();
		}

		void InvokeEvents ()
		{
			simpleEvent.Invoke ();
			gameObjectEvent.Invoke (gameObject);
			rendererEvent.Invoke (renderer);
		}
	}
}