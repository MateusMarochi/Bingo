using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public GameObject[] parentObjects; // Insira os 5 GameObjects aqui no Unity Inspector

    private void Start()
    {
        // Adicionar o método DeactivateToggles() ao evento de clique do botão
        GetComponent<Button>().onClick.AddListener(DeactivateToggles);
    }

    private void Update()
    {
        // Verificar se a tecla F5 foi pressionada
        if (Input.GetKeyDown(KeyCode.F5))
        {
            DeactivateToggles();
        }
    }

    private void DeactivateToggles()
    {
        foreach (var parentObject in parentObjects)
        {
            // Obtenha todos os componentes Toggle dos filhos do GameObject
            Toggle[] toggles = parentObject.GetComponentsInChildren<Toggle>();

            // Desative todos os Toggles
            foreach (Toggle toggle in toggles)
            {
                toggle.isOn = false;
            }
        }
    }
}
