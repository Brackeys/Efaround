using UnityEngine;

public class Player_ToolManager : MonoBehaviour {

	[SerializeField]
	private GameObject explosion;

	[SerializeField]
	private Transform playerCamera;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit _hitInfo;
			if (Physics.Raycast(playerCamera.position, playerCamera.forward, out _hitInfo))
			{
				Instantiate(explosion, _hitInfo.point, Quaternion.LookRotation(_hitInfo.normal));
            }
		}
	}
}
