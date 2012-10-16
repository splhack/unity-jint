using UnityEngine;
using System;
using System.Collections;
using Jint;

public class Test : MonoBehaviour
{
	void Start()
	{
		JintEngine e = new JintEngine();

		e.SetFunction("log",
			new Jint.Delegates.Action<object>((a) => Debug.Log(a)));

		e.SetFunction("add",
			new Jint.Delegates.Func<double, double, double>((a,b) => a + b));

		TextAsset script = (TextAsset)Resources.Load("Test");

		e.Run(script.text);
	}
}
