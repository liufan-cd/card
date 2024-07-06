
using src.card_framework.abs;
using UnityEngine;

namespace src.card_framework.view
{
    public class CardContainerView : AbsView {
        private Vector3 _offset;

        public Vector3 GetOffset()
        {
            return _offset;
        }

        public void SetOffset(Vector3 offset)
        {
            _offset = offset;
        }
    }
}