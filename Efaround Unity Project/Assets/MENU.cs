using UnityEngine;
using System.Collections;

public class MENU : MonoBehaviour
{

	public static bool IsOpen { get; private set; }

	[SerializeField]
	private GameObject menuUI;

	void Start()
	{
		if (menuUI.activeSelf)
			menuUI.SetActive(false);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			EnableMenu();
		}
		if (Input.GetKeyUp(KeyCode.Q))
		{
			DisableMenu();
		}
	}

	void EnableMenu()
	{
		IsOpen = true;
		menuUI.SetActive(true);
	}

	void DisableMenu()
	{
		IsOpen = false;
		menuUI.SetActive(false);
	}

}
