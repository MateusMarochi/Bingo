using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolinha : MonoBehaviour
{
    public static Color COLOR_CLIQUE = Color.yellow;
    public static Color COLOR_ESPERA = new Color(0.3f, 0.3f, 0.3f, 1f);

    public string numero { get; set; }

    private Text Numero;
    private Toggle Clique;
    private Image Btn_Clicado;
    private Image Btn_Espera;

    void Awake()
    {
        Numero = GetComponentInChildren<Text>();
        Clique = GetComponent<Toggle>();
        Btn_Clicado = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        Btn_Espera = transform.GetChild(0).GetComponent<Image>();

        Btn_Clicado.color = COLOR_CLIQUE;
        Btn_Espera.color = COLOR_ESPERA;

        Clique.onValueChanged.AddListener(OnToggleValueChanged);
        SetNumero(numero);
    }

    private void OnToggleValueChanged(bool value)
    {
        UpdateLuminance(value ? COLOR_CLIQUE : COLOR_ESPERA);
    }

    public void SetNumero(string numero)
    {
        Numero.text = numero;
    }

    public void Update()
    {
        if (Btn_Clicado.color != COLOR_CLIQUE)
        {
            Btn_Clicado.color = COLOR_CLIQUE;
            UpdateLuminance(Clique.isOn ? COLOR_CLIQUE : COLOR_ESPERA);
        }

        if (Btn_Clicado.color != COLOR_ESPERA)
        {
            Btn_Espera.color = COLOR_ESPERA;
            UpdateLuminance(Clique.isOn ? COLOR_CLIQUE : COLOR_ESPERA);
        }

    }

    private void UpdateLuminance(Color color)
    {
        float luminance = 0.299f * color.r + 0.587f * color.g + 0.114f * color.b;
        Numero.color = luminance > 0.5f ? Color.black : Color.white;
    }
}
