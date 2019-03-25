/* TrieWithNoChildren.cs
 * Author: Karijanna Miller
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    /// <summary>
    /// Used for nodes with no children
    /// </summary>
    public class TrieWithNoChildren : ITrie
    {
        /// <summary>
        /// Whether the trie contains an empty string
        /// </summary>
        private bool _empty = false;
        /// </summary>
        /// Adds a string to trie
        /// <param name="s">Given string</param>
        /// <returns>The node with no children</returns>
        /// </summary>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _empty = true;
                return this;
            }
            else
            {
                return new TrieWithOneChild(s, _empty);
            }
        }
        /// <summary>
        /// Whether it contains string
        /// </summary>
        /// <param name="s">Given string</param>
        /// <returns>True or false</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _empty;
            }
            else
            {
                return false;
            }
        }
    }
}
