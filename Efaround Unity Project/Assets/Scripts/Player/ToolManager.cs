using UnityEngine;

public class ToolManager : MonoBehaviour {

	private Tool[] tools;

	private Tool selectedTool;

	void Start ()
	{
		tools = GetComponents<Tool>();
		SelectToolByType<Tool_Builder>();
	}

	private void SelectToolByType<T> ()
	{
		foreach (Tool tool in tools)
		{
			if (tool.GetType() == typeof(T))
			{
				tool.enabled = true;
				selectedTool = tool;
			} else
			{
				tool.enabled = false;
			}
		}
	}

	public void SelectToolByIndex (int index)
	{
		for (int i = 0; i < tools.Length; i++)
		{
			if(i == index)
			{
				tools[i].enabled = true;
				selectedTool = tools[i];
            } else
			{
				tools[i].enabled = false;
			}
        }
	}

	public void SelectBuilder ()
	{
		SelectToolByType<Tool_Builder>();
	}

}
