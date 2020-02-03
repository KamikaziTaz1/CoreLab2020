using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("My Scripts / Game Manager")]
[SelectionBase]
public class GameManager : MonoBehaviour
{   
    [ContextMenuItem("Get a random time", "PickRandomGameLength")]//allows you to call functions on the fly by right clicking
    [Header("Important game variables")]
    [Range(0, 100f), Tooltip("This is the game length")] public float GameLength; //tooltips will tell you what the function does in the inspector itself, 
                                                                                  //good way to document stuff

    #region initializing
    public int startScore;

    [Header("References to other scripts")]

    public ScoreManager scoreManager;


    [HideInInspector] public float animDuration = 10f;//hides what is public

    [SerializeField] private float playerHealth;//shows what is private, but can't be accessed by other scripts (obviously)

    [Tooltip("This is the player's name")] public string pl_name;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager.IncreaseScore(5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    #endregion
    
    [ContextMenu("Randomize Time")]
    void PickRandomGameLength(){
        GameLength = Random.Range(0f, 100f);
    }
}
