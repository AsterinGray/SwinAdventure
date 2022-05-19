using System.Collections.Generic;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            _identifiers.AddRange(idents);
        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id);
        }

        public string FirstId
        {
            get { return _identifiers[0]; }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
