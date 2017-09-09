using UnityEngine;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;
	public float maxSpeed = 10f;

	//BunnyController bun;


	// Update is called once per frame
	void Update () {
		//bun = GetComponent<BunnyController>();

	//	bun.Speed (maxSpeed);

		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}
}
