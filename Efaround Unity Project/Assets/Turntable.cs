using UnityEngine;

public class Turntable : MonoBehaviour {

	[SerializeField]
	private float speed = 5f;

	void Update ()
	{
		transform.Rotate(Vector3.up, - Time.deltaTime * speed);
	}

}
