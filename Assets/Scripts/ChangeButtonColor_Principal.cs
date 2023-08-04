using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor_Principal : MonoBehaviour
{
    private Button button;
    private Image imagem;
    public Bolinha bolinha;

    // Lista de cores predefinidas
    private Color[] colors = new Color[] {
        Color.red,
        Color.magenta,
        Color.blue,
        Color.cyan,
        Color.green,
        Color.yellow
    };

    // Índice para acompanhar a cor atual
    private int currentColorIndex = 0;

    void Start()
    {
        button = GetComponent<Button>();
        imagem = GetComponent<Image>();
        imagem.color = Bolinha.COLOR_CLIQUE;
        button.onClick.AddListener(ChangeColor);
    }

    void ChangeColor()
    {
        // Obter a próxima cor da lista
        Color newColor = colors[currentColorIndex];

        // Atualizar o índice da cor para a próxima cor
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        // Atualizar a cor do clique
        Bolinha.COLOR_CLIQUE = newColor;

        // Logar a nova cor
        Debug.Log(newColor);

        // Atualizar a cor da imagem
        imagem.color = newColor;
    }
}

