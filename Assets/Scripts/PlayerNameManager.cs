using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerNameManager : MonoBehaviour
{
    public static PlayerNameManager Instance;

    public string playerName;

    [SerializeField]
    private InputField playerNameInput;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        if(playerNameInput.text != null && !playerNameInput.text.Equals(""))
        {
            playerName = playerNameInput.text;
            SceneManager.LoadScene("main");
        }
    }
}
