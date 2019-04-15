//
//  MonoBehaviourMessageEventsEditor.cs
//
//  Author:
//       Frederic Moreau <info@unitycoach.ca>
//
//  Copyright (c) 2018 Frederic Moreau, UnityCoach (Jikkou Publishing Inc.)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace BehaviourEvents
{
	[CustomEditor (typeof (MonoBehaviourMessageEvents), true)]
	public class MonoBehaviourMessageEventsEditor : Editor
	{
		bool _displayInfo;
		string _info = "MonoBehaviour Message Events\n" +
			"Copyright (c) 2018 Frederic Moreau, Jikkou Publishinc Inc.\n" +
			"Twitter : @UnityCoach\n" +
			"More information on http://unitycoach.ca";
		
		public override void OnInspectorGUI ()
		{
			_displayInfo = EditorGUILayout.Foldout (_displayInfo, "Information");
			if (_displayInfo)
				EditorGUILayout.HelpBox (_info, MessageType.None);
			
			DrawDefaultInspector();
		}
	}
}