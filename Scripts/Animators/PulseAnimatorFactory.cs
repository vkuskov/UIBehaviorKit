using UnityEngine;

namespace UIBehaviourKit.Animators {

    [CreateAssetMenu(menuName="UIBehaviourKit/Pulse Animation", fileName="ui_pulse_animation.asset")]
    public sealed class PulseAnimatorFactory : SimpleAnimatorFactory {
        [SerializeField]
        private AnimationCurve curveIn = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
        [SerializeField]
        private AnimationCurve curveOut = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 0));

        public override ISimpleAnimator CreateSimpleAnimator() {
            return new Pulse(curveIn, curveOut, looped, animationScale);
        }
    }
}
