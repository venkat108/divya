using UnityEngine;
using System.Collections;

public class ToyComponent : MonoBehaviour {

	 
	 public Texture2D Dude;
	 public GUIText DudeName = new GUIText();	
	
    
    void Start() {
		
		DudeName.text = "x";
//		GUILayout.BeginVertical();
//		GUILayout.Label(Dude);
//		GUILayout.Label("DudeName");
//		
//		GUILayout.EndVertical();
        

	 
    }
}
