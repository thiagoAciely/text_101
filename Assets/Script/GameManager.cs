using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private State _startState;
    [SerializeField] 
    private TMP_Text _storyText;
    [SerializeField]
    private Button[] _choiceButtons;

    private State _currentState;

    // Start is called before the first frame update
    void Start()
    {
        StoryUpdate(_startState);
    }

    void StoryUpdate (State nextState)
	{
        Debug.Log(nextState.GetTitle());
        _currentState = nextState;
        _storyText.text = _currentState.GetStory();
        Debug.Log(nextState.GetTitle());
        SetButtons(nextState.GetNext());
    }

    void SetButtons(State[] choices)
	{
        foreach (Button b in _choiceButtons)
		{
            b.gameObject.SetActive(false);
		}

        for (int i = 0; i < choices.Length; ++i)
		{
            _choiceButtons[i].gameObject.SetActive(true);
            _choiceButtons[i].GetComponentInChildren<TMP_Text>().text = choices[i].GetTitle();
            
            int index = i;
            _choiceButtons[i].onClick.AddListener(() => StoryUpdate(choices[index]));
        }
	}
}
