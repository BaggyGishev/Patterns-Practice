using System.Collections;
using Gisha.PatternsPractice.CommandPattern.Commands;
using Gisha.PatternsPractice.CommandPattern.Interfaces;
using UnityEngine;

namespace Gisha.PatternsPractice.CommandPattern.Core
{
    [RequireComponent(typeof(CommandProcessor))]
    [RequireComponent(typeof(ClickInputReader))]
    public class ClickToMoveEntity : MonoBehaviour, IEntity
    {
        private ClickInputReader _clickInputReader;
        private CommandProcessor _commandProcessor;

        private Coroutine _moveCoroutine;

        private void Awake()
        {
            _clickInputReader = GetComponent<ClickInputReader>();
            _commandProcessor = GetComponent<CommandProcessor>();
        }

        private void Update()
        {
            var newPosition = _clickInputReader.GetClickPosition();

            if (newPosition != null)
                _commandProcessor.ExecuteCommand(new MoveToCommand(this, newPosition.Value));

            if (Input.GetKeyDown(KeyCode.Backspace))
                _commandProcessor.Undo();
        }

        public void MoveFromTo(Vector3 startPosition, Vector3 endPosition)
        {
            if (_moveCoroutine != null)
                StopCoroutine(_moveCoroutine);

            _moveCoroutine = StartCoroutine(MoveFromToCoroutine(startPosition, endPosition));
        }

        private IEnumerator MoveFromToCoroutine(Vector3 startPosition, Vector3 endPosition)
        {
            float elapsed = 0;

            while (elapsed < 1f)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, elapsed);
                elapsed += Time.deltaTime;

                yield return null;
            }

            transform.position = endPosition;
        }
    }
}