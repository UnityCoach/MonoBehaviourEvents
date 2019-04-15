//
//  Counter.cs
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
	[AddComponentMenu ("UnityCoach/Behaviour Events/Counter")]
	public class Counter : MonoBehaviourMessageEvents
	{
		public IntEvent counterEvent;

		private int _count;
		public int count
		{
			get { return _count; }
			private set
			{
				if (value != _count)
				{
					_count = value;
					counterEvent.Invoke (_count);
				}
			}
		}

		public void Add (int value)
		{
			count += value;
		}

		public void Rem (int value)
		{
			count -= value;
		}

		public void Multiply (int value)
		{
			count *= value;
		}

		public void Multiply (float value)
		{
			count = (int)((float)count * value);
		}

		public void Divide (int value)
		{
			if (value != 0)
				count /= value;
		}

		public void Divide (float value)
		{
			if (value != 0)
				count = (int)((float)count / value);
		}

		public void Set (int value)
		{
			count = value;
		}
	}
}