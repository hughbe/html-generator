using System;
using System.Collections.Generic;

namespace HtmlGenerator
{
    public abstract class HtmlNode : SerializableHtmlObject
    {
        public HtmlNode NextNode => (HtmlNode)_next;
        public HtmlNode PreviousNode => (HtmlNode)_previous;

        public void AddAfterSelf(HtmlNode content)
        {
            Requires.NotNull(content, nameof(content));

            if (ReferenceEquals(this, content))
            {
                throw new InvalidOperationException("Cannot add a node as before itself.");
            }
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("The node has already been added to this node.");
            }
            if (Parent == null)
            {
                throw new InvalidOperationException("This node does not have a parent.");
            }
            AddNodeAfter(Parent, this, content);
        }

        public void AddAfterSelf(params HtmlNode[] content) => AddAfterSelf((IEnumerable<HtmlNode>)content);

        public void AddAfterSelf(IEnumerable<HtmlNode> content)
        {
            Requires.NotNull(content, nameof(content));

            HtmlNode current = this;
            foreach (HtmlNode node in content)
            {
                current.AddAfterSelf(node);
                current = node;
            }
        }

        public void AddBeforeSelf(HtmlNode content)
        {
            Requires.NotNull(content, nameof(content));

            if (ReferenceEquals(this, content))
            {
                throw new InvalidOperationException("Cannot add a node as before itself.");
            }
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("The node has already been added to this node.");
            }
            if (Parent == null)
            {
                throw new InvalidOperationException("This node does not have a parent.");
            }
            AddNodeBefore(Parent, this, content);
        }

        public void AddBeforeSelf(params HtmlNode[] content) => AddBeforeSelf((IEnumerable<HtmlNode>)content);

        public void AddBeforeSelf(IEnumerable<HtmlNode> content)
        {
            Requires.NotNull(content, nameof(content));

            HtmlNode current = this;
            foreach (HtmlElement element in content)
            {
                current.AddBeforeSelf(element);
                current = element;
            }
        }

        protected static void AddNodeAfter(HtmlElement parent, HtmlNode previousNode, HtmlNode node)
        {
            node.RemoveFromParent();
            node.Parent = parent;
            parent._nodes.AddAfter(previousNode, node);
        }

        protected static void AddNodeBefore(HtmlElement parent, HtmlNode nextNode, HtmlNode node)
        {
            node.RemoveFromParent();
            node.Parent = parent;
            parent._nodes.AddBefore(nextNode, node);
        }

        public IEnumerable<HtmlNode> NextNodes()
        {
            HtmlObject nextNode = _next;
            while (nextNode != null)
            {
                yield return (HtmlNode)nextNode;
                nextNode = nextNode._next;
            }
        }

        public IEnumerable<HtmlNode> PreviousNodes()
        {
            HtmlObject previousNode = _previous;
            while (previousNode != null)
            {
                yield return (HtmlNode)previousNode;
                previousNode = previousNode._previous;
            }
        }

        public void RemoveFromParent()
        {
            if (Parent == null)
            {
                return;
            }
            Parent._nodes.Remove(this);
            Parent = null;
        }
    }
}
