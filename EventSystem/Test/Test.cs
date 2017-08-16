using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	EventMgr mgr = new EventMgr ();
	// Use this for initialization
	void Start ()
	{
		
		mgr.RegisterAction (EventName.test1, Test1);
		mgr.RegisterAction<int> (EventName.test3, Test3);	

		mgr.TriggerAction(EventName.test1);

		mgr.UnRegisterAction(EventName.test1, Test1);

		mgr.TriggerAction(EventName.test1);
	}

	void Test1 ()
	{
		Debug.Log("Test1");
	}

	void Test2 ()
	{
		Debug.Log("Test2");
	}

	void Test3 (int val)
	{
		//Debug.Log("Test3 val is " + val);
	}

	void Test4 (string val)
	{
		//Debug.Log("Test4 val is " + val);
	}

	void Test5(int val1,string val2)
	{
		//Debug.Log("Test4 val1 is " + val1 + " val2 is " + val2);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//mgr.TriggerAction(EventName.test2);
//		mgr.TriggerAction(EventName.test1);
//		mgr.TriggerAction<int>(EventName.test3,2);
//		mgr.TriggerAction<string>(EventName.test4,"xx");
//		mgr.TriggerAction<int,string>(EventName.test5,2,"s");
	}
}
