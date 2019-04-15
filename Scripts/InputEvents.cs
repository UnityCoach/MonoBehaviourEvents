//
//  InputEvents.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Inputs")]
	public class InputEvents : MonoBehaviour
	{
		public enum UpdateCall {Update, FixedUpdate, LateUpdate}

		public UpdateCall updateCall;

		[SerializeField] string xInput = "Horizontal";
		[SerializeField] string yInput = "Vertical";
		[SerializeField] string zInput = "Vertical";

		[SerializeField] float xMultipler = 1;
		[SerializeField] float yMultipler = 1;
		[SerializeField] float zMultipler = 1;

		[SerializeField] Vector2Event vector2Event;
		[SerializeField] Vector3Event vector3Event;

		Vector2 v2;
		Vector3 v3;

		void Update ()
		{
			if (updateCall == UpdateCall.Update)
				FireEvents();
		}

		void FixedUpdate ()
		{
			if (updateCall == UpdateCall.FixedUpdate)
				FireEvents();
		}

		void LateUpdate ()
		{
			if (updateCall == UpdateCall.LateUpdate)
				FireEvents();
		}

		void FireEvents ()
		{
			v2.x = Input.GetAxis (xInput) * xMultipler;
			v2.y = Input.GetAxis (yInput) * yMultipler;

			v3.x = Input.GetAxis (xInput) * xMultipler;
			v3.y = Input.GetAxis (yInput) * yMultipler;
			v3.z = Input.GetAxis (zInput) * zMultipler;

			vector2Event.Invoke (v2);
			vector3Event.Invoke (v3);
		}
	}
}