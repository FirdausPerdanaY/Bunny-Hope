using UnityEngine;

public class ScrollScript : MonoBehaviour {

	public float speed =0;

	void Update () {
		gameObject.GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (Time.time*speed,0f);
	}
}
