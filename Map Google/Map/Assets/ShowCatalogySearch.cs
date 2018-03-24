using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCatalogySearch : MonoBehaviour {

	public InputField _search_InputField;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowCategoricalSearch()
	{
		StartCoroutine (GetCategorical ());
	}

	IEnumerator GetCategorical()
	{
		string url="https://www.google.com/maps/search/?api=1&query=";
		string input = _search_InputField.text.Replace (' ', '+');
		url += input;
		WWW req = new WWW (url);
		while (!req.isDone)
			yield return null;
		if (req.error == null)
			print (req.text);
	}
}
