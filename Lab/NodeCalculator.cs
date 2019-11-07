using System;
using System.Linq;

namespace Lab1
{
    /// <summary>
    /// Содержит инструменты для работы с деревьями
    /// </summary>
    public static class NodeCalculator
    {
        /// <summary>
        /// Находит ветку с минимальной суммой элементов
        /// </summary>
        /// <param name="node">Узел, с которого начать обход</param>
        /// <returns>Минимальная сумма</returns>
        public static int FindMinPathSum(TreeNode node)
        {
            if (node.Next.Count() == 0)
                return node.Value;
            return node.Value + node.Next.Min(cur => FindMinPathSum(cur));
        }

        /// <summary>
        /// Находит ветку с максимальной суммой элементов
        /// </summary>
        /// <param name="node">Узел, с которого начать обход</param>
        /// <returns>Максимальная сумма</returns>
        public static int FindMaxPathSum(TreeNode node)
        {
            if (node.Next.Count() == 0)
                return node.Value;
            return node.Value + node.Next.Max(cur => FindMaxPathSum(cur));
        }

        /// <summary>
        /// Возвращает количество дочерних узлов во всех подузлах
        /// </summary>
        /// <param name="node">Узел, с которого начать обход</param>
        /// <returns>Количество узлов</returns>
        public static int CountAll(TreeNode node) => node.Next.Select(cur => CountAll(cur)).Sum() + 1;

        /// <summary>
        /// Проверяет наличие узла с заданным значением в дереве
        /// </summary>
        /// <param name="node">Узел, с которого начать обход</param>
        /// <param name="value">Искомое значение узла</param>
        /// <returns>true, если узел найден</returns>
        public static bool Contains(TreeNode node, int value) =>
            node.Value == value
            || node.Next.Select(cur => Contains(cur, value)).Contains(true);

        /// <summary>
        /// Возвращает минимальное значение в текущем узле и всех его подузлах
        /// </summary>
        /// <param name="node">Узел, с которого начать обход</param>
        /// <returns>Минимальное значение в узле и подузлах</returns>
        public static int FindMinValue(TreeNode node)
        {
            if (node.Next.Count() == 0)
                return node.Value;
            int minChild = node.Next.Min((cur) => FindMinValue(cur));
            return Math.Min(node.Value, minChild);
        }

        /// <summary>
        /// Возвращает максимальное значение в текущем узле и всех его подузлах
        /// </summary>
        /// <param name="node">Узел, с которого начать обход</param>
        /// <returns>Максимальное значение в узле и подузлах</returns>
        public static int FindMaxValue(TreeNode node)
        {
            if (node.Next.Count() == 0)
                return node.Value;
            int maxChild = node.Next.Max((cur) => FindMaxValue(cur));
            return Math.Max(node.Value, maxChild);
        }
    }
}
