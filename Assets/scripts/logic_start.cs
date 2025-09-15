using UnityEngine;
using UnityEngine.SceneManagement;

public class logic_start : MonoBehaviour
{
    public void start_game()
    {
        SceneManager.LoadScene("game_scene");
    }
}
