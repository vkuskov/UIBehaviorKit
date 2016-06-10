using UnityEngine;

namespace UIBehaviourKit.Animators {

    public abstract class SimpleAnimatorFactory : ScriptableObject, ISimpleAnimatorFactory {
        [SerializeField]
        protected bool looped = false;
        [SerializeField]
        protected float animationScale = 1.0f;

        public abstract ISimpleAnimator CreateSimpleAnimator();
    }
}