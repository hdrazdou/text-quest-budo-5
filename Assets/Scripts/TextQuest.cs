using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public TMP_Text LevelNameLabel;
    public TMP_Text DescriptionLabel;
    public TMP_Text AnswersLabel;
    public Image LevelImage; // UnityEngine.UI.Image тип нужен, чтоб поле появилось в TextQuest объекте

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
            if (Input.GetKeyDown(_inputKeys[i]) && IsNextLevelCreated(i))
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
        LevelNameLabel.text = _currentLevel.LevelName;
        LevelImage.sprite = _currentLevel.Image; // превращаем LevelImage в спрайт, чтоб в него засетать Image (который тоже спрайт)
    }

    #endregion
}