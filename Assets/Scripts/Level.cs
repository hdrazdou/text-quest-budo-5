using UnityEngine;

public class Level : MonoBehaviour
{
    #region Variables

    [TextArea]
    public string Answers;
    [TextArea]
    public string Description;

    public string LevelName;

    public Level[] NextLevels;

    public Sprite Image;

    #endregion
}