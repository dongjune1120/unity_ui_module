using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PopupManager : Singleton<PopupManager>
{
    private readonly string parentPath = "Prefabs/UI/Popup";

    private List<Popup> popupList = new List<Popup>();

    public T Open<T>(string prefabName) where T : Popup
    {
        GameObject popupPrefab = Resources.Load<GameObject>(Path.Combine(parentPath, prefabName));
        T popup = Instantiate(popupPrefab, transform).GetComponent<T>();		
		popup.Show();
		popupList.Add(popup);
		return popup;
    }

    public async void Close(Popup popup)
    {
		if (!popupList.Contains(popup))
            return;

        popupList.Remove(popup);
        await popup.Hide();
        Destroy(popup.gameObject);
    }

	public void CloseAll()
    {
        for (var i = 0; i < popupList.Count; i++)
        {
            popupList[i].HideImmediate();
            Destroy(popupList[i].gameObject);
        }
    }
}
