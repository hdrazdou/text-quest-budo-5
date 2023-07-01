using TMPro;
using UnityEngine;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public TMP_Text AnswersLabel;
    public TMP_Text DescriptionLabel;

    public Level StartLevel;
    private Level _currentLevel;
    private readonly KeyCode[] _inputKeys =
    {
        KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3,
        KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6,
        KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9,
    };

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _currentLevel = StartLevel;
        UpdateUi();
    }

    private void Update()
    {
        for (int i = 0; i < _inputKeys.Length; i++)
        {
            if (Input.GetKeyDown(_inputKeys[i])&&IsNextLevelCreated(i))
            {
                _currentLevel = GetNextLevel(i);
                UpdateUi();
            }
        }
    }

    #endregion

    #region Private methods

    private Level GetNextLevel(int index)
    {
        return _currentLevel.NextLevels[index];
    }

    private bool IsNextLevelCreated(int index)
    {
        return _currentLevel.NextLevels.Length > index;
    }

    private void UpdateUi()
    {
        DescriptionLabel.text = _currentLevel.Description;
        AnswersLabel.text = _currentLevel.Answers;
    }

    #endregion
}