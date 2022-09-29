using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance;
	private static object _lock = new object();

	public static T Instance
	{
		get
		{
			lock (_lock)
			{
				if (instance != null)
					return instance;

				T[] objects = FindObjectsOfType<T>();
				if (objects.Length > 0)
					instance = objects[0];
				if (objects.Length > 1)
					Debug.LogError($"{typeof(T)} is ({objects.Length}) in the scene.");
				if (instance == null)
					Debug.LogError($"{typeof(T)} can't find");

				return instance;
			}
		}
	}
}