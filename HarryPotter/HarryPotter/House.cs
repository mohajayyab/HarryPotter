using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public delegate void TraversalHandeler(Wizard instance);

    public class House/*<TKey, TValue> where TKey : IComparable where TValue : Wizard*/
    {
        class BSTNode
        {
            public Wizard data;
            public int key;
            public BSTNode leftChild;
            public BSTNode rightChild;
        }


        BSTNode root;

        public void Insert(Wizard data, int key)
            {
                // First phase
                BSTNode newNode = new BSTNode();
                newNode.data = data;
                newNode.key = key;
                newNode.leftChild = null;
                newNode.rightChild = null;

                // Second phase
                RecursiveInsert(ref root, newNode);
            }

        private void RecursiveInsert(ref BSTNode currentRoot, BSTNode newNode)
        {
            if (currentRoot == null)
            {
                currentRoot = newNode;
            }
            else
            {
                if (currentRoot.key.CompareTo(newNode.key) == 0)
                {
                     
                }
                else
                {
                    if (currentRoot.key.CompareTo(newNode.key) > 0)
                    {
                        RecursiveInsert(ref currentRoot.leftChild, newNode);
                    }
                    else if (currentRoot.key.CompareTo(newNode.key) < 0)
                    {
                        RecursiveInsert(ref currentRoot.rightChild, newNode);
                    }
                    else //(currentRoot.Key.Equals(newNode.Key))
                    {
                        throw new Exception("Key must be unique.");
                    }
                }


                
            }
        }



        //public void Traversal(TraversalHandeler callback)
        //{
        //    Traversal(root, callback);
        //}

        //void Traversal(BSTNode root, TraversalHandeler callback)
        //{
        //    if (root != null)
        //    {
        //        // In-order strategy
        //        Traversal(root.leftChild, callback);
        //        callback.Invoke(root.data);
        //        Traversal(root.leftChild, callback);
        //    }
        //}


        public List<Wizard> GetWizardsWithProperty(string propertyName, int minValue)
        {
            List<Wizard> result = new List<Wizard>();
            Traverse(root, node =>
            {
                var propertyValue = (int)typeof(Wizard).GetProperty(propertyName).GetValue(node);
                if (propertyValue >= minValue)
                    result.Add(node);
            });
            return result;
        }

        private void Traverse(BSTNode root, TraversalHandeler callback)
        {
            if (root != null)
            {
                Traverse(root.leftChild, callback);
                callback.Invoke(root.data);
                Traverse(root.rightChild, callback);
            }
        }





    }
}
