using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPopup : Popup
{
	[SerializeField] private TextMeshProUGUI userInfoText;
	[SerializeField] private Button exitButton;

	protected override void Start()
	{
		base.Start();

		exitButton.onClick.AddListener(() => PopupManager.Instance.Open<ExitPopup>("ExitPopup"));
	}

	public void SetData(UserData myUserData)
	{
		userInfoText.text = $"Lv.{myUserData.level} {myUserData.name}";
	}
}
