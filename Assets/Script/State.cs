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

	[SerializeField]
	[Range(-1, 1)]
	private int extrovertIntrovert = 0;
	[SerializeField]
	[Range(-1, 1)]
	private int intuitionSensation = 0;
	[SerializeField]
	[Range(-1, 1)]
	private int thinkingFeeling = 0;
	[SerializeField]
	[Range(-1, 1)]
	private int praticalJudicial = 0;


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

	public int[]  GetJung ()
	{
		int[] result = { extrovertIntrovert, intuitionSensation, thinkingFeeling, praticalJudicial };
		return result;
	}
}
