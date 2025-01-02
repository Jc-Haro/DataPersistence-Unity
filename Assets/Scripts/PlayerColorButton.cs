using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorButton : MonoBehaviour
{
    [SerializeField] Color color;
    [SerializeField] PlayerColorSelector colorSelector;

    private void Start()
    {
        if(PlayerColorData.Instance.currentColor == color)
        {
            colorSelector.MoveFrame(gameObject.transform);
        }
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() => PickColor());
    }

    public void PickColor()
    {
        PlayerColorData.Instance.ChangeColor(color);
        colorSelector.MoveFrame(gameObject.transform);
    }
}
