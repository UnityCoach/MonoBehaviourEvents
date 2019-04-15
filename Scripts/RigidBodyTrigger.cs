//
//  RigidBodyTrigger.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/RigidBody")]
	[RequireComponent (typeof (Rigidbody))]
	public class RigidBodyTrigger : MonoBehaviourMessageEvents
	{
		Rigidbody rigidBody;
		public Vector3 forceDirection = default (Vector3);
		public Vector3 torqueDirection = default (Vector3);
		public Vector3 relativeForceDirection = default (Vector3);
		public Vector3 relativeTorqueDirection = default (Vector3);

		void Awake ()
		{
			rigidBody = GetComponent<Rigidbody>();
		}

		public void AddForce (float value)
		{
			rigidBody.AddForce ((forceDirection * value), ForceMode.Impulse);
		}

		public void AddTorque (float value)
		{
			rigidBody.AddTorque ((torqueDirection * value), ForceMode.Impulse);
		}

		public void AddRelativeForce (float value)
		{
			rigidBody.AddRelativeForce ((relativeForceDirection * value), ForceMode.Impulse);
		}

		public void AddRelativeTorque (float value)
		{
			rigidBody.AddRelativeTorque ((relativeTorqueDirection * value), ForceMode.Impulse);
		}

		public void AddForceAtPosition (float value, Vector3 position)
		{
			rigidBody.AddForceAtPosition ((relativeForceDirection * value), position, ForceMode.Impulse);
		}

		public void AddExplosionForce (float value, Vector3 position, float radius)
		{
			rigidBody.AddExplosionForce (value, position, radius);
		}
	}
}