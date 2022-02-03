namespace Tilia.Input.UnityInputSystem
{
#if OPENXR_DEFINED && SPATIALTRACKING_DEFINED
    using UnityEngine;
    using UnityEngine.Experimental.XR.Interaction;
    using UnityEngine.SpatialTracking;

    public class OpenXRPoseProvider : BasePoseProvider
    {
        public UnityEngine.XR.OpenXR.Input.Pose Pose { get; set; }

        public override PoseDataFlags GetPoseFromProvider(out Pose output)
        {
            PoseDataFlags flags = PoseDataFlags.NoData;
            output = default;
            if (Pose.trackingState.HasFlag(UnityEngine.XR.InputTrackingState.Position))
            {
                flags |= PoseDataFlags.Position;
                output.position = Pose.position;
            }
            if (Pose.trackingState.HasFlag(UnityEngine.XR.InputTrackingState.Rotation))
            {
                flags |= PoseDataFlags.Rotation;
                output.rotation = Pose.rotation;
            }
            return flags;
        }
    }
#else
    using UnityEngine;

    public class OpenXRPoseProvider : MonoBehaviour
    {
        public Pose Pose { get; set; }
    }
#endif
}