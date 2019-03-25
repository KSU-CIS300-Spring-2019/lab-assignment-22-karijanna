/* TrieWithOneChild.cs
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
    /// Used for nodes with exacytly one child
    /// </summary>
    public class TrieWithOneChild : ITrie
    {
        /// <summary>
        /// Whether the trie contains an empty string
        /// </summary>
        private bool _empty = false;
        /// <summary>
        /// The only child
        /// </summary>
        private ITrie _child;
        /// <summary>
        /// The child's label
        /// </summary>
        char label;
        /// <summary>
        /// Adds a string to trie
        /// </summary>
        /// <param name="s">The given string</param>
        /// <returns>The only child</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _empty = true;
                return this;
            }
            else if (s[0] == label)
            {
                _child = _child.Add(s.Substring(1));
                return this;
            }
            else
            {
                return new TrieWithManyChildren(s, _empty, label, _child);
            }
        }
        /// <summary>
        /// Checking the strings that trie contains
        /// </summary>
        /// <param name="s">String in trie</param>
        /// <returns>Whether string contains or not</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _empty;
            }
            else if (s[0] == label)
            {
                return _child.Contains(s.Substring(1));
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="s">Given string</param>
        /// <param name="stored">Whether the string is stored</param>
        public TrieWithOneChild(string s, bool stored)
        {
            if (s == null || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            _empty = stored;
            label = s[0];
            _child = new TrieWithNoChildren().Add(s.Substring(1));
        }
    }
}
