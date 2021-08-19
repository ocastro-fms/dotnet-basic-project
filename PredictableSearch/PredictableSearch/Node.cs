namespace PredictableSearch
{
    using System.Collections.Generic;
    using System.Linq;

    public class Node
    {
        private Dictionary<char, Node> children = new Dictionary<char, Node>();
        private bool isEndOfWord = false;

        public Node()
        {
        }

        public void Insert(string word)
        {
        }

        public bool Search(string word)
        {
            return false;
        }

        public IEnumerable<string> Suggest(string prefix)
        {
            yield break;
        }

        public int Count()
        {
            return this.count(this);
        }

        private int count(Node node)
        {
            int result = 1;
            foreach (var n in node.children.Values)
            {
                result += this.count(n);
            }
            return result;
        }
    }
}
