using Gisha.PatternsPractice.CommandPattern.Interfaces;
using UnityEngine;

namespace Gisha.PatternsPractice.CommandPattern.Commands
{
    public abstract class Command
    {
        protected IEntity _entity;

        protected Command(IEntity entity)
        {
            _entity = entity;
        }

        public abstract void Execute();
        public abstract void Undo();
    }

    internal class MoveToCommand : Command
    {
        private Vector3 _destination;
        private Vector3 _originalPosition;

        public MoveToCommand(IEntity entity, Vector3 destination) : base(entity)
        {
            _destination = destination;
        }

        public override void Execute()
        {
            _originalPosition = _entity.transform.position;
            _entity.MoveFromTo(_originalPosition, _destination);
        }

        public override void Undo()
        {
            _entity.MoveFromTo(_entity.transform.position, _originalPosition);
        }
    }
}