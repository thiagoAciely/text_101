using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/State")]
public class State : ScriptableObject
{
	[TextArea(15, 20)]
	[SerializeField]
	private string stateText;
	[SerializeField]
	private string stateTitle;

	[SerializeField]
	private State[] nextStates;

	public string GetStory()
	{
		return this.stateText;
	}

	public string GetTitle()
	{
		return this.stateTitle;
	}

	public State[] GetNext()
	{
		return this.nextStates;
	}
}
