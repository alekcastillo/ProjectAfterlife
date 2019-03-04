using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
	public Player player;
	public static SceneManager instance {get; private set;}

	// Use this for initialization
	void Awake () {
		if (instance == null) instance = this;
		else Destroy(gameObject);

		player = FindObjectOfType<Player>();
	}
}
