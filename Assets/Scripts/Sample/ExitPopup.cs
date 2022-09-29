using UnityEngine;
using UnityEngine.UI;

public class ExitPopup : Popup
{
    [SerializeField] private Button confirmButton;
    [SerializeField] private Button cancelButton;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        confirmButton.onClick.AddListener(Application.Quit);
        cancelButton.onClick.AddListener(Close);
    }
}
