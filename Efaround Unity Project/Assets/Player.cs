using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static Player instance { get; private set; }
	new public static Camera camera { get; private set; }

	[SerializeField]
	private Camera m_camera;

	void Awake ()
	{
		instance = this;
		camera = m_camera;
    }

}
