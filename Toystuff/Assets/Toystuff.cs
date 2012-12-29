using UnityEngine;
using System.Collections;

public class Toystuff : MonoBehaviour {
	
	
	public Texture2D bg;
	public Texture2D beard;
	public Texture2D beard1;
	public Texture2D beard2;
	public Texture2D beard3;
	public Texture2D beard4;
	public Texture2D beard5;
	public Texture2D beard6;
	public Texture2D beard7;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()  {
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),bg);
		  
		GUILayout.BeginHorizontal();
		
			GUILayout.BeginVertical ();
		    GUILayout.Label(beard);
		    //GUILayout.Label("RapperMax");
			GUILayout.Label(beard1);
		    //GUILayout.Label("RapperRed");
			GUILayout.Label(beard2);
		    //GUILayout.Label("RapperBlue");
			GUILayout.Label(beard3);
		    //GUILayout.Label("RapperYellow");
		    GUILayout.EndVertical ();
		
		    GUILayout.BeginVertical ();
		    GUILayout.Label(beard);
			GUILayout.Label(beard1);
			GUILayout.Label(beard2);
			GUILayout.Label(beard3);			
		    GUILayout.EndVertical ();
		
		    GUILayout.BeginVertical ();
		    GUILayout.Label(beard4);
			GUILayout.Label(beard5);
			GUILayout.Label(beard6);
			GUILayout.Label(beard7);			
		    GUILayout.EndVertical ();
		
		    GUILayout.BeginVertical ();
		    GUILayout.Label(beard);
			GUILayout.Label(beard1);
			GUILayout.Label(beard2);
			GUILayout.Label(beard3);			
		    GUILayout.EndVertical ();
		
		    GUILayout.BeginVertical ();
		    GUILayout.Label(beard);
			GUILayout.Label(beard1);
			GUILayout.Label(beard2);
			GUILayout.Label(beard3);			
		    GUILayout.EndVertical ();
		
		    GUILayout.BeginVertical ();
		    GUILayout.Label(beard);
			GUILayout.Label(beard1);
			GUILayout.Label(beard2);
			GUILayout.Label(beard3);			
		    GUILayout.EndVertical ();
		
		GUILayout.EndHorizontal();
	}	
		
}