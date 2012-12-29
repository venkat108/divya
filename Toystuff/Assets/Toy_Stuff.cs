using UnityEngine;
using System.Collections;

public class Toy_Stuff : MonoBehaviour {
	
	void Start () 
	{		
	  ShowStuff();    
	}
	
	//http://docs.unity3d.com/Documentation/Manual/InstantiatingPrefabs.html
	
	Texture2D texture;
	void ShowStuff()
	{
		GameObject instance = Instantiate(Resources.Load("ToyComponent")) as GameObject;
		//print(instance);
		
		print("comp:"+instance.GetComponent<ToyComponent>());
		print("dudename:"+GetComponent<ToyComponent>().DudeName);
		instance.GetComponent<ToyComponent>().DudeName = GetComponent<ToyComponent>().DudeName;
		print(instance.GetComponent<ToyComponent>().DudeName);		
	}
}
