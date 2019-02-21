using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowborgController : MonoBehaviour {

	private GameObject snowCore;
	private Transform[] children;

	// Use this for initialization
	void Start () {

		children = GetComponentsInChildren<Transform>();

		foreach(Transform child in children)
		{
			if(child.gameObject.name == "Core")
			{
				snowCore = child.gameObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
