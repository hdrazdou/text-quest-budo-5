using UnityEngine;

public class Level : MonoBehaviour
{
    #region Variables

    [TextArea]
    public string Answers;
    [TextArea]
    public string Description;

    public Level[] NextLevels;

    #endregion
}