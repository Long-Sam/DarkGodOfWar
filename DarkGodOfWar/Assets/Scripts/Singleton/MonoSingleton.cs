using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton <T>: MonoBehaviour where T:MonoSingleton<T>{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (null == instance)
            {
                GameObject go = new GameObject(typeof(T).Name); 
                instance = go.AddComponent<T>();
            }
            return instance;
        }
    }
	protected virtual void Awake()
    {
        instance = this as T;
    }
}
