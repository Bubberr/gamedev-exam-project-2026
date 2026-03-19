using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public bool gameEnded = false;

    void Start()
    {
        Debug.Log("GameManager is active");
    }
    
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: "+ score);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            AddScore(10);
        }
    }

    public void GameOver()
    {
        if (gameEnded) return;
        
        gameEnded = true;
        Time.timeScale = 0f;
        Debug.Log("GAME OVER");
    }

    public void WinGame()
    {
        if (gameEnded) return;
        
        gameEnded = true;
        Time.timeScale = 0f;
        Debug.Log("YOU WIN");
    }

}
