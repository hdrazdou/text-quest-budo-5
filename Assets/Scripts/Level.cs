using UnityEngine;

public class Level : MonoBehaviour
{
    #region Variables

    [TextArea]
    public string Answers;
    [TextArea]
    public string Description;

    public Sprite Image;

    public string LevelName;

    public Level[] NextLevels;

    #endregion
}