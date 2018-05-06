using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 

[RequireComponent (typeof(TextMeshProUGUI))] 

public class TextMeshTyper : MonoBehaviour {

	private TextMeshProUGUI _textMesh; 
	private string [] _textCharacter; 
	public float timeBetweenCharacters;
	private float timeSinceLastCharacter;

	// Use this for initialization
	void Start () {

		_textMesh = GetComponent<TextMeshProUGUI> (); 
		_textCharacter = new string[_textMesh.text.Length]; 

		for (int i = 0; i < _textMesh.text.Length; i++) {
			_textCharacter [i] = _textMesh.text.Substring (i, 1);
		} 

		_textMesh.text = ""; 
		timeSinceLastCharacter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (_textMesh.text.Length < _textCharacter.Length) {
			timeSinceLastCharacter += Time.deltaTime;

			if (timeSinceLastCharacter >= timeBetweenCharacters) {
				string currentText = _textMesh.text;
				string newText = currentText + _textCharacter [currentText.Length];
				_textMesh.text = newText;
				timeSinceLastCharacter = 0;
			}
		} else if (Input.GetMouseButtonDown (0)) { 
			SceneManager.LoadScene ("A"); 
		}
	}
}
