using UnityEngine;
using System.Linq;

public class Tool_Builder : Tool {

	[SerializeField]
	private PropDB propDB;

	[SerializeField]
	private GameObject prop;

	protected override void UseTool ()
	{
		RaycastHit _hitInfo;
		if (Physics.Raycast(Player.camera.transform.position, Player.camera.transform.forward, out _hitInfo))
		{
			GameObject _ins = (GameObject)Instantiate(prop, _hitInfo.point, Quaternion.LookRotation(-_hitInfo.normal));
			Collider _col = _ins.GetComponent<Collider>();

			_ins.transform.position += Vector3.Scale(_hitInfo.normal, _col.bounds.extents);
		}
	}

	public void SelectPropByName(string name)
	{
		foreach (GameObject _prop in propDB.props)
		{
			if (_prop.name == name)
				prop = _prop;
		}
	}

}
