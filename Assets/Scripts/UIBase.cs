using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public abstract class UIBase : MonoBehaviour
{
	protected CanvasGroup canvasGroup;

	protected virtual void Awake()
	{
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public virtual async Task Show()
	{
		HideImmediate();

		await canvasGroup.DOFade(1f, 0.2f).AsyncWaitForCompletion();
	}

	public void ShowImmediate()
	{
		canvasGroup.alpha = 1f;
	}

	public virtual async Task Hide()
	{
		await canvasGroup.DOFade(0f, 0.2f).AsyncWaitForCompletion();
	}

	public void HideImmediate()
	{
		canvasGroup.alpha = 0f;
	}
}
