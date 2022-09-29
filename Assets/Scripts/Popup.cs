using UnityEngine;
using UnityEngine.UI;

public class Popup : UIBase
{
    [SerializeField] private Button backgroundButton;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        backgroundButton?.onClick.AddListener(Close);
    }

    protected void Close()
    {
        PopupManager.Instance.Close(this);
	}
}
