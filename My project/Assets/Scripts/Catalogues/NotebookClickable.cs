using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class NotebookClickable : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            var text = GetComponent<TextMeshProUGUI>();
            var linkIndex = TMP_TextUtilities.FindIntersectingLine(text, eventData.position, Camera.main);
            if (linkIndex == -1)
                return;
            var count = text.textInfo.characterCount;
            var canvas = GameObject.Find("Canvas");
            var line = (GameObject)Instantiate(Resources.Load("PenLine"), canvas.transform);
            line.transform.position = new Vector3(-0.3f - (2.5f - 0.07f * count), transform.position.y + 0.3f, 0);
            line.transform.localScale = new Vector3(count * 10, 50, 1);
        }
    }
}