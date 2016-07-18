using UnityEngine;

public abstract class Tool : MonoBehaviour {
	
	void Update () {
		if (MENU.IsOpen)
			return;

		if (Input.GetMouseButtonDown(0))
		{
			UseTool();
		}
	}

	protected abstract void UseTool();

}
