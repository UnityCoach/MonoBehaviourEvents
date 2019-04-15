//
//  FormatText.cs
//
//  Author:
//       Frederic Moreau <info@unitycoach.ca>
//
//  Copyright (c) 2018 Frederic Moreau, UnityCoach (Jikkou Publishing Inc.)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BehaviourEvents
{
	[AddComponentMenu ("UnityCoach/Behaviour Events/Triggers/Format Text")]
	public class FormatText : MonoBehaviourMessageEvents
	{
		public string textFormat = "Value = {0}";

		public StringEvent textFormatEvent;

		private string _formattedText;
		public string formattedText
		{
			get { return _formattedText; }
			private set
			{
				if (value != _formattedText)
				{
					_formattedText = value;
					textFormatEvent.Invoke (_formattedText);
				}
			}
		}

		public void Format (string str)
		{
			formattedText = string.Format (textFormat, str);
		}

		public void Format (int str)
		{
			formattedText = string.Format (textFormat, str);
		}

		public void Format (float str)
		{
			formattedText = string.Format (textFormat, str);
		}
	}
}