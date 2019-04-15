//
//  RigidBody2DEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/RigidBody2D")]
	[RequireComponent (typeof (Rigidbody2D))]
	public class RigidBody2DTrigger : MonoBehaviourMessageEvents
	{
		Rigidbody2D rigidBody2d;
		public Vector2 forceDirection = default (Vector2);
		public float torqueDirection = default (float);
		public Vector2 relativeForceDirection = default (Vector2);
		public float relativeTorqueDirection = default (float);

		void Awake ()
		{
			rigidBody2d = GetComponent<Rigidbody2D>();
		}

		public void AddForce (float value)
		{
			rigidBody2d.AddForce ((forceDirection * value), ForceMode2D.Impulse);
		}

		public void AddTorque (float value)
		{
			rigidBody2d.AddTorque ((torqueDirection * value), ForceMode2D.Impulse);
		}

		public void AddRelativeForce (float value)
		{
			rigidBody2d.AddRelativeForce ((relativeForceDirection * value), ForceMode2D.Impulse);
		}

		public void AddForceAtPosition (float value, Vector2 position)
		{
			rigidBody2d.AddForceAtPosition ((relativeForceDirection * value), position, ForceMode2D.Impulse);
		}
	}
}