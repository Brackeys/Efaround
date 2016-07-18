using UnityEngine;

public class Tool_Exploder : Tool {

	[SerializeField]
	private GameObject explosion;

	protected override void UseTool ()
	{
		RaycastHit _hitInfo;
		if (Physics.Raycast(Player.camera.transform.position, Player.camera.transform.forward, out _hitInfo))
		{
			Instantiate(explosion, _hitInfo.point, Quaternion.LookRotation(_hitInfo.normal));
		}
	}

}
