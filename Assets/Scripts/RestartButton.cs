using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private void Start()
    {
        // Adicionar o método RestartScene() ao evento de clique do botão
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(RestartScene);
    }

    private void Update()
    {
        // Verificar se a tecla F5 foi pressionada
        if (Input.GetKeyDown(KeyCode.F5))
        {
            RestartScene();
        }

        // if (Input.GetKeyDown(KeyCode.Escape))
        // {
        //     Application.Quit();
        // }
    }

    private void RestartScene()
    {
        // Reiniciar a cena atual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
