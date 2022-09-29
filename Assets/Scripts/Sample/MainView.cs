using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{	
	[SerializeField] private Button menuButton;    

    private void Start()
    {        
        menuButton.onClick.AddListener(() =>
        {
            var popup = PopupManager.Instance.Open<MenuPopup>("MenuPopup");
            popup.SetData(GameManager.Instance.MyData);
        });
    }
}
