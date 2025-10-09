using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] public CanvasGroup startGameCG;
    [SerializeField] public CanvasGroup gameCG;
    [SerializeField] public CanvasGroup player1WinCG;
    [SerializeField] public CanvasGroup player2WinCG;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        ShowCG(gameCG);
        HideCG(startGameCG);
        HideCG(player1WinCG);
        HideCG(player2WinCG);

        Time.timeScale = 1;
    }

    //public void EndGame()
    //{

    //}

    public void ShowCG(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    public void HideCG(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void PlayAgainButtonCallBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
