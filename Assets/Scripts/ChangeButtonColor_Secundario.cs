using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor_Secundario : MonoBehaviour
{
    private Button button;
    private Image imagem;
    public Bolinha bolinha;

    // Lista de cores predefinidas
    private Color[] colors = new Color[] {
        new Color(0f, 0f, 0f, 1f),     // 0% gray
        new Color(0.125f, 0.125f, 0.125f, 1f), // 12.5% gray
        new Color(0.25f, 0.25f, 0.25f, 1f),   // 25% gray
        new Color(0.375f, 0.375f, 0.375f, 1f), // 37.5% gray
        new Color(0.5f, 0.5f, 0.5f, 1f)    // 50% gray
    };

    // Índice para acompanhar a cor atual
    private int currentColorIndex = 0;

    void Start()
    {
        button = GetComponent<Button>();
        imagem = GetComponent<Image>();
        imagem.color = Bolinha.COLOR_ESPERA;
        button.onClick.AddListener(ChangeColor);
    }

    void ChangeColor()
    {
        // Obter a próxima cor da lista
        Color newColor = colors[currentColorIndex];

        // Atualizar o índice da cor para a próxima cor
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        // Atualizar a cor do clique
        Bolinha.COLOR_ESPERA = newColor;

        // Logar a nova cor
        Debug.Log(newColor);

        // Atualizar a cor da imagem
        imagem.color = newColor;
    }
}

