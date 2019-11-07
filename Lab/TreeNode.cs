using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    /// <summary>
    /// Представляет узел дерева
    /// </summary>
    public class TreeNode
    {
        private readonly List<TreeNode> nextNodes;

        /// <summary>
        /// Последовательность дочерних узлов
        /// </summary>
        public IEnumerable<TreeNode> Next => nextNodes;

        /// <summary>
        /// Получает или задает числовое значение текущего узла
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TreeNode"/> числовым значением
        /// </summary>
        /// <param name="value">Числовое значение узла</param>
        public TreeNode(int value)
        {
            nextNodes = new List<TreeNode>();
            Value = value;
        }

        /// <summary>
        /// Создает новый дочерний узел для текущего узла
        /// </summary>
        /// <param name="value">Числовое значение текущего узла</param>
        /// <returns>Новый узел</returns>
        public TreeNode CreateNext(int value)
        {
            TreeNode node = new TreeNode(value);
            nextNodes.Add(node);
            return node;
        }
    }
}
