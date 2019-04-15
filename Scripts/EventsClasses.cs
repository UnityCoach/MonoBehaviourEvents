//
//  EventsClasses.cs
//
//  Author:
//       Frederic Moreau <info@unitycoach.ca>
//
//  Copyright (c) 2018 Frederic Moreau, UnityCoach (Jikkou Publishing Inc.)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

namespace BehaviourEvents
{
	/// <summary>
	/// Base class for all MonoBehaviour message events handlers.
	/// </summary>
	public abstract class MonoBehaviourMessageEvents : MonoBehaviour {}

	/// <summary>
	/// Unity Event passing a GameObject object.
	/// </summary>
	[Serializable]
	public class GameObjectEvent : UnityEvent<GameObject> {}

	/// <summary>
	/// Unity Event passing a Transform object.
	/// </summary>
	[Serializable]
	public class TransformEvent : UnityEvent<Transform> {}

	/// <summary>
	/// Unity Event passing a Renderer object.
	/// </summary>
	[Serializable]
	public class RendererEvent : UnityEvent<Renderer> {}

	/// <summary>
	/// Unity Event passing a Vector3 object.
	/// </summary>
	[Serializable]
	public class Vector3Event : UnityEvent<Vector3> {}

	/// <summary>
	/// Unity Event passing a Vector2 object.
	/// </summary>
	[Serializable]
	public class Vector2Event : UnityEvent<Vector2> {}

	/// <summary>
	/// Unity Event passing a Collider object.
	/// </summary>
	[Serializable]
	public class ColliderEvent : UnityEvent<Collider> {}

	/// <summary>
	/// Unity Event passing two Collider objects.
	/// </summary>
	[Serializable]
	public class CollisionEvent : UnityEvent<Collider, Collider> {}

	/// <summary>
	/// Unity Event passing a Collider2D object.
	/// </summary>
	[Serializable]
	public class Collider2DEvent : UnityEvent<Collider2D> {}

	/// <summary>
	/// Unity Event passing two Collider2D objects.
	/// </summary>
	[Serializable]
	public class Collision2DEvent : UnityEvent<Collider2D, Collider2D> {}

	/// <summary>
	/// Unity Event passing a string object.
	/// </summary>
	[Serializable]
	public class StringEvent : UnityEvent<string> {}

	/// <summary>
	/// Unity Event passing a string and an int.
	/// </summary>
	[Serializable]
	public class StringIntEvent : UnityEvent<string, int> {}

	/// <summary>
	/// Unity Event passing a string and a float.
	/// </summary>
	[Serializable]
	public class StringFloatEvent : UnityEvent<string, float> {}

	/// <summary>
	/// Unity Event passing a string and a bool.
	/// </summary>
	[Serializable]
	public class StringBoolEvent : UnityEvent<string, bool> {}

	/// <summary>
	/// Unity Event passing a string object.
	/// </summary>
	[Serializable]
	public class IntEvent : UnityEvent<int> {}

	/// <summary>
	/// Unity Event passing two int objects.
	/// </summary>
	[Serializable]
	public class IntIntEvent : UnityEvent<int, int> {}

	/// <summary>
	/// Unity Event passing an int and a float.
	/// </summary>
	[Serializable]
	public class IntFloatEvent : UnityEvent<int, float> {}

	/// <summary>
	/// Unity Event passing an int and a bool.
	/// </summary>
	[Serializable]
	public class IntBoolEvent : UnityEvent<int, bool> {}
}