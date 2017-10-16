using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickChangeBackground : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (spriteRenderer == null) {
			spriteRenderer.sprite = sprite1;
		}
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown(KeyCode.Space)) {
				changeSprite ();
			}
				
	}

			
	void changeSprite() {
		if (spriteRenderer.sprite == sprite1) {
			spriteRenderer.sprite = sprite2;
		} else {
			spriteRenderer.sprite = sprite1;
		}
	}
}
