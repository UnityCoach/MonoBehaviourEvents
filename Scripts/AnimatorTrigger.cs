//
//  AnimatorTrigger.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/Animator")]
	[RequireComponent (typeof (Animator))]
	public class AnimatorTrigger : MonoBehaviourMessageEvents
	{
		Animator animator;

		[SerializeField] string _animatorParameterName;
		public string animatorParameterName
		{
			get { return _animatorParameterName; }
			private set
			{
				if (value != _animatorParameterName)
				{
					_animatorParameterName = value;
					animatorHashID = Animator.StringToHash (_animatorParameterName);
				}
			}
		}

		int animatorHashID;

		void Awake ()
		{
			animator = GetComponent<Animator>();
			animatorHashID = Animator.StringToHash (_animatorParameterName);
		}

		public void SetAnimatorTrigger ()
		{
			animator.SetTrigger (animatorHashID);
		}

		public void SetAnimatorBool (bool value)
		{
			animator.SetBool (animatorHashID, value);
		}

		public void SetAnimatorInteger (int value)
		{
			animator.SetInteger (animatorHashID, value);
		}

		public void SetAnimatorFloat (float value)
		{
			animator.SetFloat (animatorHashID, value);
		}
	}
}