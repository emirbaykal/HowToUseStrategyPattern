using UnityEngine;
using UnityEngine.UI;

namespace Hero
{
    public class HeadsUpDisplay : MonoBehaviour
    {
        [SerializeField] private Button[] buttons;

        public delegate void ButtonPressedEvent(int index);

        public static event ButtonPressedEvent OnButtonPressed;

        private void Awake()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                int index = i;
                buttons[i].onClick.AddListener(() => HandleButtonPress(index));
            }
        }

        void HandleButtonPress(int index) => OnButtonPressed?.Invoke(index);
    }
}
