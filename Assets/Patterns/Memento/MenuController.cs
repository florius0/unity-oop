using System;
using UnityEngine;

namespace Patterns.Memento
{
    public interface ISnapshotable
    {
        public Action GetCurrentStateApplyingFunction();
    }

    [RequireComponent(typeof(MenuHistory))]
    public class MenuController : MonoBehaviour, ISnapshotable
    {
        [SerializeField]
        private GameObject Page1;

        [SerializeField]
        private GameObject Page2;

        [SerializeField]
        private GameObject Page3;

        private MenuHistory _history;

        private void Awake()
        {
            _history = GetComponent<MenuHistory>();
        }

        public void OpenPage1()
        {
            _history.Do(
                new MenuSnapshot(
                    () =>
                    {
                        Page1.SetActive(true);
                        Page2.SetActive(false);
                        Page3.SetActive(false);
                    }, this
                )
            );
        }

        public void OpenPage2()
        {
            _history.Do(
                new MenuSnapshot(
                    () =>
                    {
                        Page1.SetActive(false);
                        Page2.SetActive(true);
                        Page3.SetActive(false);
                    }, this
                )
            );
        }

        public void OpenPage3()
        {
            _history.Do(
                new MenuSnapshot
                (
                    () =>
                    {
                        Page1.SetActive(false);
                        Page2.SetActive(false);
                        Page3.SetActive(true);
                    }, this
                )
            );
        }

        public Action GetCurrentStateApplyingFunction()
        {
            var page1 = Page1.activeSelf;
            var page2 = Page2.activeSelf;
            var page3 = Page3.activeSelf;

            return () =>
            {
                Page1.SetActive(page1);
                Page2.SetActive(page2);
                Page3.SetActive(page3);
            };
        }
    }
}