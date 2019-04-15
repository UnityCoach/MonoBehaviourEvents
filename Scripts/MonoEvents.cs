//
//  MonoEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/MonoBehaviour Events")]
	public class MonoEvents : MonoBehaviourMessageEvents
	{
		public enum MonoEventType {Awake, Start, Update, FixedUpdate, LateUpdate, OnEnable, OnDisable, OnDestroy}

		public MonoEventType monoEventType;
		public UnityEvent simpleEvent;
		public GameObjectEvent gameObjectEvent;

		void Awake ()
		{
			if (monoEventType != MonoEventType.Awake)
				return;
			InvokeEvents ();
		}

		void Start ()
		{
			if (monoEventType != MonoEventType.Start)
				return;
			InvokeEvents ();
		}

		void Update ()
		{
			if (monoEventType != MonoEventType.Update)
				return;
			InvokeEvents ();
		}

		void FixedUpdate ()
		{
			if (monoEventType != MonoEventType.FixedUpdate)
				return;
			InvokeEvents ();
		}

		void LateUpdate ()
		{
			if (monoEventType != MonoEventType.LateUpdate)
				return;
			InvokeEvents ();
		}

		void OnEnable ()
		{
			if (monoEventType != MonoEventType.OnEnable)
				return;
			InvokeEvents ();
		}

		void OnDisable ()
		{
			if (monoEventType != MonoEventType.OnDisable)
				return;
			InvokeEvents ();
		}

		void OnDestroy ()
		{
			if (monoEventType != MonoEventType.OnDestroy)
				return;
			InvokeEvents ();
		}

		void InvokeEvents ()
		{
			simpleEvent.Invoke ();
			gameObjectEvent.Invoke (gameObject);
		}
	}
}