using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Omnifinity.Omnideck
{
    public class OmnideckContinousMoveProvider : ContinuousMoveProviderBase
    {
        /// <summary>
        /// The Omnideck API
        /// </summary>
        [SerializeField]
        private OmnideckInterface m_omnideckInterface;

        /// <summary>
        /// Tie into the LocomotionSystem
        /// </summary>
        protected override void Awake()
        {
            base.Awake();
        }

        /// <summary>
        /// Reads the value of the move input (coming from Omnideck interface).
        /// Will drive the Charactercontroller via the ContinousMoveProviderBase class.
        /// </summary>
        /// <returns>Returns the input vector, for the Omnideck character.</returns>
        protected override Vector2 ReadInput()
        {
            if (m_omnideckInterface == null)
                return Vector2.zero;

            Vector3 movementVector = m_omnideckInterface.GetCurrentOmnideckCharacterMovementVector();

            return new Vector2(movementVector.x, movementVector.z);
        }
    }
}