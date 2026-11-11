using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Mana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public Animator animator;

    void Start()
    {
        UpdateManaUI();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.rKey.wasPressedThisFrame)
        {
            if (mana >= 10)
            {
                mana -= 10;
                UpdateManaUI();
                animator.SetTrigger("Cast");
            }
        }
    }

    void UpdateManaUI()
    {
        manaText.text = "Mana: " + mana;
    }
}