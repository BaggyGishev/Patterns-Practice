using UnityEngine;

namespace Gisha.PatternsPractice.CommandPattern.Interfaces
{
    public interface IEntity
    {
        Transform transform { get; }
        void MoveFromTo(Vector3 startPosition, Vector3 endPosition);
    }
}